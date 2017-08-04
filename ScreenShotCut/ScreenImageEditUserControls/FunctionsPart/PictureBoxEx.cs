using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenImageEditUserControls.FunctionsPart
{
    public class PictureBoxEx : PictureBox
    {
        public bool IsSelected { get; set; }
        public PictureBoxEx() : base()
        {
            IsSelected = false;
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            if (IsSelected)
            {
                Rectangle myRectangle = new Rectangle(0, 0, this.Width, this.Height);
                ControlPaint.DrawBorder(pe.Graphics, myRectangle,
                    Color.Red, 2, ButtonBorderStyle.Dotted,
                    Color.Red, 2, ButtonBorderStyle.Dotted,
                    Color.Red, 2, ButtonBorderStyle.Dotted,
                    Color.Red, 2, ButtonBorderStyle.Dotted
                );
            }
        }
    }
}
