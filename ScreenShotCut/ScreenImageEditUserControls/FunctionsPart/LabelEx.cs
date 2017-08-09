using ScreenShotCutLib.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenImageEditUserControls.FunctionsPart
{
    public class LabelEx : Label, ScreenShotCutLib.Models.IControlExProperties
    {
        private EnLayerType layerType;
        public EnLayerType LayerType { get { return layerType; } }
        public bool IsSelectedControl { get; set; }

        public LabelEx() : base()
        {
            IsSelectedControl = false;
            layerType = EnLayerType.Label;
        }

        public string GetControlName()
        {
            return Name;
        }

        public void RefreshSelf()
        {
            Refresh();
        }

        public void ChangeLayerTypeTo(EnLayerType ltype)
        {
            layerType = ltype;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            if (IsSelectedControl)
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
        public EnLayerType GetLayerType()
        {
            return LayerType;
        }
    }
}
