#define debug

using ScreenImageEditUserControls.AssistantControls;
using ScreenImageEditUserControls.ImagesEditSection;
using ScreenShotCut.BaseForms;
using ScreenShotCutLib.ControlExtendInfors;
using ScreenShotCutLib.DelegatesList;
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
using static ScreenImageEditUserControls.ImagesEditSection.ToolsPannel;

namespace ScreenShotCut.SubFunctionForm
{
    public partial class frmImageEdit : Form
    {
        private Image img;
        private BaseForm mainForm;

        private ToolsPannel tpnl;

        private MoveControlInfor MvCtrlInfor { get; set; }

        private frmImageEdit()
        {
            InitializeComponent();
            InitCtrols();
        }

        private void InitCtrols()
        {
#if debug
            //UsCtrlLayers.SetScale(.5F);
            img = Properties.Resources.aat2017731_00001;
            UsCtrlLayers.AddBottomImage(img);
            UsCtrlLayers.AddTopImage(Properties.Resources.small2017731_00001);
            //UsCtrlLayers.SetScale(1F);
#endif
            UsCtrlLayers.RunCommand += new RunCommandHandler<UsCtrlExInfors>(RunPaintCommand);
            InitToolsPannel();
        }

        private void RunPaintCommand(string command, UsCtrlExInfors obj)
        {
            switch (command)
            {
                case "EditLabelEx":
                    if (obj.LayerType == ScreenShotCutLib.Enums.EnLayerType.Label)
                    {
                        EditLabelMessage(obj as UsLabelExInfors);
                    }
                    break;
                default:
                    break;
            }
        }

        private void EditLabelMessage(UsLabelExInfors usLabelExInfors)
        {
            tpnl.BeginEditLabel(usLabelExInfors);
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
            tpnl.ToHidden();
            tpnl.MouseDown += new MouseEventHandler(Tpnl_MouseDown);
            tpnl.MouseMove += new MouseEventHandler(Tpnl_MouseMove);
            tpnl.MouseUp += new MouseEventHandler(Tpnl_MouseUp);

            tpnl.WritePainter += new AddMessagesToPainter(ToAddMessagesOnPainter);

            tpnl.Location = new Point(0, this.mnMainTop.Height);

            this.Controls.Add(tpnl);
            this.Controls.SetChildIndex(tpnl, 0);
        }

        private void ToAddMessagesOnPainter(UsCtrlExInfors lmp, CallBackFunc CallBack)
        {
            UsCtrlLayers.ToAddMessagesLabel(lmp, CallBack);
        }

        private void mnFile_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //MessageBox.Show("File\\"+e.ClickedItem.Name);
            switch (e.ClickedItem.Name)
            {
                case "mniOpen":
                    break;
                case "mniSave":
                    UsCtrlLayers.BackLayersVisible(false);
                    var btmp = UsCtrlLayers.GetCurrentBackLayerImage();
                    btmp.Save("D:\\Test.png", System.Drawing.Imaging.ImageFormat.Png);
                    UsCtrlLayers.BackLayersVisible(true);
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
                    tpnl.ToShow();
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
