﻿namespace ScreenShotCut.BaseForms
{
    partial class FrmShotSnap
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
            this.mskUctrol1 = new ScreenShotCut.UserCtrols.MskUctrol();
            this.SuspendLayout();
            // 
            // mskUctrol1
            // 
            this.mskUctrol1.BackColor = System.Drawing.Color.Transparent;
            this.mskUctrol1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mskUctrol1.Location = new System.Drawing.Point(0, 0);
            this.mskUctrol1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.mskUctrol1.Name = "mskUctrol1";
            this.mskUctrol1.Size = new System.Drawing.Size(616, 443);
            this.mskUctrol1.TabIndex = 0;
            // 
            // FrmShotSnap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(616, 443);
            this.Controls.Add(this.mskUctrol1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmShotSnap";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FrmShotSnap";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmShotSnap_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmShotSnap_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private UserCtrols.MskUctrol mskUctrol1;
    }
}