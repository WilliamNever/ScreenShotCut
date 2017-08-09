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
using ScreenShotCutLib.DelegatesList;
using ScreenImageEditUserControls.AssistantControls;

namespace ScreenImageEditUserControls.ImagesEditSection
{
    public partial class UCtrlBackGround : UserControl
    {
        private CallBackFunc AddMessagesCallBack;
        private LblModelParams lmParams;

        private PicContentMenu picMenu;
        private LabelContxtMenu lblMenu;

        private float picsScale;
        /// <summary>
        /// All of the layer scale num
        /// </summary>
        public float PicsScale { get { return picsScale; } }
        private MoveControlInfor MvCtrlInfor { get; set; }
        private SwitchOnOff Switcher;

        public RunCommandHandler<UsCtrlExInfors> RunCommand;

        public UCtrlBackGround()
        {
            InitializeComponent();
            InitializeSelfDefineComponent();
        }

        private void InitializeSelfDefineComponent()
        {
            picsScale = 1F;
            MvCtrlInfor = null;
            Switcher = new SwitchOnOff();
            if (components == null)
            {
                components = new System.ComponentModel.Container();
            }
            picMenu = new FunctionsPart.PicContentMenu(this.components);
            picMenu.Opening += new System.ComponentModel.CancelEventHandler(this.mnChildSelectionAction_Opening);
            picMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnChildSelectionAction_ItemClicked);
            picMenu.Name = "SelfPicContextMenu";

            lblMenu = new LabelContxtMenu(this.components);
            lblMenu.Opening += new System.ComponentModel.CancelEventHandler(this.mnChildSelectionAction_Opening);
            lblMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnChildSelectionAction_ItemClicked);
            lblMenu.Name = "SelfLabelContextMenu";

            RunCommand = null;
        }

        private void UCtrlBackGround_Load(object sender, EventArgs e)
        {
        }

        public void AddBottomImage(Image img)
        {
            var guid = Guid.NewGuid();
            var picBottom = new PictureBoxEx();
            picBottom.Name = guid.ToString();
            picBottom.Parent = this;
            picBottom.SizeMode = PictureBoxSizeMode.Zoom;
            picBottom.Location = new Point(0, 0);
            picBottom.Width = Convert.ToInt32(img.Width * PicsScale);
            picBottom.Height = Convert.ToInt32(img.Height * PicsScale);
            picBottom.Image = img;
            picBottom.Tag = new UsCtrlExInfors { ControlName = picBottom.Name, ControlText = "" };
            picBottom.ContextMenuStrip = picMenu;// mnChildSelectionAction;

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
            pidTop.Parent = this;
            pidTop.SizeMode = PictureBoxSizeMode.Zoom;
            pidTop.Location = new Point(0, 0);
            pidTop.Width = Convert.ToInt32(img.Width * PicsScale);
            pidTop.Height = Convert.ToInt32(img.Height * PicsScale);
            pidTop.Image = img;
            pidTop.Tag = new UsCtrlExInfors { ControlName = pidTop.Name, ControlText = "" };
            pidTop.ContextMenuStrip = picMenu;// mnChildSelectionAction;

            pidTop.MouseDown += new MouseEventHandler(Conotrl_MouseDown);
            pidTop.MouseMove += new MouseEventHandler(Conotrl_MouseMove);
            pidTop.MouseUp += new MouseEventHandler(Conotrl_MouseUp);
            
            this.Controls.Add(pidTop);
            this.Controls.SetChildIndex(pidTop, 0);
        }

        public void ToAddMessagesLabel(LblModelParams lmp, CallBackFunc CallBack)
        {
            AddMessagesCallBack = CallBack;
            lmParams = lmp;
            Switcher.IsAddingMessageLabel = true;
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
            if (Switcher.IsAddingMessageLabel)
            {
                OnMouseDown(e);
            }
            else
            {
                if (e.Button == MouseButtons.Left)
                {
                    MvCtrlInfor = new MoveControlInfor { Location = e.Location };
                }
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
                    case "tsmiEdit":
                        ToEditLabelExOutSide("EditLabelEx",ctrl);
                        break;
                    case "tsmiConvertToPicture":
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

        private void ToEditLabelExOutSide(string CommandName, IControlExProperties ctrl)
        {
            UsCtrlExInfors exInfor = null;
            if (ctrl.GetLayerType() == ScreenShotCutLib.Enums.EnLayerType.Label)
            {
                var lblEx = ctrl as LabelEx;
                UsLabelExInfors tmp = new UsLabelExInfors();

                tmp.ControlName = ctrl.GetControlName();
                tmp.LayerType = ctrl.GetLayerType();

                LblModelParams lprms = new LblModelParams();
                lprms.BackColor = lblEx.BackColor;
                lprms.Font = lblEx.Font;
                lprms.ForeColor = lblEx.ForeColor;
                lprms.Location = lblEx.Location;
                lprms.Messages = lblEx.Text;

                tmp.LblParams = lprms;
                exInfor = tmp;
            }
            RunCommand?.Invoke(CommandName, exInfor);
        }

        private void mnChildSelectionAction_Opening(object sender, CancelEventArgs e)
        {
            var menu = (ContextMenuStrip)sender;
            var ctrl = menu.SourceControl as IControlExProperties;
            menu.Items["tsmiSelect"].Text = ctrl.IsSelectedControl ? "UnSelect" : "Select";
        }

        private void UCtrlBackGround_MouseDown(object sender, MouseEventArgs e)
        {
            if (Switcher.IsAddingMessageLabel)
            {
                if (e.Button == MouseButtons.Left)
                {
                    lmParams.Location = e.Location;
                    AddMessagesLable(lmParams);
                    Switcher.IsAddingMessageLabel = false;
                    AddMessagesCallBack?.Invoke();
                }
                else if (e.Button == MouseButtons.Right)
                {
                    Switcher.IsAddingMessageLabel = false;
                    AddMessagesCallBack?.Invoke();
                }
            }
        }

        public void AddMessagesLable(LblModelParams lmParams)
        {
            var guid = Guid.NewGuid();
            LabelEx lblExMessages = new LabelEx();
            lblExMessages.Name = guid.ToString();
            lblExMessages.AutoSize = true;
            lblExMessages.Text = lmParams.Messages;
            lblExMessages.Parent = this;
            lblExMessages.Location = lmParams.Location;
            lblExMessages.Font = lmParams.Font;
            lblExMessages.ForeColor = lmParams.ForeColor;
            lblExMessages.BackColor = lmParams.BackColor;
            lblExMessages.Tag = new UsCtrlExInfors { ControlName = lblExMessages.Name, ControlText = "" };
            lblExMessages.ContextMenuStrip = lblMenu;// mnChildSelectionAction;

            lblExMessages.MouseDown += new MouseEventHandler(Conotrl_MouseDown);
            lblExMessages.MouseMove += new MouseEventHandler(Conotrl_MouseMove);
            lblExMessages.MouseUp += new MouseEventHandler(Conotrl_MouseUp);

            this.Controls.Add(lblExMessages);
            this.Controls.SetChildIndex(lblExMessages, 0);
        }
    }
}
