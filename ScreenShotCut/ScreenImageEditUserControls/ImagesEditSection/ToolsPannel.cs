using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenImageEditUserControls.ImagesEditSection
{
    public partial class ToolsPannel : UserControl
    {
        public ToolsPannel()
        {
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            this.Visible = false;
        }

        private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            OnMouseDown(e);
        }

        private void pnlTitle_MouseMove(object sender, MouseEventArgs e)
        {
            OnMouseMove(e);
        }

        private void pnlTitle_MouseUp(object sender, MouseEventArgs e)
        {
            OnMouseUp(e);
        }
    }
}
