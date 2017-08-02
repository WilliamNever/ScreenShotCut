#define debug

using ScreenShotCut.BaseForms;
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

        private frmImageEdit()
        {
            scale = 1;
            InitializeComponent();
            InitCtrols();
        }

        private void InitCtrols()
        {
            img = Properties.Resources.aat2017731_00001;
            UsCtrlBackGroundImage.AddBottomImage(img);
            UsCtrlBackGroundImage.AddTopImage(Properties.Resources.small2017731_00001);
            //UsCtrlBackGroundImage.SetScale(1F);
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
                    break;
                case "mniText":
                    break;
                case "mniRectangle":
                    break;
                case "mniScale":
                    break;
                default:
                    break;
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
