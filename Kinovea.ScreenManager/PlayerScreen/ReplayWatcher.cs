﻿using Kinovea.Services;
using Kinovea.Video;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kinovea.ScreenManager
{
    /// <summary>
    /// Watches a directory for new files and load them in the parent player.
    /// </summary>
    public class ReplayWatcher : IDisposable
    {
        public bool IsEnabled { get; private set; } = false;

        public string WatchedFolder 
        { 
            get { return watcher != null ? watcher.Path : null; } 
        }

        public string FullPath
        {
            get { return watcher != null ? Path.Combine(watcher.Path, filter) : null; }
        }

        private PlayerScreen player;
        private ScreenDescriptionPlayback screenDescription;
        private string currentFile;
        private string filter;
        private FileSystemWatcher watcher;
        private Control dummy = new Control();
        private int overwriteEventCount;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #region Construction/Destruction
        public ReplayWatcher(PlayerScreen player)
        {
            this.player = player;
            IntPtr forceHandleCreation = dummy.Handle; // Needed to show that the main thread "owns" this Control.
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        ~ReplayWatcher()
        {
            Dispose(false);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                Stop();
                dummy.Dispose();
            }
        }
        #endregion

        public void Start(ScreenDescriptionPlayback sdp, string currentFile)
        {
            log.DebugFormat("Starting replay watcher");

            // We should only come here when initializing the player on a watched folder.
            // currentFile might be null if we started a watcher on an empty directory.
            // the screen descriptor should never be null.
            if (sdp == null)
            {
                log.ErrorFormat("Replay watcher started without screen description.");
                Stop();
                return;
            }

            this.screenDescription = sdp;
            this.currentFile = currentFile;
            this.filter = Path.GetFileName(sdp.FullPath);
            string targetDir = Path.GetDirectoryName(sdp.FullPath);

            if (watcher != null)
            {
                if (watcher.Path == targetDir)
                    return;

                Stop();
            }

            if (!Directory.Exists(targetDir))
                return;

            watcher = new FileSystemWatcher(targetDir);

            overwriteEventCount = 0;
            watcher.NotifyFilter = NotifyFilters.LastWrite;
            watcher.Filter = filter;
            watcher.IncludeSubdirectories = false;
            watcher.Changed += watcher_Changed;
            watcher.Created += watcher_Changed;
            watcher.EnableRaisingEvents = true;

            IsEnabled = true;
            log.DebugFormat("Started replay watcher on \"{0}\".", Path.GetFileName(targetDir));
        }

        public void Stop()
        {
            if (watcher == null)
                return;

            string targetDir = watcher.Path;
            watcher.EnableRaisingEvents = false;
            watcher.Changed -= watcher_Changed;
            watcher.Created -= watcher_Changed;
            watcher.Dispose();
            watcher = null;

            currentFile = null;
            IsEnabled = false;

            log.DebugFormat("Stopped replay watcher on \"{0}\".", Path.GetFileName(targetDir));
        }

        private void watcher_Changed(object sender, FileSystemEventArgs e)
        {
            if (!VideoTypeManager.IsSupported(Path.GetExtension(e.FullPath)))
                return;

            log.DebugFormat("Replay watcher received an event: {0}, filename: \"{1}\".", e.ChangeType, e.Name);

            if (e.FullPath == currentFile)
            {
                // Special case where the user is overwriting the currently loaded file.
                // In this case we can't use the normal heuristic of trying to get exclusive access on the file,
                // because the player screen itself already has the file opened.

                // First of all we need to stop the player from playing the file as it's reading frames from disk (no caching).
                dummy.BeginInvoke((Action)delegate { player.StopPlaying(); });

                // We normally receive only two events. One at start and one on close.
                overwriteEventCount++;
                if (overwriteEventCount >= 2)
                {
                    log.DebugFormat("Loading overwritten video.");
                    overwriteEventCount = 0;
                    dummy.BeginInvoke((Action)delegate { LoadVideo(e.FullPath); });
                }
                else
                {
                    log.DebugFormat("The file was just created, it is not ready to be loaded yet.");
                }
            }
            else
            {
                if (FilesystemHelper.CanRead(e.FullPath))
                {
                    log.DebugFormat("Loading new video.");
                    dummy.BeginInvoke((Action)delegate { LoadVideo(e.FullPath); });
                }
                else
                {
                    log.DebugFormat("The file is still being written.");
                }
            }
        }

        /// <summary>
        /// Load the new or updated video in the player.
        /// </summary>
        private void LoadVideo(string path)
        {
            log.DebugFormat("Replay watcher is about to load a video: {0}.", Path.GetFileName(path));

            // Update the descriptor with the speed from the UI.
            screenDescription.SpeedPercentage = player.view.SpeedPercentage;

            if (player.IsWaitingForIdle)
            {
                log.ErrorFormat("Player screen is currently busy loading the previous video. Aborting load.");
                return;
            }

            // Load the video in the player.
            // We send the actual file name in path, at this point the player doesn't need to know this is coming from a watched directory.
            LoaderVideo.LoadVideo(player, path, screenDescription);
            
            if (player.FrameServer.Loaded)
            {
                NotificationCenter.RaiseFileOpened(null, path);
                PreferencesManager.FileExplorerPreferences.AddRecentFile(path);
                PreferencesManager.Save();
            }
        }
    }
}
