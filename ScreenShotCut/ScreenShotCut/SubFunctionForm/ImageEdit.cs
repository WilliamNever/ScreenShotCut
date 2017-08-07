#define debug

using ScreenImageEditUserControls.ImagesEditSection;
using ScreenShotCut.BaseForms;
using ScreenShotCutLib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenShotCut.SubFunctionForm
{
    public partial class frmImageEdit : Form
    {
        private Image img;
        private BaseForm mainForm;
        private float scale;

        private ToolsPannel tpnl;

        private MoveControlInfor MvCtrlInfor { get; set; }

        private frmImageEdit()
        {
            scale = 1;
            InitializeComponent();
            InitCtrols();
        }

        private void InitCtrols()
        {
#if debug
            //UsCtrlBackGroundImage.SetScale(.5F);
            img = Properties.Resources.aat2017731_00001;
            UsCtrlBackGroundImage.AddBottomImage(img);
            UsCtrlBackGroundImage.AddTopImage(Properties.Resources.small2017731_00001);
            //UsCtrlBackGroundImage.SetScale(1F);
#endif

            InitToolsPannel();
        }

        public frmImageEdit(BaseForm mainForm, Image img)
            :this()
        {
            this.mainForm = mainForm;
            this.img = img;
        }

        private void frmImageEdit_Load(object sender, EventArgs e)
        {
#if debug

#else

#endif
        }

        private void InitToolsPannel()
        {
            tpnl = new ToolsPannel();
            tpnl.Visible = false;
            tpnl.Enabled = false;
            tpnl.MouseDown += new MouseEventHandler(Tpnl_MouseDown);
            tpnl.MouseMove += new MouseEventHandler(Tpnl_MouseMove);
            tpnl.MouseUp += new MouseEventHandler(Tpnl_MouseUp);

            tpnl.Location = new Point(0, this.mnMainTop.Height);

            this.Controls.Add(tpnl);
            this.Controls.SetChildIndex(tpnl, 0);
        }

        private void mnFile_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //MessageBox.Show("File\\"+e.ClickedItem.Name);
            switch (e.ClickedItem.Name)
            {
                case "mniOpen":
                    break;
                case "mniSave":
                    break;
                case "mniSaveAs":
                    break;
                default:
                    break;
            }
        }

        private void mnTools_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //MessageBox.Show("Tool\\" + e.ClickedItem.Name);
            switch (e.ClickedItem.Name)
            {
                case "mniSelect":
                case "mniText":
                case "mniRectangle":
                case "mniScale":
                    tpnl.Visible = true;
                    tpnl.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void Tpnl_MouseUp(object sender, MouseEventArgs e)
        {
            MvCtrlInfor = null;
        }

        private void Tpnl_MouseMove(object sender, MouseEventArgs e)
        {
            if (MvCtrlInfor != null)
            {
                var ctrl = sender as Control;
                ctrl.Location = new Point(ctrl.Location.X + e.X - MvCtrlInfor.Location.X
                    , ctrl.Location.Y + e.Y - MvCtrlInfor.Location.Y);

            }
        }

        private void Tpnl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MvCtrlInfor = new MoveControlInfor { Location = e.Location };
            }
        }

        private void mnEdit_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "mniCopy":
                    break;
                case "mniPaste":
                    break;
                default:
                    break;
            }
        }
    }
}
