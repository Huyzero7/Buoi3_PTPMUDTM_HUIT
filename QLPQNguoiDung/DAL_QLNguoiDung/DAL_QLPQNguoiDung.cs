using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLNguoiDung
{
    public class DAL_QLPQNguoiDung
    {
        private string connectionString;
        public string ConnectionString { get => connectionString; set => connectionString = value; }
        //Phương thức khởi tạo
        public DAL_QLPQNguoiDung(string ConnectionString)
        {
            connectionString = ConnectionString;
        }

        //1. Kiểm tra thông tin đăng nhập
        public bool check_ThongTinDangNhap(string tenDangNhap, string matKhau)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                string query = "SELECT COUNT(*) FROM QL_NguoiDung WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau";
                using (var cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                    cmd.Parameters.AddWithValue("@MatKhau", matKhau);
                    connection.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        //2. Phương thức kiểm tra thông tin chuỗi kết nối
        public int check_KiemTraChuoiKetNoi(string ConnectionString)
        {
            if (string.IsNullOrEmpty(ConnectionString))
                return 1; //Chuỗi cấu hình không tôn tại
            try
            {
                using (var conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    return 0; //Kết nối thành công
                }
            }
            catch (Exception)
            {
                return 2; //Chuỗi kết nối không phù hợp
            }
        }
        //3.a. Kiểm tra tồn tại của tên đăng nhập và mật khẩu
        public bool check_NguoiDungTonTai(string tenDangNhap)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                string query = "SELECT COUNT(*) FROM QL_NguoiDung WHERE TenDangNhap = @TenDangNhap";
                using (var cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                    connection.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        //3.b. Kiểm tra tên người dùng còn hoạt động hay không?
        public bool check_HoatDongNguoiDung(string tenDangNhap)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                string query = "SELECT HoatDong FROM QL_NguoiDung WHERE TenDangNhap = @TenDangNhap";
                using (var cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                    connection.Open();
                    object result = cmd.ExecuteScalar();
                    // Kiểm tra kết quả có phải là số nguyên không và kiểm tra giá trị
                    if (result != null && result is int intValue)
                    {
                        return intValue == 1; // Trả về true nếu giá trị là 1, false nếu không phải
                    }
                    return false;
                }
            }
        }
        //4. Cấu hình lại chuỗi kết nối
        public void taoChuoiKetNoi(string connectionString)
        {
            ConnectionString = connectionString;
        }
    }
}