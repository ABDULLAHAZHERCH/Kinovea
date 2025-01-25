using System;
using System.Drawing;
using System.Windows.Forms;
using Kinovea.Services;
using Kinovea.Video;

namespace Kinovea.ScreenManager
{
    public class CombinedScreen : AbstractScreen
    {
        private CaptureScreen captureScreen;
        private PlayerScreen playerScreen;
        private bool isRecordingMode = true;
        private bool isAutomaticPlaybackEnabled = false;
        public CombinedScreenView combinedView;

        public CaptureScreen CaptureScreen => captureScreen;
        public PlayerScreen PlayerScreen => playerScreen;


        public CombinedScreen()
        {
            //captureScreen = new CaptureScreen();
            //playerScreen = new PlayerScreen();
            combinedView = new CombinedScreenView(this);
        }

        public override Guid Id
        {
            get => isRecordingMode ? captureScreen.Id : playerScreen.Id;
            set
            {
                if (isRecordingMode)
                    captureScreen.Id = value;
                else
                    playerScreen.Id = value;
            }
        }

        public override bool Full => isRecordingMode ? captureScreen.Full : playerScreen.Full;

        public override UserControl UI => isRecordingMode ? captureScreen.UI : playerScreen.UI;

        public override string FileName => isRecordingMode ? captureScreen.FileName : playerScreen.FileName;

        public override string Status => isRecordingMode ? captureScreen.Status : playerScreen.Status;

        public override string FilePath => isRecordingMode ? captureScreen.FilePath : playerScreen.FilePath;

        public override bool CapabilityDrawings => isRecordingMode ? captureScreen.CapabilityDrawings : playerScreen.CapabilityDrawings;

        public override ImageAspectRatio AspectRatio
        {
            get => isRecordingMode ? captureScreen.AspectRatio : playerScreen.AspectRatio;
            set
            {
                if (isRecordingMode)
                    captureScreen.AspectRatio = value;
                else
                    playerScreen.AspectRatio = value;
            }
        }

        public override ImageRotation ImageRotation
        {
            get => isRecordingMode ? captureScreen.ImageRotation : playerScreen.ImageRotation;
            set
            {
                if (isRecordingMode)
                    captureScreen.ImageRotation = value;
                else
                    playerScreen.ImageRotation = value;
            }
        }

        public override Demosaicing Demosaicing
        {
            get => isRecordingMode ? captureScreen.Demosaicing : playerScreen.Demosaicing;
            set
            {
                if (isRecordingMode)
                    captureScreen.Demosaicing = value;
                else
                    playerScreen.Demosaicing = value;
            }
        }

        public override bool Mirrored
        {
            get => isRecordingMode ? captureScreen.Mirrored : playerScreen.Mirrored;
            set
            {
                if (isRecordingMode)
                    captureScreen.Mirrored = value;
                else
                    playerScreen.Mirrored = value;
            }
        }

        public override bool CoordinateSystemVisible
        {
            get => isRecordingMode ? captureScreen.CoordinateSystemVisible : playerScreen.CoordinateSystemVisible;
            set
            {
                if (isRecordingMode)
                    captureScreen.CoordinateSystemVisible = value;
                else
                    playerScreen.CoordinateSystemVisible = value;
            }
        }

        public override bool TestGridVisible
        {
            get => isRecordingMode ? captureScreen.TestGridVisible : playerScreen.TestGridVisible;
            set
            {
                if (isRecordingMode)
                    captureScreen.TestGridVisible = value;
                else
                    playerScreen.TestGridVisible = value;
            }
        }

        public override HistoryStack HistoryStack => isRecordingMode ? captureScreen.HistoryStack : playerScreen.HistoryStack;

        public override void DisplayAsActiveScreen(bool active)
        {
            if (isRecordingMode)
                captureScreen.DisplayAsActiveScreen(active);
            else
                playerScreen.DisplayAsActiveScreen(active);
        }

        public override void BeforeClose()
        {
            captureScreen.BeforeClose();
            playerScreen.BeforeClose();
        }

