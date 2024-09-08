using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC_Login
{
    public class NguoiDung : UC_Login
    {
        private string userName;
        private string password;

        public string UserName 
        { 
            get
            {
                return txt_TenDangNhap.Text;

            } 
            set
            {
                txt_TenDangNhap.Text = value;
            }
        }
        public string Password
        {
            get
            {
                return txt_MatKhau.Text;
            }
            set
            {
                txt_MatKhau.Text = value;
            }
        }
    }
}
