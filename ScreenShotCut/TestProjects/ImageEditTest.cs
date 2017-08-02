#define debug

using ScreenShotCut.BaseForms;
using ScreenShotCutLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestProjects.Properties;

namespace ScreenShotCut.SubFunctionForm
{
    public partial class frmImageEditTest : Form
    {
        private BaseForm FrmBaseForm;
        private Image BaseImage;
        private frmImageEditTest()
        {
            InitializeComponent();
        }

        public frmImageEditTest(BaseForm bsf, Image img)
            : this()
        {
            FrmBaseForm = bsf;
            BaseImage = img;
        }

        private void frmImageEdit_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Width = Resources.aat2017731_00001.Width;
            pictureBox1.Height = Resources.aat2017731_00001.Height;
            pictureBox1.Image = Resources.aat2017731_00001;
            scl = 1;

            //this.Controls.SetChildIndex(this.panel1, 0);
            //var aa = this.Controls.Count;
        }
        float scl = 1;
        private void button2_Click(object sender, EventArgs e)
        {
            scl = scl * 0.5F;
            var nimg= ScSCutDomain.ScaledImage(Resources.aat2017731_00001, scl); ;
            pictureBox1.Width = nimg.Width;
            pictureBox1.Height = nimg.Height;
            pictureBox1.Image = nimg;
            //this.tabControl1.TabPages.Add()
            //TabPage tp = new TabPage()
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var tab3 = new TabPage("page3x");
            tab3.Name = "axccd";
            tab3.AutoScroll = true;
            //tab3.BackColor = Color.Transparent;
            tab3.UseVisualStyleBackColor = true;

            panel2.Location = new Point(0, 0);

            tab3.Controls.Add(panel2);
            this.tabControl1.TabPages.Add(
                tab3
                );
            //this.tabControl1.TabPages.RemoveByKey()
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.RemoveByKey("axccd");
            //foreach (TabPage itm in tabControl1.TabPages)
            //{
            //    tabControl1.TabPages.RemoveAt(0);
            //}
        }
        bool tabMove = false;
        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            tabMove = true;
        }

        private void tabControl1_MouseMove(object sender, MouseEventArgs e)
        {
            if (tabMove)
            {
                panel3.Location = new Point(panel3.Location.X + e.X, panel3.Location.Y + e.Y);
            }
        }

        private void tabControl1_MouseUp(object sender, MouseEventArgs e)
        {
            tabMove = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pictureBox2.CanSelect.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var height = splitContainer1.Panel1.Height;
            splitContainer1.Panel2Collapsed = !splitContainer1.Panel2Collapsed;
            splitContainer1.Height = height;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Select();
        }
    }
}
