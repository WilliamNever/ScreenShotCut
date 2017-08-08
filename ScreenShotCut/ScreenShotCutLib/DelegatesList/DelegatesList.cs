using ScreenShotCutLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenShotCutLib.DelegatesList
{
    public delegate void CallBackFunc();
    public delegate void AddMessagesToPainter(LblModelParams lmp, CallBackFunc CallBack);
}
