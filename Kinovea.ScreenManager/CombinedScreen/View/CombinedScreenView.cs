using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kinovea.ScreenManager
{
    public partial class CombinedScreenView : UserControl
    {
        #region Members

        private CombinedScreen combinedScreen;
        private bool isRecording;
        private bool isPlaying;
        private bool isAutoPlayback;

        #endregion

        public CombinedScreenView(CombinedScreen screen)
        {
            combinedScreen = screen ?? throw new ArgumentNullException(nameof(screen));

            isAutoPlayback = false;
            isPlaying = false;
            isRecording = true;

            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
            UpdateMainPanel();
        }

        private void UpdateMainPanel()
        {
            //this.Controls.Clear(); 
            //var activeUI = combinedScreen.UI;
            //if (activeUI != null)
            //{
            //    this.Controls.Add(activeUI); 
            //    //activeUI.Dock = DockStyle.Fill;
            //}
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            isRecording = !isRecording;
            combinedScreen.OnRecordButtonPressed();
            UpdateMainPanel();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            isPlaying = !isPlaying;
            combinedScreen.OnPlayButtonPressed();
            UpdateMainPanel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isAutoPlayback = !isAutoPlayback;
            combinedScreen.OnAutomaticPlaybackButtonPressed();
            UpdateMainPanel();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
