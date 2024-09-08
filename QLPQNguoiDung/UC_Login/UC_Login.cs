using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC_Login
{
    public partial class UC_Login: UserControl
    {
        //Định nghĩa delegate phục vụ cho event
        public delegate void SubmitClickedHandler(Object sender, EventArgs e);
        //Định nghĩa event SubmitClicked cho control
        public event SubmitClickedHandler SubmitClicked;
        public UC_Login()
        {
            InitializeComponent();
        }
        //Hiển thị mật khẩu khi người dùng tích vào checkbox
        private void chk_HienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_HienThiMatKhau.Checked)
            {
                txt_MatKhau.PasswordChar = (char)0;
            }
            else
            {
                txt_MatKhau.PasswordChar = '*';
            }    
        }
        //Sự kiện click cho button Đăng nhập
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            /*
            if (txt_TenDangNhap.Text.Length == 0)
            {
                MessageBox.Show("Hãy nhập tên đăng nhập!");
                return;
            }
            if (txt_MatKhau.Text.Length == 0)
            {
                MessageBox.Show("Hãy nhập mật khẩu!");
                return;
            }
            */

            if (string.IsNullOrEmpty(txt_TenDangNhap.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống" + lbl_TieuDe_TenDangNhap.Text.ToLower());
                this.txt_TenDangNhap.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_MatKhau.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống" + lbl_TieuDe_MatKhau.Text.ToLower());
                this.txt_MatKhau.Focus();
                return;
            }
            //Tạo sự kiện click để gọi hàm xử lý sự kiện click do người lập trình ứng dụng viết
            OnSubmitClicked(sender, e);
        }
        //Định nghĩa hàm xử lí sự kiện SubmitClicked
        protected virtual void OnSubmitClicked(object sender, EventArgs e)
        {
            //Kiểm tra xem có hàm xử lý sự kiện SubmitClicked? Nếu có thì gọi ra
            if(SubmitClicked != null)
                SubmitClicked(sender, e);
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            txt_TenDangNhap.Clear();
            txt_MatKhau.Clear();

            chk_HienThiMatKhau.Checked = false;
            //Thoát form cha
            this.ParentForm.Close();

            OnSubmitClicked(sender, e);

        }
    }
}
