using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenShotCutLib.ControlExtendInfors
{
    public class SwitchOnOff
    {
        public bool IsAddingOrEditingMessageLabel { get; set; }

        public SwitchOnOff()
        {
            IsAddingOrEditingMessageLabel = false;
        }
    }
}
