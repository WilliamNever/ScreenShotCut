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
    public partial class UCtrlFrontCover : UserControl
    {
        public UCtrlFrontCover()
        {
            InitializeComponent();
        }

        public void SetBackGroundImage(Bitmap cuImage)
        {
            this.Visible = true;
            this.BackgroundImage = cuImage;
            this.BackgroundImageLayout = ImageLayout.Zoom;
        }
    }
}
