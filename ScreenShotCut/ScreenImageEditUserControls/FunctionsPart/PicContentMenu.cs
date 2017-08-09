using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenImageEditUserControls.FunctionsPart
{
    public class PicContentMenu: ContextMenuStrip
    {
        private System.Windows.Forms.ToolStripMenuItem tsmiSelect;
        private System.Windows.Forms.ToolStripMenuItem tsmiToTop;
        private System.Windows.Forms.ToolStripMenuItem tsmiToBottom;
        private System.Windows.Forms.ToolStripMenuItem tsmiUp;
        private System.Windows.Forms.ToolStripMenuItem tsmiDown;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;

        public PicContentMenu():base()
        {
            AddMenuItems();
        }

        public PicContentMenu(IContainer container):base(container)
        {
            AddMenuItems();
        }

        protected virtual void AddMenuItems()
        {
            this.tsmiSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiToTop = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiToBottom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDown = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.SuspendLayout();

            this.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSelect,
            this.tsmiToTop,
            this.tsmiToBottom,
            this.tsmiUp,
            this.tsmiDown,
            this.tsmiDelete});
            //this.Size = new System.Drawing.Size(130, 132);

            // 
            // tsmiSelect
            // 
            this.tsmiSelect.Name = "tsmiSelect";
            //this.tsmiSelect.Size = new System.Drawing.Size(130, 22);
            this.tsmiSelect.Text = "Select";
            // 
            // tsmiToTop
            // 
            this.tsmiToTop.Name = "tsmiToTop";
            //this.tsmiToTop.Size = new System.Drawing.Size(130, 22);
            this.tsmiToTop.Text = "To Top";
            // 
            // tsmiToBottom
            // 
            this.tsmiToBottom.Name = "tsmiToBottom";
            //this.tsmiToBottom.Size = new System.Drawing.Size(130, 22);
            this.tsmiToBottom.Text = "To Bottom";
            // 
            // tsmiUp
            // 
            this.tsmiUp.Name = "tsmiUp";
            //this.tsmiUp.Size = new System.Drawing.Size(130, 22);
            this.tsmiUp.Text = "Up";
            // 
            // tsmiDown
            // 
            this.tsmiDown.Name = "tsmiDown";
            //this.tsmiDown.Size = new System.Drawing.Size(130, 22);
            this.tsmiDown.Text = "Down";
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            //this.tsmiDelete.Size = new System.Drawing.Size(130, 22);
            this.tsmiDelete.Text = "Delete";

            this.ResumeLayout(false);
        }
    }
}
