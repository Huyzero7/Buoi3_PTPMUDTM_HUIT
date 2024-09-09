using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLNguoiDung
{
    internal static class Program
    {
        public static frm_QuanLyNhanSu mainForm = null;
        public static frm_DangNhap loginForm = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            loginForm = new frm_DangNhap();
            Application.Run(loginForm);
        }
    }
}
