using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EmptyWin
{
    partial class EmptyWindow
    {
        #region Form Stuff
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #endregion
        
        #region Window Functions

        public void RefreshForm()
        {
            this.BackColor = Config.Instance.BgColor;
        }

        public void SetOnTop(bool onTop)
        {
            this.TopMost = onTop;
        }

        #endregion

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuRightClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuRightClick
            // 
            this.contextMenuRightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.contextMenuRightClick.Name = "contextMenuRightClick";
            this.contextMenuRightClick.Size = new System.Drawing.Size(153, 70);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.settingsToolStripMenuItem.Text = "&Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsSelected);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseSelected);
            // 
            // EmptyWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 100);
            this.ControlBox = false;            
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.TopMost = true;
            this.Name = "EmptyWindow";

            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EmptyWindow_MouseDown);
            this.contextMenuRightClick.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion
        
        #region Win32
        /// <summary>
        /// No caption, Mouse handling
        /// </summary>
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        #endregion

        #region Form Objects
        private ContextMenuStrip contextMenuRightClick;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        #endregion
    }
}

