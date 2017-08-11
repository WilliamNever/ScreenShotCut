using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScreenShotCutLib.Models;
using System.Configuration;
using ScreenShotCutLib.DelegatesList;
using ScreenShotCutLib.ControlExtendInfors;

namespace ScreenImageEditUserControls.ImagesEditSection
{
    public partial class ToolsPannel : UserControl
    {
        private string DefaultFontName;

        public AddMessagesToPainter WritePainter;

        private UsLabelExInfors UlblExInfors;

        #region BaseFunctions
        public ToolsPannel()
        {
            InitializeComponent();
            WritePainter = null;
        }

        #region ShowHideUserControl
        public void ToHidden()
        {
            this.Enabled = false;
            this.Visible = false;
        }

        public void ToShow()
        {
            this.Enabled = true;
            this.Visible = true;
        }

        #endregion

        private void lblClose_Click(object sender, EventArgs e)
        {
            ToHidden();
        }

        #region PostEventToControl
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
        #endregion

        private void ToolsPannel_Load(object sender, EventArgs e)
        {
            InitSystemFontsList();
        }

        private void InitSystemFontsList()
        {
            DefaultFontName = ConfigurationManager.AppSettings["DefaultFontName"];

            cbbFontList.DisplayMember = "name";
            cbbFontList.ValueMember = "SysFont";
            List<FontListModel> list = (from itm in FontFamily.Families
                                        select new FontListModel { name = itm.Name, SysFont = itm }).ToList();
            var idx = list.FindIndex(x => x.name.Equals(DefaultFontName, StringComparison.CurrentCultureIgnoreCase));
            cbbFontList.DataSource = list;

            if (idx > -1)
            {
                cbbFontList.SelectedIndex = idx;
            }
        }

        private void CallBack()
        {
            ToShow();
        }
        #endregion

        private string GetDemoText(string lblTxt, string InputTxt)
        {
            string tmp = lblTxt;
            if (InputTxt != "")
            {
                var stp = InputTxt.Replace("\n", "").Replace("\r", "");
                tmp = stp;
            }
            return tmp;
        }

        private void cbbFontList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var font = cbbFontList.SelectedValue as FontFamily;
            if (font != null)
            {
                btnDemo_Click(sender, e);
            }
        }

        private void btnDemo_Click(object sender, EventArgs e)
        {
            float fsize;
            var font = cbbFontList.SelectedValue as FontFamily;
            if (font != null)
            {
                if (!float.TryParse(txtFontSize.Text, out fsize))
                {
                    fsize = lblShowSample.Font.Size;
                }
                lblShowSample.Font = new Font(font, fsize, GetFontStype());
                lblShowSample.Text = GetDemoText(lblShowSample.Text, txtInput.Text);
                lblShowSample.ForeColor = btnPickColor.BackColor;
                lblShowSample.BackColor = cbkBgColor.Checked ? btnBgColor.BackColor : Color.Transparent;
            }
            else
            {
                MessageBox.Show("The Selected Font does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private FontStyle GetFontStype()
        {
            FontStyle fs = FontStyle.Regular;
            fs = cbkBold.Checked ? fs | FontStyle.Bold : fs;
            fs = cbkItalic.Checked ? fs | FontStyle.Italic : fs;
            fs = cbkStrkeOut.Checked ? fs | FontStyle.Strikeout : fs;
            fs = cbkUnderLine.Checked ? fs | FontStyle.Underline : fs;
            return fs;
        }

        #region color picker
        private void btnPickColor_Click(object sender, EventArgs e)
        {
            if (clDlgPickColor.ShowDialog(this) == DialogResult.OK)
            {
                btnPickColor.BackColor = clDlgPickColor.Color;
            }
        }

        private void btnBgColor_Click(object sender, EventArgs e)
        {
            if (clDlgPickColor.ShowDialog(this) == DialogResult.OK)
            {
                btnBgColor.BackColor = clDlgPickColor.Color;
            }
        }
        #endregion

        private void btnAddToShow_Click(object sender, EventArgs e)
        {

            LblModelParams lmp = new LblModelParams();

            float fsize;
            var font = cbbFontList.SelectedValue as FontFamily;
            if (font != null && !string.IsNullOrEmpty(txtInput.Text.Trim()))
            {
                lmp.Messages = txtInput.Text;
                if (!float.TryParse(txtFontSize.Text, out fsize))
                {
                    fsize = lblShowSample.Font.Size;
                }
                lmp.Font = new Font(font, fsize, GetFontStype());
                lmp.ForeColor = btnPickColor.BackColor;
                lmp.BackColor = cbkBgColor.Checked ? btnBgColor.BackColor : Color.Transparent;
                if (WritePainter != null)
                {
                    UsLabelExInfors uli = new UsLabelExInfors();
                    uli.LblParams = lmp;
                    uli.LayerType = ScreenShotCutLib.Enums.EnLayerType.Label;
                    ToHidden();
                    //*******************************************------------------*/
                    WritePainter?.Invoke(uli, CallBack);
                }
            }
            else
            {
                #region Error Messages
                string message = "";
                if (font == null) message += "The Selected Font does not exist.";
                if (string.IsNullOrEmpty(txtInput.Text.Trim())) message += "No Information to show.";
                if (string.IsNullOrEmpty(message)) message = "Errors!";
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
                #endregion
            }
        }

        public void BeginEditLabel(UsLabelExInfors usLabelExInfors)
        {
            UlblExInfors = usLabelExInfors;
            this.tabTools.SelectTab("tpText");
            #region set value to the pannel

            txtInput.Text = UlblExInfors.LblParams.Messages;
            var slitm = cbbFontList.Items.OfType<FontListModel>().ToList()
                .FindIndex(x => x.name.Equals(UlblExInfors.LblParams.Font.Name));
            cbbFontList.SelectedIndex = slitm;
            txtFontSize.Text = UlblExInfors.LblParams.Font.Size.ToString();

            cbkBold.Checked = UlblExInfors.LblParams.Font.Bold;
            cbkItalic.Checked = UlblExInfors.LblParams.Font.Italic;
            cbkStrkeOut.Checked = UlblExInfors.LblParams.Font.Strikeout;
            cbkUnderLine.Checked = UlblExInfors.LblParams.Font.Underline;

            btnPickColor.BackColor = UlblExInfors.LblParams.ForeColor;
            cbkBgColor.Checked = !(UlblExInfors.LblParams.BackColor == Color.Transparent);
            btnBgColor.BackColor = cbkBgColor.Checked ? UlblExInfors.LblParams.BackColor : btnBgColor.BackColor;

            #endregion
            ToShow();
            btnDemo.PerformClick();
        }
    }
}