        public override void AfterClose()
        {
            captureScreen.AfterClose();
            playerScreen.AfterClose();
        }

        public override void RefreshUICulture()
        {
            captureScreen.RefreshUICulture();
            playerScreen.RefreshUICulture();
        }

        public override void PreferencesUpdated()
        {
            captureScreen.PreferencesUpdated();
            playerScreen.PreferencesUpdated();
        }

        public void SetShared(bool shared)
        {
            captureScreen.SetShared(shared);
        }

        public override void RefreshImage()
        {
            if (isRecordingMode)
                captureScreen.RefreshImage();
            else
                playerScreen.RefreshImage();
        }

        public override void AddImageDrawing(string filename, bool isSvg)
        {
            if (isRecordingMode)
                captureScreen.AddImageDrawing(filename, isSvg);
            else
                playerScreen.AddImageDrawing(filename, isSvg);
        }

        public override void AddImageDrawing(Bitmap bmp)
        {
            if (isRecordingMode)
                captureScreen.AddImageDrawing(bmp);
            else
                playerScreen.AddImageDrawing(bmp);
        }

        public override void FullScreen(bool fullScreen)
        {
            if (isRecordingMode)
                captureScreen.FullScreen(fullScreen);
            else
                playerScreen.FullScreen(fullScreen);
        }

        public override void Identify(int index)
        {
            if (isRecordingMode)
                captureScreen.Identify(index);
            else
                playerScreen.Identify(index);
        }

        public override void ExecuteScreenCommand(int cmd)
        {
            if (isRecordingMode)
                captureScreen.ExecuteScreenCommand(cmd);
            else
                playerScreen.ExecuteScreenCommand(cmd);
        }

        public override IScreenDescription GetScreenDescription()
        {
            if (isRecordingMode)
                return captureScreen.GetScreenDescription();
            else
                return playerScreen.GetScreenDescription();
        }

        public override void LoadKVA(string path)
        {
            if (isRecordingMode)
                captureScreen.LoadKVA(path);
            else
                playerScreen.LoadKVA(path);
        }

        public void ToggleMode()
        {
            isRecordingMode = !isRecordingMode;

            if (isRecordingMode)
            {
                // Switch to recording mode
                captureScreen.DisplayAsActiveScreen(true);
                playerScreen.DisplayAsActiveScreen(false);
            }
            else
            {
                // Switch to playback mode
                playerScreen.DisplayAsActiveScreen(true);
                captureScreen.DisplayAsActiveScreen(false);
            }
        }

        public void OnRecordButtonPressed()
        {
            captureScreen.View_ToggleRecording();
            if (isRecordingMode)
            {
                if (captureScreen.Recording)
                {
                    // Stop recording
                    captureScreen.ForceRecordingStatus(false);

                }
                else
                {
                    // Start recording
                    captureScreen.ForceRecordingStatus(true);
                }
            }
            else
            {
                // Switch to recording mode and start recording
                ToggleMode();
                captureScreen.ForceRecordingStatus(true);
            }
        }

        public void OnPlayButtonPressed()
        {
            if (!isRecordingMode)
            {
                if (playerScreen.IsPlaying)
                {
                    // Pause playback
                    playerScreen.StopPlaying();
                }
                else
                {
                    // Start playback
                    playerScreen.EnsurePlaying();
                }
            }
            else if (!captureScreen.Recording)
            {
                // Switch to playback mode
                ToggleMode();
                playerScreen.EnsurePlaying();
            }
        }

        public void OnAutomaticPlaybackButtonPressed()
        {
            isAutomaticPlaybackEnabled = !isAutomaticPlaybackEnabled;

            if (isAutomaticPlaybackEnabled && captureScreen.Recording)
            {
                // Stop recording and enable automatic playback
                captureScreen.ForceRecordingStatus(false);
            }

            if (isAutomaticPlaybackEnabled)
            {
                // Set to playback mode and play automatically after recording ends
                ToggleMode();
                playerScreen.EnsurePlaying();
                playerScreen.Loaded += (s, e) => { playerScreen.StopPlaying(); };
            }
        }
    }
}
