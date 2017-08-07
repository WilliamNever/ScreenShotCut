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
using ScreenImageEditUserControls.FunctionsPart;
using ScreenShotCutLib.Models;

namespace ScreenImageEditUserControls.ImagesEditSection
{
    public partial class UCtrlBackGround : UserControl
    {
        private float picsScale;
        /// <summary>
        /// All of the layer scale num
        /// </summary>
        public float PicsScale { get { return picsScale; } }
        private MoveControlInfor MvCtrlInfor { get; set; }
        public UCtrlBackGround()
        {
            InitializeComponent();
            picsScale = 1F;
            MvCtrlInfor = null;
        }

        private void UCtrlBackGround_Load(object sender, EventArgs e)
        {
        }

        public void AddBottomImage(Image img)
        {
            var guid = Guid.NewGuid();
            var picBottom = new PictureBoxEx();
            picBottom.Name = guid.ToString();
            picBottom.SizeMode = PictureBoxSizeMode.Zoom;
            picBottom.Location = new Point(0, 0);
            picBottom.Width = Convert.ToInt32(img.Width * PicsScale);
            picBottom.Height = Convert.ToInt32(img.Height * PicsScale);
            picBottom.Image = img;
            picBottom.Tag = new UsCtrlExInfors { ControlName = picBottom.Name, ControlText = "" };
            picBottom.ContextMenuStrip = mnChildSelectionAction;

            picBottom.MouseDown += new MouseEventHandler(Conotrl_MouseDown);
            picBottom.MouseMove += new MouseEventHandler(Conotrl_MouseMove);
            picBottom.MouseUp += new MouseEventHandler(Conotrl_MouseUp);

            this.Controls.Add(picBottom);
        }
        public void AddTopImage(Image img)
        {
            var guid = Guid.NewGuid();
            var pidTop = new PictureBoxEx();
            pidTop.Name = guid.ToString();
            pidTop.SizeMode = PictureBoxSizeMode.Zoom;
            pidTop.Location = new Point(0, 0);
            pidTop.Width = Convert.ToInt32(img.Width * PicsScale);
            pidTop.Height = Convert.ToInt32(img.Height * PicsScale);
            pidTop.Image = img;
            pidTop.Tag = new UsCtrlExInfors { ControlName = pidTop.Name, ControlText = "" };
            pidTop.ContextMenuStrip = mnChildSelectionAction;

            pidTop.MouseDown += new MouseEventHandler(Conotrl_MouseDown);
            pidTop.MouseMove += new MouseEventHandler(Conotrl_MouseMove);
            pidTop.MouseUp += new MouseEventHandler(Conotrl_MouseUp);
            
            this.Controls.Add(pidTop);
            this.Controls.SetChildIndex(pidTop, 0);
        }

        private void Conotrl_MouseUp(object sender, MouseEventArgs e)
        {
            MvCtrlInfor = null;
        }

        private void Conotrl_MouseMove(object sender, MouseEventArgs e)
        {
            if (MvCtrlInfor != null)
            {
                var ctrl = sender as Control;
                ctrl.Location = new Point(ctrl.Location.X + e.X - MvCtrlInfor.Location.X
                    , ctrl.Location.Y + e.Y - MvCtrlInfor.Location.Y);
            }
        }

        private void Conotrl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MvCtrlInfor = new MoveControlInfor { Location = e.Location };
            }
        }

        public void SetScale(float scale)
        {
            picsScale = scale;
            foreach (Control itm in this.Controls)
            {
                var picb = itm as PictureBoxEx;
                if (picb!=null && picb.Image != null)
                {
                    picb.Width = Convert.ToInt32(picb.Image.Width * PicsScale);
                    picb.Height = Convert.ToInt32(picb.Image.Height * PicsScale);
                }
            }
        }

        private void mnChildSelectionAction_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //MessageBox.Show(string.Format("{0}\n{1}",e.ClickedItem.Name
            //    ,((ContextMenuStrip)e.ClickedItem.Owner).SourceControl.Name
            //    ));
            var ctrl = ((ContextMenuStrip)sender).SourceControl as IControlExProperties;
            if (ctrl != null)
            {
                var ctr = ctrl.GetControlName();
                var slCtrl = this.Controls[ctr];
                int index;
                switch (e.ClickedItem.Name)
                {
                    case "tsmiSelect":
                        ctrl.IsSelectedControl = !ctrl.IsSelectedControl;
                        ctrl.RefreshSelf();
                        break;
                    case "tsmiToTop":
                        this.Controls.SetChildIndex(slCtrl, 0);
                        break;
                    case "tsmiToBottom":
                        this.Controls.SetChildIndex(slCtrl, this.Controls.Count - 1);
                        break;
                    case "tsmiUp":
                        index = this.Controls.IndexOfKey(ctr);
                        index--;
                        this.Controls.SetChildIndex(slCtrl, index < 0 ? 0 : index);
                        break;
                    case "tsmiDown":
                        index = this.Controls.IndexOfKey(ctr);
                        index++;
                        this.Controls.SetChildIndex(slCtrl, index >= this.Controls.Count ? this.Controls.Count - 1 : index);
                        break;
                    case "tsmiDelete":
                        this.Controls.RemoveByKey(ctr);
                        slCtrl.Dispose();
                        break;
                    default:
                        break;
                }
            }
        }

        private void mnChildSelectionAction_Opening(object sender, CancelEventArgs e)
        {
            var menu = (ContextMenuStrip)sender;
            var ctrl = menu.SourceControl as PictureBoxEx;
            menu.Items["tsmiSelect"].Text = ctrl.IsSelectedControl ? "UnSelect" : "Select";
        }
    }
}
