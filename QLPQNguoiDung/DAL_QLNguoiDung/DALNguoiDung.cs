using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

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
    }
}