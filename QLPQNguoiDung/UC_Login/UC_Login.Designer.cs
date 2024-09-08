namespace UC_Login
{
    partial class UC_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_TieuDe_TenDangNhap = new System.Windows.Forms.Label();
            this.lbl_TieuDe_MatKhau = new System.Windows.Forms.Label();
            this.txt_TenDangNhap = new System.Windows.Forms.TextBox();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.chk_HienThiMatKhau = new System.Windows.Forms.CheckBox();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_TieuDe_TenDangNhap
            // 
            this.lbl_TieuDe_TenDangNhap.AutoSize = true;
            this.lbl_TieuDe_TenDangNhap.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TieuDe_TenDangNhap.Location = new System.Drawing.Point(16, 16);
            this.lbl_TieuDe_TenDangNhap.Name = "lbl_TieuDe_TenDangNhap";
            this.lbl_TieuDe_TenDangNhap.Size = new System.Drawing.Size(121, 21);
            this.lbl_TieuDe_TenDangNhap.TabIndex = 0;
            this.lbl_TieuDe_TenDangNhap.Text = "Tên đăng nhập";
            // 
            // lbl_TieuDe_MatKhau
            // 
            this.lbl_TieuDe_MatKhau.AutoSize = true;
            this.lbl_TieuDe_MatKhau.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TieuDe_MatKhau.Location = new System.Drawing.Point(16, 59);
            this.lbl_TieuDe_MatKhau.Name = "lbl_TieuDe_MatKhau";
            this.lbl_TieuDe_MatKhau.Size = new System.Drawing.Size(79, 21);
            this.lbl_TieuDe_MatKhau.TabIndex = 1;
            this.lbl_TieuDe_MatKhau.Text = "Mật khẩu";
            // 
            // txt_TenDangNhap
            // 
            this.txt_TenDangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenDangNhap.Location = new System.Drawing.Point(147, 11);
            this.txt_TenDangNhap.Name = "txt_TenDangNhap";
            this.txt_TenDangNhap.Size = new System.Drawing.Size(187, 26);
            this.txt_TenDangNhap.TabIndex = 2;
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatKhau.Location = new System.Drawing.Point(147, 54);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.PasswordChar = '*';
            this.txt_MatKhau.Size = new System.Drawing.Size(187, 26);
            this.txt_MatKhau.TabIndex = 3;
            // 
            // chk_HienThiMatKhau
            // 
            this.chk_HienThiMatKhau.AutoSize = true;
            this.chk_HienThiMatKhau.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_HienThiMatKhau.Location = new System.Drawing.Point(147, 92);
            this.chk_HienThiMatKhau.Name = "chk_HienThiMatKhau";
            this.chk_HienThiMatKhau.Size = new System.Drawing.Size(119, 19);
            this.chk_HienThiMatKhau.TabIndex = 4;
            this.chk_HienThiMatKhau.Text = "Hiển thị mật khẩu";
            this.chk_HienThiMatKhau.UseVisualStyleBackColor = true;
            this.chk_HienThiMatKhau.CheckedChanged += new System.EventHandler(this.chk_HienThiMatKhau_CheckedChanged);
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangNhap.Location = new System.Drawing.Point(147, 119);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(101, 30);
            this.btn_DangNhap.TabIndex = 5;
            this.btn_DangNhap.Text = "Đăng nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = true;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.Location = new System.Drawing.Point(270, 119);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(64, 30);
            this.btn_Huy.TabIndex = 6;
            this.btn_Huy.Text = "Huỷ";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // UC_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.chk_HienThiMatKhau);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.txt_TenDangNhap);
            this.Controls.Add(this.lbl_TieuDe_MatKhau);
            this.Controls.Add(this.lbl_TieuDe_TenDangNhap);
            this.Name = "UC_Login";
            this.Size = new System.Drawing.Size(354, 164);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TieuDe_TenDangNhap;
        private System.Windows.Forms.Label lbl_TieuDe_MatKhau;
        public System.Windows.Forms.TextBox txt_TenDangNhap;
        public System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.CheckBox chk_HienThiMatKhau;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.Button btn_Huy;
    }
}
