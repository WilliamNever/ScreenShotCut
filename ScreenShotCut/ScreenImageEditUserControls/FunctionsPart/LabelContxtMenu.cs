using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenImageEditUserControls.FunctionsPart
{
    public class LabelContxtMenu: PicContentMenu
    {
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiConvertToPicture;

        public LabelContxtMenu():base()
        {
        }

        public LabelContxtMenu(IContainer container):base(container)
        {
        }

        protected override void AddMenuItems()
        {
            base.AddMenuItems();
            tsmiEdit = new ToolStripMenuItem();
            tsmiConvertToPicture = new ToolStripMenuItem();

            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Text = "Edit";

            this.tsmiConvertToPicture.Name = "tsmiConvertToPicture";
            this.tsmiConvertToPicture.Text = "To Picture";

            this.Items.Insert(1, tsmiConvertToPicture);
            this.Items.Insert(1, tsmiEdit);
        }
    }
}
