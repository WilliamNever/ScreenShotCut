using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScreenShotCutLib.ControlExtendInfors;

namespace ScreenImageEditUserControls.ImagesEditSection
{
    public partial class UCtrlBackGround : UserControl
    {
        private float picsScale;
        public float PicsScale { get { return picsScale; } }
        public UCtrlBackGround()
        {
            InitializeComponent();
            picsScale = 1F;
        }

        private void UCtrlBackGround_Load(object sender, EventArgs e)
        {
            
        }

        public void AddBottomImage(Image img)
        {
            var guid = Guid.NewGuid();
            var picBottom = new System.Windows.Forms.PictureBox();
            picBottom.Name = guid.ToString();
            picBottom.SizeMode = PictureBoxSizeMode.Zoom;
            picBottom.Location = new Point(0, 0);
            picBottom.Width = Convert.ToInt32(img.Width * PicsScale);
            picBottom.Height = Convert.ToInt32(img.Height * PicsScale);
            picBottom.Image = img;
            picBottom.Tag = new UsCtrlExInfors { ControlName = picBottom.Name, ControlText = "" };
            picBottom.ContextMenuStrip = mnChildSelectionAction;
            this.Controls.Add(picBottom);
        }
        public void AddTopImage(Image img)
        {
            var guid = Guid.NewGuid();
            var pidTop = new System.Windows.Forms.PictureBox();
            pidTop.Name = guid.ToString();
            pidTop.SizeMode = PictureBoxSizeMode.Zoom;
            pidTop.Location = new Point(0, 0);
            pidTop.Width = Convert.ToInt32(img.Width * PicsScale);
            pidTop.Height = Convert.ToInt32(img.Height * PicsScale);
            pidTop.Image = img;
            pidTop.Tag = new UsCtrlExInfors { ControlName = pidTop.Name, ControlText = "" };
            pidTop.ContextMenuStrip = mnChildSelectionAction;
            this.Controls.Add(pidTop);
            this.Controls.SetChildIndex(pidTop, 0);
        }
        public void SetScale(float scale)
        {
            picsScale = scale;
            foreach (Control itm in this.Controls)
            {
                var picb = itm as PictureBox;
                if (picb!=null && picb.Image != null)
                {
                    picb.Width = Convert.ToInt32(picb.Image.Width * PicsScale);
                    picb.Height = Convert.ToInt32(picb.Image.Height * PicsScale);
                }
            }
        }
    }
}
