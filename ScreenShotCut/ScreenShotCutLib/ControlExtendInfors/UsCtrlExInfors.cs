using ScreenShotCutLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenShotCutLib.Models;

namespace ScreenShotCutLib.ControlExtendInfors
{
    public class UsCtrlExInfors
    {
        public string ControlName { get; set; }
        public string ControlText { get; set; }
        public EnLayerType LayerType { get; set; }
    }

    public class UsLabelExInfors : UsCtrlExInfors
    {
        public LblModelParams LblParams { get; set; }
    }
}
