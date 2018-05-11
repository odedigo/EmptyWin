using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmptyWin
{
    public partial class Settings : Form
    {
        #region Constructor
        public Settings()
        {
            InitializeComponent();
            CheckWinOnTop.Checked = Config.Instance.OnTop;
        }
        #endregion

        #region Paint
        private void PanelBgColor_Paint(object sender, PaintEventArgs e)
        {
            Size size = ((Panel)sender).Size;
            e.Graphics.FillRectangle(new SolidBrush(Config.Instance.BgColor),
                                     1, 1, size.Width-2, size.Height-2);
            e.Graphics.DrawRectangle(new Pen(Color.Black), new Rectangle(1, 1, size.Width - 2, size.Height - 2));
        }
        #endregion

        #region Handle events
        private void PickColor(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = Config.Instance.BgColor;
            DialogResult result = cd.ShowDialog();
            if (result == DialogResult.OK)
            {
                Config.Instance.BgColor = cd.Color;
                ((Panel)sender).Invalidate();
                Program.mainForm.RefreshForm();
            }
        }

        private void CheckWinOnTop_CheckedChanged(object sender, EventArgs e)
        {
            Config.Instance.OnTop = CheckWinOnTop.Checked;
            Program.mainForm.SetOnTop(Config.Instance.OnTop);
        }

        private void ButSaveSettings_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
