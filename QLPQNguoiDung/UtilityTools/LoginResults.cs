using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityTools
{
    public enum LoginResults
    {
        //Sai tên đăng nhập hoặc mật khẩu
        Invalid,
        //Tên đăng nhập bị chặn
        Disable,
        //Đăng nhập thành công
        Success
    }
}
