namespace ScreenImageEditUserControls.ImagesEditSection
{
    partial class UCtrlBackGround
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
            this.components = new System.ComponentModel.Container();
            this.mnChildSelectionAction = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiToTop = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiToBottom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDown = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnChildSelectionAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnChildSelectionAction
            // 
            this.mnChildSelectionAction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSelect,
            this.tsmiToTop,
            this.tsmiToBottom,
            this.tsmiUp,
            this.tsmiDown,
            this.tsmiDelete});
            this.mnChildSelectionAction.Name = "mnChildSelectionAction";
            this.mnChildSelectionAction.Size = new System.Drawing.Size(131, 136);
            this.mnChildSelectionAction.Opening += new System.ComponentModel.CancelEventHandler(this.mnChildSelectionAction_Opening);
            this.mnChildSelectionAction.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnChildSelectionAction_ItemClicked);
            // 
            // tsmiSelect
            // 
            this.tsmiSelect.Name = "tsmiSelect";
            this.tsmiSelect.Size = new System.Drawing.Size(130, 22);
            this.tsmiSelect.Text = "Select";
            // 
            // tsmiToTop
            // 
            this.tsmiToTop.Name = "tsmiToTop";
            this.tsmiToTop.Size = new System.Drawing.Size(130, 22);
            this.tsmiToTop.Text = "To Top";
            // 
            // tsmiToBottom
            // 
            this.tsmiToBottom.Name = "tsmiToBottom";
            this.tsmiToBottom.Size = new System.Drawing.Size(130, 22);
            this.tsmiToBottom.Text = "To Bottom";
            // 
            // tsmiUp
            // 
            this.tsmiUp.Name = "tsmiUp";
            this.tsmiUp.Size = new System.Drawing.Size(130, 22);
            this.tsmiUp.Text = "Up";
            // 
            // tsmiDown
            // 
            this.tsmiDown.Name = "tsmiDown";
            this.tsmiDown.Size = new System.Drawing.Size(130, 22);
            this.tsmiDown.Text = "Down";
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(130, 22);
            this.tsmiDelete.Text = "Delete";
            // 
            // UCtrlBackGround
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Name = "UCtrlBackGround";
            this.Size = new System.Drawing.Size(446, 334);
            this.Load += new System.EventHandler(this.UCtrlBackGround_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UCtrlBackGround_MouseDown);
            this.mnChildSelectionAction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip mnChildSelectionAction;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelect;
        private System.Windows.Forms.ToolStripMenuItem tsmiToTop;
        private System.Windows.Forms.ToolStripMenuItem tsmiToBottom;
        private System.Windows.Forms.ToolStripMenuItem tsmiUp;
        private System.Windows.Forms.ToolStripMenuItem tsmiDown;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
    }
}
