﻿using System;
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
            var tabSize = this.tabControl1.ItemSize;
            this.tabControl1.ItemSize = new Size(500, 40);
        }
    }
}