using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenShotCutLib.Models
{
    public interface IControlExProperties
    {
        bool IsSelectedControl { get; set; }
        void RefreshSelf();
        string GetControlName();
    }
}
