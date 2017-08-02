using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenShotCut.BaseForms
{
    public partial class BaseForm : Form
    {
        private static Dictionary<Type, Form> ListForm;
        public BaseForm()
        {
            InitializeComponent();
        }
        static BaseForm()
        {
            ListForm = new Dictionary<Type, Form>();
        }

        #region Virturl Functions
        public virtual void SaveImage(Image img)
        { }
        #endregion

        #region ForRegisterForm
        public static bool AddToRegistered<T>(T form) where T : Form
        {
            bool rValue = false;
            if (!ListForm.ContainsKey(typeof(T)))
            {
                ListForm.Add(typeof(T), form);
                rValue = true;
            }
            return rValue;
        }

        public static T GetReisteredForm<T>(Type type) where T : Form
        {
            T returnValue = default(T);
            if (ListForm.ContainsKey(type))
            {
                returnValue = ListForm[type] as T;
            }
            return returnValue;
        }

        public static bool RemoveRegisteredForm(Type type)
        {
            bool returnValue = true;
            if (ListForm.ContainsKey(type))
            {
                returnValue = ListForm.Remove(type);
            }
            return returnValue;
        }
        public static void ClearAllRegisterForm()
        {
            ListForm = new Dictionary<Type, Form>();
        }
        #endregion
    }
}
