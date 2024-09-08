using BUS_QLNguoiDung;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration; //Thư viện đọc app.config

namespace GUI_QLNguoiDung
{
    public partial class frm_DangNhap : Form
    {
        private readonly BLL_QLPQNguoiDung nguoiDungBLL;
        public frm_DangNhap()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["GUI_QLNguoiDung.Properties.Settings.DB_QLPQNGUOIDUNGConnectionString"].ConnectionString;
            nguoiDungBLL = new BLL_QLPQNguoiDung(connectionString);
        }

        private void uC_Login1_SubmitClicked(object sender, EventArgs e)
        {
            if (uC_Login1.txt_TenDangNhap.Text == "admin" && uC_Login1.txt_MatKhau.Text == "123456")
                MessageBox.Show("Đăng nhập thành công!, xin chào: " + uC_Login1.txt_TenDangNhap.Text);
            else
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ");
        }
    }
}
