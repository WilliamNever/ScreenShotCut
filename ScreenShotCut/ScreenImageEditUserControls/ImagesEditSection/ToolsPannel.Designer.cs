namespace ScreenImageEditUserControls.ImagesEditSection
{
    partial class ToolsPannel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabTools = new System.Windows.Forms.TabControl();
            this.tpSelect = new System.Windows.Forms.TabPage();
            this.tpText = new System.Windows.Forms.TabPage();
            this.tpRectangle = new System.Windows.Forms.TabPage();
            this.tpScale = new System.Windows.Forms.TabPage();
            this.lblClose = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.tabTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabTools
            // 
            this.tabTools.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabTools.Controls.Add(this.tpSelect);
            this.tabTools.Controls.Add(this.tpText);
            this.tabTools.Controls.Add(this.tpRectangle);
            this.tabTools.Controls.Add(this.tpScale);
            this.tabTools.Location = new System.Drawing.Point(0, 20);
            this.tabTools.Name = "tabTools";
            this.tabTools.SelectedIndex = 0;
            this.tabTools.Size = new System.Drawing.Size(257, 508);
            this.tabTools.TabIndex = 0;
            // 
            // tpSelect
            // 
            this.tpSelect.AutoScroll = true;
            this.tpSelect.Location = new System.Drawing.Point(4, 22);
            this.tpSelect.Name = "tpSelect";
            this.tpSelect.Padding = new System.Windows.Forms.Padding(3);
            this.tpSelect.Size = new System.Drawing.Size(249, 482);
            this.tpSelect.TabIndex = 0;
            this.tpSelect.Text = "Select";
            this.tpSelect.UseVisualStyleBackColor = true;
            // 
            // tpText
            // 
            this.tpText.AutoScroll = true;
            this.tpText.Location = new System.Drawing.Point(4, 22);
            this.tpText.Name = "tpText";
            this.tpText.Padding = new System.Windows.Forms.Padding(3);
            this.tpText.Size = new System.Drawing.Size(249, 482);
            this.tpText.TabIndex = 1;
            this.tpText.Text = "Text";
            this.tpText.UseVisualStyleBackColor = true;
            // 
            // tpRectangle
            // 
            this.tpRectangle.AutoScroll = true;
            this.tpRectangle.Location = new System.Drawing.Point(4, 22);
            this.tpRectangle.Name = "tpRectangle";
            this.tpRectangle.Padding = new System.Windows.Forms.Padding(3);
            this.tpRectangle.Size = new System.Drawing.Size(249, 170);
            this.tpRectangle.TabIndex = 2;
            this.tpRectangle.Text = "Rectangle";
            this.tpRectangle.UseVisualStyleBackColor = true;
            // 
            // tpScale
            // 
            this.tpScale.AutoScroll = true;
            this.tpScale.Location = new System.Drawing.Point(4, 22);
            this.tpScale.Name = "tpScale";
            this.tpScale.Padding = new System.Windows.Forms.Padding(3);
            this.tpScale.Size = new System.Drawing.Size(249, 170);
            this.tpScale.TabIndex = 3;
            this.tpScale.Text = "Scale";
            this.tpScale.UseVisualStyleBackColor = true;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Location = new System.Drawing.Point(239, 4);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(14, 13);
            this.lblClose.TabIndex = 1;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.Blue;
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(257, 22);
            this.pnlTitle.TabIndex = 2;
            this.pnlTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseDown);
            this.pnlTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseMove);
            this.pnlTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseUp);
            // 
            // ToolsPannel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.tabTools);
            this.Controls.Add(this.pnlTitle);
            this.Name = "ToolsPannel";
            this.Size = new System.Drawing.Size(257, 528);
            this.tabTools.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabTools;
        private System.Windows.Forms.TabPage tpSelect;
        private System.Windows.Forms.TabPage tpText;
        private System.Windows.Forms.TabPage tpRectangle;
        private System.Windows.Forms.TabPage tpScale;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Panel pnlTitle;
    }
}
