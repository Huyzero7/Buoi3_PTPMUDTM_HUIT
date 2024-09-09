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
using UtilityTools;
using DTO_QLNguoiDung;


namespace GUI_QLNguoiDung
{
    public partial class frm_DangNhap : Form
    {
        BUSNguoiDung nguoiDungBUS  = new BUSNguoiDung();
        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void uC_Login1_SubmitClicked(object sender, EventArgs e)
        {
            if (uC_Login1.txt_TenDangNhap.Text == "admin" && uC_Login1.txt_MatKhau.Text == "123456")
                MessageBox.Show("Đăng nhập thành công!, xin chào: " + uC_Login1.txt_TenDangNhap.Text);
            else
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ");

            string strConn = Properties.Settings.Default.STRConn;

            int kq = nguoiDungBUS.checkConfig(strConn);
            if (kq == 0)
                processLogin();
            else
            {
                if (kq == 2)
                    MessageBox.Show("Chuỗi cấu hình không phù hợp");
                else
                    MessageBox.Show("Chưa cấu hình hệ thống");
                processLogin();
            }    
        }

        private void processLogin()
        {
            LoginResults results;
            NguoiDungDTO nddto = new NguoiDungDTO(uC_Login1.txt_TenDangNhap.Text, uC_Login1.txt_MatKhau.Text);
            results = nguoiDungBUS.checkLogin(nddto);
            //sai tên đăng nhập hoặc sai mật khẩu
            if(results == LoginResults.Invalid)
            {
                MessageBox.Show("Tài khoản đã bị khoá");
                return;
            }
            if (Program.mainForm == null || Program.mainForm.IsDisposed)
            {
                Program.mainForm = new frm_QuanLyNhanSu();
            }
            this.Visible = false;
            Program.mainForm.Show();
        }
        private void processConfig()
        {
            frm_CauHinhChuoiKetNoi frmCau = new frm_CauHinhChuoiKetNoi();
            frmCau.Show();
        }
    }
}
