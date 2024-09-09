using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using UtilityTools;

namespace DAL_QLNguoiDung
{
    public class DALNguoiDung
    {
        SqlConnection _Sqlconn;

        public DALNguoiDung()
        {
            _Sqlconn = new SqlConnection();
        }

        public int checkConfig(String strConn)
        {
            if (strConn == string.Empty)
                return 1; //Chuỗi cấu hình không tồn tại
            _Sqlconn = new SqlConnection(strConn);
            try
            {
                if (_Sqlconn.State == ConnectionState.Closed)
                    _Sqlconn.Open();
                return 0; //Kết nối thành công
            }
            catch
            {
                return 2; //Chuỗi cấu hình không phù hợp
            }
        }
        public LoginResults checkUser(string pUser, string pPass)
        {
            string _sqlString = "SELECT * FROM QL_NGUOIDUNG WHERE TenDangNhap = '" + pUser + "' AND MatKhau ='" + pPass + "'";
            SqlDataAdapter daUser = new SqlDataAdapter (_sqlString, _Sqlconn);

            DataTable dt = new DataTable();
            daUser.Fill(dt);
            if (dt.Rows.Count == 0)
                return UtilityTools.LoginResults.Disable; //User không tồn tại
            else if (dt.Rows[0][2] == null || dt.Rows[0][2].ToString() == "0")
                return UtilityTools.LoginResults.Invalid; //Không hoạt động
            return UtilityTools.LoginResults.Success; //Đăng nhập thành công
        }
    }
}