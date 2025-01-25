using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kinovea.ScreenManager
{
    public class SinglePlayer
    {
        private SinglePlayer() { screen = new PlayerScreen(); }
        private static SinglePlayer instance = null;
        private static PlayerScreen screen = null;
        private static List<Control> playerControls = new List<Control>();
        private static Control UI = new Control();
        public static SinglePlayer Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SinglePlayer();
                }
                return instance;
            }
        }
        public PlayerScreen PlayerScreen
        {
            get
            {
                return screen;
            }
        }
        public 
            List<Control> PlayerControls
        {
            get
            {
                return playerControls;
            }
            set
            {
                playerControls = value;
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
                UI= value;
            }
        }
    }
}
