using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.SessionState;
using System.Windows.Forms;

namespace Kinovea.ScreenManager
{
    public class SingleCapture
    {
        private SingleCapture() { screen = new CaptureScreen(); }
        private static SingleCapture instance = null;
        private static CaptureScreen screen = null;
        private static List<Control> captureControls = new List<Control>();
        private static Control UI = new Control();
        private static Size captureScreenSize = new Size();
        private static Point captureScreenLocation = new Point();
        public static SingleCapture Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SingleCapture();
                }
                return instance;
            }
        }
        public CaptureScreen CaptureScreen
        {
            get
            {
                return screen;
            }
        }
        public List<Control> CaptureControls
        {
            get
            {
                return captureControls;
            }
            set
            {
                captureControls = value;
            }
        }
        public Control UIG
        {
            get
            {
                return UI;
            }
            set
            {
                UI = value;
            }
        }
        public Size CaptureScreenSize
        {
            get
            {
                return captureScreenSize;
            }
            set
            {
                captureScreenSize = value;
            }
        }
        public Point CaptureScreenLocation
        {
            get
            {
                return captureScreenLocation;
            }
            set
            {
                captureScreenLocation = value;
            }
        }
    }
}
