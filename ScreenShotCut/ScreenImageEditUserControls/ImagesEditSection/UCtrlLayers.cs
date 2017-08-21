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
using ScreenShotCutLib.DelegatesList;

namespace ScreenImageEditUserControls.ImagesEditSection
{
    public partial class UCtrlLayers : UserControl
    {
        public RunCommandHandler<UsCtrlExInfors> RunCommand {
            get
            {
                return UsCtrlBackGroundImage.RunCommand;
            }
            set
            {
                UsCtrlBackGroundImage.RunCommand = value;
            }
        }

        public UCtrlLayers()
        {
            InitializeComponent();
        }

        public void SetScale(float vScale)
        {
            UsCtrlBackGroundImage.SetScale(vScale);
        }

        public void AddBottomImage(Image img)
        {
            UsCtrlBackGroundImage.AddBottomImage(img);
        }

        public void AddTopImage(Image Img)
        {
            UsCtrlBackGroundImage.AddTopImage(Img);
        }

        public void ToAddMessagesLabel(UsCtrlExInfors lmp, CallBackFunc callBack)
        {
            UsCtrlBackGroundImage.ToAddMessagesLabel(lmp, callBack);
        }

        public void BackLayersVisible(bool visible)
        {
            UsCtrlBackGroundImage.Visible = visible;
        }

        public Bitmap GetCurrentBackLayerImage()
        {
            return UsCtrlBackGroundImage.GetCurrentControlBitmat();
        }

        private void UCtrlLayers_Load(object sender, EventArgs e)
        {
            uCtrlFCover.Visible = false;
        }
    }
}
