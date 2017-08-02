namespace ScreenShotCut.SubFunctionForm
{
    partial class frmImageEdit
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
            this.UsCtrlBackGroundImage = new ScreenImageEditUserControls.ImagesEditSection.UCtrlBackGround();
            this.mnMainTop = new System.Windows.Forms.MenuStrip();
            this.mnFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.mniText = new System.Windows.Forms.ToolStripMenuItem();
            this.mniRectangle = new System.Windows.Forms.ToolStripMenuItem();
            this.mnEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mniPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.mniLine1 = new System.Windows.Forms.ToolStripSeparator();
            this.mniScale = new System.Windows.Forms.ToolStripMenuItem();
            this.mnMainTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // UsCtrlBackGroundImage
            // 
            this.UsCtrlBackGroundImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsCtrlBackGroundImage.Location = new System.Drawing.Point(0, 24);
            this.UsCtrlBackGroundImage.Name = "UsCtrlBackGroundImage";
            this.UsCtrlBackGroundImage.Size = new System.Drawing.Size(599, 387);
            this.UsCtrlBackGroundImage.TabIndex = 0;
            // 
            // mnMainTop
            // 
            this.mnMainTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnFile,
            this.mnEdit,
            this.mnTools});
            this.mnMainTop.Location = new System.Drawing.Point(0, 0);
            this.mnMainTop.Name = "mnMainTop";
            this.mnMainTop.Size = new System.Drawing.Size(599, 24);
            this.mnMainTop.TabIndex = 1;
            this.mnMainTop.Text = "MainMenu";
            // 
            // mnFile
            // 
            this.mnFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniOpen,
            this.mniSave,
            this.mniSaveAs});
            this.mnFile.Name = "mnFile";
            this.mnFile.Size = new System.Drawing.Size(37, 20);
            this.mnFile.Text = "File";
            this.mnFile.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnFile_DropDownItemClicked);
            // 
            // mniOpen
            // 
            this.mniOpen.Name = "mniOpen";
            this.mniOpen.Size = new System.Drawing.Size(152, 22);
            this.mniOpen.Text = "Open";
            // 
            // mniSave
            // 
            this.mniSave.Name = "mniSave";
            this.mniSave.Size = new System.Drawing.Size(152, 22);
            this.mniSave.Text = "Save";
            // 
            // mniSaveAs
            // 
            this.mniSaveAs.Name = "mniSaveAs";
            this.mniSaveAs.Size = new System.Drawing.Size(152, 22);
            this.mniSaveAs.Text = "Save As";
            // 
            // mnTools
            // 
            this.mnTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniSelect,
            this.mniText,
            this.mniRectangle,
            this.mniLine1,
            this.mniScale});
            this.mnTools.Name = "mnTools";
            this.mnTools.Size = new System.Drawing.Size(47, 20);
            this.mnTools.Text = "Tools";
            this.mnTools.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnTools_DropDownItemClicked);
            // 
            // mniSelect
            // 
            this.mniSelect.Name = "mniSelect";
            this.mniSelect.Size = new System.Drawing.Size(152, 22);
            this.mniSelect.Text = "Select";
            // 
            // mniText
            // 
            this.mniText.Name = "mniText";
            this.mniText.Size = new System.Drawing.Size(152, 22);
            this.mniText.Text = "Text";
            // 
            // mniRectangle
            // 
            this.mniRectangle.Name = "mniRectangle";
            this.mniRectangle.Size = new System.Drawing.Size(152, 22);
            this.mniRectangle.Text = "Rectangle";
            // 
            // mnEdit
            // 
            this.mnEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniCopy,
            this.mniPaste});
            this.mnEdit.Name = "mnEdit";
            this.mnEdit.Size = new System.Drawing.Size(39, 20);
            this.mnEdit.Text = "Edit";
            this.mnEdit.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnEdit_DropDownItemClicked);
            // 
            // mniCopy
            // 
            this.mniCopy.Name = "mniCopy";
            this.mniCopy.Size = new System.Drawing.Size(152, 22);
            this.mniCopy.Text = "Copy";
            // 
            // mniPaste
            // 
            this.mniPaste.Name = "mniPaste";
            this.mniPaste.Size = new System.Drawing.Size(152, 22);
            this.mniPaste.Text = "Paste";
            // 
            // mniLine1
            // 
            this.mniLine1.Name = "mniLine1";
            this.mniLine1.Size = new System.Drawing.Size(149, 6);
            // 
            // mniScale
            // 
            this.mniScale.Name = "mniScale";
            this.mniScale.Size = new System.Drawing.Size(152, 22);
            this.mniScale.Text = "Scale";
            // 
            // frmImageEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 411);
            this.Controls.Add(this.UsCtrlBackGroundImage);
            this.Controls.Add(this.mnMainTop);
            this.MainMenuStrip = this.mnMainTop;
            this.Name = "frmImageEdit";
            this.Text = "Image Edit";
            this.Load += new System.EventHandler(this.frmImageEdit_Load);
            this.mnMainTop.ResumeLayout(false);
            this.mnMainTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ScreenImageEditUserControls.ImagesEditSection.UCtrlBackGround UsCtrlBackGroundImage;
        private System.Windows.Forms.MenuStrip mnMainTop;
        private System.Windows.Forms.ToolStripMenuItem mnFile;
        private System.Windows.Forms.ToolStripMenuItem mniOpen;
        private System.Windows.Forms.ToolStripMenuItem mniSave;
        private System.Windows.Forms.ToolStripMenuItem mniSaveAs;
        private System.Windows.Forms.ToolStripMenuItem mnTools;
        private System.Windows.Forms.ToolStripMenuItem mniSelect;
        private System.Windows.Forms.ToolStripMenuItem mniText;
        private System.Windows.Forms.ToolStripMenuItem mniRectangle;
        private System.Windows.Forms.ToolStripMenuItem mnEdit;
        private System.Windows.Forms.ToolStripMenuItem mniCopy;
        private System.Windows.Forms.ToolStripMenuItem mniPaste;
        private System.Windows.Forms.ToolStripSeparator mniLine1;
        private System.Windows.Forms.ToolStripMenuItem mniScale;
    }
}