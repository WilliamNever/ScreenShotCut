#define debug_SaveTextImage

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
        private UsCtrlExInfors CtrlExInfor;

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

        public Image GetMergedBmp()
        {
            var scl = PicsScale;
            SetScale(1F);

            Bitmap rValue = null;
            int imgWith = 0, imgHeight = 0, lfX, lfY;
            Point leftTopPoint;
            if (Controls.Count > 0)
            {
                imgWith = Controls.OfType<Control>().Select(x => x.Width).Max();
                imgHeight = Controls.OfType<Control>().Select(x => x.Height).Max();

                lfX = Controls.OfType<Control>().Select(x => x.Location.X).Min();
                lfY = Controls.OfType<Control>().Select(x => x.Location.Y).Min();

                lfX = lfX < 0 ? 0 : lfX;
                lfY = lfY < 0 ? 0 : lfY;
                leftTopPoint = new Point(lfX, lfY);

                rValue = new Bitmap(imgWith - lfX, imgHeight - lfY);

                for (var i = Controls.Count - 1; i > -1; i--)
                {
                }
            }
            SetScale(scl);
            return rValue;
        }

        private void UCtrlBackGround_Load(object sender, EventArgs e)
        {
        }

        public void AddBottomImage(Image img)
        {
            AddImageLayer(img, -1, new Point(0, 0));
        }
        public void AddTopImage(Image img)
        {
            AddImageLayer(img, 0, new Point(0, 0));
        }

        private void AddImageLayer(Image img, int LayerIndex, Point Location)
        {
            var guid = Guid.NewGuid();
            var picEx = new PictureBoxEx();
            picEx.Name = guid.ToString();
            picEx.Parent = this;
            picEx.SizeMode = PictureBoxSizeMode.Zoom;
            picEx.Location = Location;
            picEx.Width = Convert.ToInt32(img.Width * PicsScale);
            picEx.Height = Convert.ToInt32(img.Height * PicsScale);
            picEx.Image = img;
            picEx.Tag = new UsCtrlExInfors { ControlName = picEx.Name, ControlText = "" };
            picEx.ContextMenuStrip = picMenu;

            picEx.MouseDown += new MouseEventHandler(Conotrl_MouseDown);
            picEx.MouseMove += new MouseEventHandler(Conotrl_MouseMove);
            picEx.MouseUp += new MouseEventHandler(Conotrl_MouseUp);

            this.Controls.Add(picEx);
            if (-1 < LayerIndex && LayerIndex < Controls.Count)
            {
                this.Controls.SetChildIndex(picEx, LayerIndex);
            }
        }

        public void ToAddMessagesLabel(UsCtrlExInfors lmp, CallBackFunc CallBack)
        {
            if (lmp.LayerType == ScreenShotCutLib.Enums.EnLayerType.Label)
            {
                if (string.IsNullOrEmpty(lmp.ControlName?.Trim()))
                {
                    AddMessagesCallBack = CallBack;
                    CtrlExInfor = lmp;
                    Switcher.IsAddingOrEditingMessageLabel = true;
                }
                else
                {
                    AddMessagesLable(lmp as UsLabelExInfors);
                    CallBack?.Invoke();
                }
            }
            else
            {
                CallBack?.Invoke();
            }
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
            if (Switcher.IsAddingOrEditingMessageLabel)
            {
                var slSender = sender as IControlExProperties;
                int RX = e.X;
                int RY = e.Y;
                if (slSender != null)
                {
                    RX += slSender.ControlLocation.X;
                    RY += slSender.ControlLocation.Y;
                }
                var ax = new MouseEventArgs(e.Button, e.Clicks, RX, RY, e.Delta);
                OnMouseDown(ax);
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
                var ctrlEx = itm as IControlExProperties;
                if (ctrlEx != null)
                {
                    switch (ctrlEx.GetLayerType())
                    {
                        case ScreenShotCutLib.Enums.EnLayerType.Picture:
                            var picb = itm as PictureBoxEx;
                            if (picb != null && picb.Image != null)
                            {
                                picb.Width = Convert.ToInt32(picb.Image.Width * PicsScale);
                                picb.Height = Convert.ToInt32(picb.Image.Height * PicsScale);
                            }
                            break;
                        case ScreenShotCutLib.Enums.EnLayerType.Label:
                            var lblEx = itm as LabelEx;
                            var fontOri = lblEx.Tag as UsLabelExInfors;
                            lblEx.Font = new Font(fontOri.LblParams.Font.FontFamily, fontOri.LblParams.Font.Size * PicsScale, fontOri.LblParams.Font.Style);
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void mnChildSelectionAction_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
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
                        ToEditLabelExOutSide("EditLabelEx", ctrl);
                        break;
                    case "tsmiConvertToPicture":
                        Image desImage = ConvertToImage(ctrl);
#if debug_SaveTextImage
                        desImage.Save(@"D:\WQPersonal\baseHtml\ss.png", System.Drawing.Imaging.ImageFormat.Png);
#endif
                        AddImageLayer(desImage, Controls.IndexOfKey(ctrl.GetControlName()),ctrl.ControlLocation);
                        Controls.RemoveByKey(ctrl.GetControlName());
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

        private Image ConvertToImage(IControlExProperties ctrl)
        {
            Image rValue = null;
            if (ctrl.GetLayerType() == ScreenShotCutLib.Enums.EnLayerType.Label)
            {
                var lblEx = ctrl as LabelEx;
                var oriInfor = lblEx.GetControlExInfors() as UsLabelExInfors;
                //取未被缩放时的大小生成图片，避免取大小值时出现闪烁，先进行隐藏
                lblEx.Visible = false;
                lblEx.Font = new Font(oriInfor.LblParams.Font.FontFamily, oriInfor.LblParams.Font.Size, oriInfor.LblParams.Font.Style);
                rValue = new Bitmap(lblEx.Width, lblEx.Height);
                Graphics g = Graphics.FromImage(rValue);
                g.FillRectangle(new SolidBrush(lblEx.BackColor), 0, 0, rValue.Width, rValue.Height);
                g.DrawString(lblEx.Text, lblEx.Font, new SolidBrush(lblEx.ForeColor), new Point(0, 0));
                g.Flush();
            }
            return rValue;
        }

        private void ToEditLabelExOutSide(string CommandName, IControlExProperties ctrl)
        {
            UsCtrlExInfors exInfor = null;
            if (ctrl.GetLayerType() == ScreenShotCutLib.Enums.EnLayerType.Label)
            { 
                var lblEx = ctrl as LabelEx;
                exInfor = lblEx?.Tag as UsCtrlExInfors;
            }
            RunCommand?.Invoke(CommandName, exInfor);
        }
        /// <summary>
        /// 控件截图功能
        /// </summary>
        /// <returns></returns>
        public Bitmap GetCurrentControlBitmat()
        {
            Bitmap btmp = new Bitmap(this.Width, this.Height);
            Controls.AddRange(Controls.OfType<Control>().Reverse().ToArray());
            this.DrawToBitmap(btmp, new Rectangle(0, 0, btmp.Width,btmp.Height));
            Controls.AddRange(Controls.OfType<Control>().Reverse().ToArray());
            return btmp;
        }

        private void mnChildSelectionAction_Opening(object sender, CancelEventArgs e)
        {
            var menu = (ContextMenuStrip)sender;
            var ctrl = menu.SourceControl as IControlExProperties;
            menu.Items["tsmiSelect"].Text = ctrl.IsSelectedControl ? "UnSelect" : "Select";
        }

        private void UCtrlBackGround_MouseDown(object sender, MouseEventArgs e)
        {
            if (Switcher.IsAddingOrEditingMessageLabel)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (CtrlExInfor.LayerType == ScreenShotCutLib.Enums.EnLayerType.Label)
                    {
                        var lblExInfor = CtrlExInfor as UsLabelExInfors;
                        lblExInfor.LblParams.Location = e.Location;
                        AddMessagesLable(lblExInfor);
                        Switcher.IsAddingOrEditingMessageLabel = false;
                        AddMessagesCallBack?.Invoke();
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    Switcher.IsAddingOrEditingMessageLabel = false;
                    AddMessagesCallBack?.Invoke();
                }
            }
        }

        public void AddMessagesLable(UsLabelExInfors lblExInfor)
        {
            var lmParams = lblExInfor.LblParams;
            string ctrlKey = lblExInfor.ControlName?.Trim();

            if (string.IsNullOrEmpty(ctrlKey) ||!Controls.ContainsKey(ctrlKey))
            {
                var guid = Guid.NewGuid();
                LabelEx lblExMessages = new LabelEx();
                lblExMessages.Name = guid.ToString();
                lblExMessages.AutoSize = true;
                lblExMessages.UseMnemonic = false;
                lblExMessages.Text = lmParams.Messages;
                lblExMessages.Parent = this;
                lblExMessages.Location = lmParams.Location;
                lblExMessages.Font = new Font(lmParams.Font.FontFamily, lmParams.Font.Size * PicsScale, lmParams.Font.Style); //lmParams.Font;
                lblExMessages.ForeColor = lmParams.ForeColor;
                lblExMessages.BackColor = lmParams.BackColor;
                lblExInfor.ControlName = lblExMessages.Name;
                lblExMessages.Tag = lblExInfor;
                lblExMessages.ContextMenuStrip = lblMenu;// mnChildSelectionAction;

                lblExMessages.MouseDown += new MouseEventHandler(Conotrl_MouseDown);
                lblExMessages.MouseMove += new MouseEventHandler(Conotrl_MouseMove);
                lblExMessages.MouseUp += new MouseEventHandler(Conotrl_MouseUp);

                this.Controls.Add(lblExMessages);
                this.Controls.SetChildIndex(lblExMessages, 0);
            }
            else
            {
                var lblExMessages = Controls[ctrlKey] as LabelEx;
                if (lblExMessages != null)
                {
                    lblExMessages.Text = lmParams.Messages;
                    lblExMessages.Font = new Font(lmParams.Font.FontFamily, lmParams.Font.Size * PicsScale, lmParams.Font.Style);
                    lblExMessages.ForeColor = lmParams.ForeColor;
                    lblExMessages.BackColor = lmParams.BackColor;
                    lblExMessages.Tag = lblExInfor;
                }
            }
        }
    }
}
