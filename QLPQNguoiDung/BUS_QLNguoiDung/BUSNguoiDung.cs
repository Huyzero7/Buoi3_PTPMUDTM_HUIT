using DAL_QLNguoiDung;
using DTO_QLNguoiDung;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityTools;

namespace BUS_QLNguoiDung
{
    public class BUSNguoiDung
    {
        DALNguoiDung nguoiDungDAL = new DALNguoiDung();

        public int checkConfig(string strConn)
        {
            return nguoiDungDAL.checkConfig(strConn);
        }
        public LoginResults checkLogin(NguoiDungDTO nguoidung)
        {
            return nguoiDungDAL.checkUser(nguoidung.User, nguoidung.Pass);
        }
    }
}
