using ScreenShotCutLib.ControlExtendInfors;
using ScreenShotCutLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenShotCutLib.DelegatesList
{
    public delegate void CallBackFunc();
    public delegate void AddMessagesToPainter(UsCtrlExInfors lmp, CallBackFunc CallBack);
    public delegate void RunCommandHandler<T>(string command, T obj) where T : class;
}
