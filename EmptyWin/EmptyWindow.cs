using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmptyWin
{
    public partial class EmptyWindow : Form
    {
        #region Consctuction and init
        public EmptyWindow()
        {
            InitializeComponent();
            InitSettings();
        }

        private void InitSettings()
        {
            this.BackColor = Config.Instance.BgColor;
        }
        #endregion

        #region Handle events
        public void EmptyWindow_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
            else if (e.Button == MouseButtons.Right)
            {
                ReleaseCapture();
                contextMenuRightClick.Show(this, new Point(e.X, e.Y));//places the menu at the pointer position
            }
        }

        private void SettingsSelected(object sender, EventArgs e)
        {
            Settings s = new Settings();
            s.StartPosition = FormStartPosition.CenterScreen;
            s.Show();            
        }

        private void CloseSelected(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
