using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProjects
{
    public partial class WFTv1 : Form
    {
        public WFTv1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Visible = !panel3.Visible;
            if (panel3.Visible)
            {
                panel1.Height = panel2.Height + panel3.Height;
            }
            else
            {
                panel1.Height = panel2.Height;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //var tabSize = this.tabControl1.ItemSize;
            //this.tabControl1.ItemSize = new Size(500, 40);
            Bitmap tmp = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(tmp, new Rectangle(0, 0, panel1.Width, panel1.Height));
            tmp.Save(@"d:\aaa.png",System.Drawing.Imaging.ImageFormat.Png);
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            label4.Text = e.X.ToString() + "/" + e.Y.ToString();
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void label3_MouseUp(object sender, MouseEventArgs e)
        {
            MessageBox.Show("11");
        }

        private void WFTv1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("1");
        }

        private void WFTv1_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show("2");
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("3");
            OnMouseClick(e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel4.Parent = Controls[5];
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("23");
        }

        private void panel4_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("21");
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show("22");
            OnClick(e);
        }
    }
}
