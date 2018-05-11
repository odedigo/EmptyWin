namespace EmptyWin
{
    partial class Settings
    {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.PanelBgColor = new System.Windows.Forms.Panel();
            this.CheckWinOnTop = new System.Windows.Forms.CheckBox();
            this.ButSaveSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Background Color:";
            // 
            // PanelBgColor
            // 
            this.PanelBgColor.Location = new System.Drawing.Point(113, 12);
            this.PanelBgColor.Name = "PanelBgColor";
            this.PanelBgColor.Size = new System.Drawing.Size(35, 13);
            this.PanelBgColor.TabIndex = 1;
            this.PanelBgColor.Click += new System.EventHandler(this.PickColor);
            this.PanelBgColor.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelBgColor_Paint);
            // 
            // CheckWinOnTop
            // 
            this.CheckWinOnTop.AutoSize = true;
            this.CheckWinOnTop.Location = new System.Drawing.Point(15, 38);
            this.CheckWinOnTop.Name = "CheckWinOnTop";
            this.CheckWinOnTop.Size = new System.Drawing.Size(98, 17);
            this.CheckWinOnTop.TabIndex = 2;
            this.CheckWinOnTop.Text = "Window on top";
            this.CheckWinOnTop.UseVisualStyleBackColor = true;
            this.CheckWinOnTop.CheckedChanged += new System.EventHandler(this.CheckWinOnTop_CheckedChanged);
            // 
            // ButSaveSettings
            // 
            this.ButSaveSettings.Location = new System.Drawing.Point(63, 61);
            this.ButSaveSettings.Name = "ButSaveSettings";
            this.ButSaveSettings.Size = new System.Drawing.Size(75, 23);
            this.ButSaveSettings.TabIndex = 3;
            this.ButSaveSettings.Text = "&Save";
            this.ButSaveSettings.UseVisualStyleBackColor = true;
            this.ButSaveSettings.Click += new System.EventHandler(this.ButSaveSettings_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 86);
            this.Controls.Add(this.ButSaveSettings);
            this.Controls.Add(this.CheckWinOnTop);
            this.Controls.Add(this.PanelBgColor);
            this.Controls.Add(this.label1);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelBgColor;
        private System.Windows.Forms.CheckBox CheckWinOnTop;
        private System.Windows.Forms.Button ButSaveSettings;
    }
}