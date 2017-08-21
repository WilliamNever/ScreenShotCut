namespace ScreenImageEditUserControls.ImagesEditSection
{
    partial class UCtrlLayers
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
            this.UsCtrlBackGroundImage = new ScreenImageEditUserControls.ImagesEditSection.UCtrlBackGround();
            this.uCtrlFCover = new ScreenImageEditUserControls.ImagesEditSection.UCtrlFrontCover();
            this.SuspendLayout();
            // 
            // UsCtrlBackGroundImage
            // 
            this.UsCtrlBackGroundImage.AutoScroll = true;
            this.UsCtrlBackGroundImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsCtrlBackGroundImage.Location = new System.Drawing.Point(0, 0);
            this.UsCtrlBackGroundImage.Name = "UsCtrlBackGroundImage";
            this.UsCtrlBackGroundImage.Size = new System.Drawing.Size(442, 411);
            this.UsCtrlBackGroundImage.TabIndex = 0;
            // 
            // uCtrlFCover
            // 
            this.uCtrlFCover.AutoScroll = true;
            this.uCtrlFCover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uCtrlFCover.Location = new System.Drawing.Point(0, 0);
            this.uCtrlFCover.Name = "uCtrlFCover";
            this.uCtrlFCover.Size = new System.Drawing.Size(442, 411);
            this.uCtrlFCover.TabIndex = 1;
            // 
            // UCtrlLayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uCtrlFCover);
            this.Controls.Add(this.UsCtrlBackGroundImage);
            this.Name = "UCtrlLayers";
            this.Size = new System.Drawing.Size(442, 411);
            this.Load += new System.EventHandler(this.UCtrlLayers_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UCtrlBackGround UsCtrlBackGroundImage;
        private UCtrlFrontCover uCtrlFCover;
    }
}
