using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLNguoiDung
{
    public class DTO_NguoiDung
    {
        private string tenDangNhap;
        private string matKhau;
        private int isHoatDong;

        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public int IsHoatDong { get => isHoatDong; set => isHoatDong = value; }

        public DTO_NguoiDung()
        {
            tenDangNhap = string.Empty;
            matKhau = string.Empty;
            isHoatDong = 0;
        }

        public DTO_NguoiDung(string tenDangNhap, string matKhau, int isHoatDong)
        {
            TenDangNhap = tenDangNhap;
            MatKhau = matKhau;
            IsHoatDong = isHoatDong;
        }
    }
}
