using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLNguoiDung;

namespace BUS_QLNguoiDung
{
    public class BLL_QLPQNguoiDung
    {
        private readonly DAL_QLPQNguoiDung nguoiDungDAL;

        public BLL_QLPQNguoiDung(string connectionString)
        {
            nguoiDungDAL = new DAL_QLPQNguoiDung(connectionString);
        }

        //Kiểm tra thông tin đăng nhập
        public bool check_ThongTinDangNhap(string tenDangNhap, string matKhau)
        {
            return nguoiDungDAL.check_ThongTinDangNhap(tenDangNhap, matKhau);
        }

        //Kiểm tra tên người dùng còn hoạt động hay không? 3.b
        public bool check_HoatDongNguoiDung(string tenDangNhap)
        {
            return nguoiDungDAL.check_HoatDongNguoiDung(tenDangNhap);
        }

        //Kiểm tra người dùng có tồn tại không? 3.a
        public bool check_NguoiDungTonTai(string tenDangNhap)
        {
            return nguoiDungDAL.check_NguoiDungTonTai(tenDangNhap);
        }
    }
}
