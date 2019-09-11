namespace QLCaPheProject
{
    partial class frm_ThongTinNguoiDung
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ThongTinNguoiDung));
            this.txt_TenDangNhap = new System.Windows.Forms.TextBox();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.txt_TenThat = new System.Windows.Forms.TextBox();
            this.txt_HinhAnh = new System.Windows.Forms.TextBox();
            this.txt_CMND = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbb_PhanQuyen = new System.Windows.Forms.ComboBox();
            this.btn_ThayDoiThongTin = new DevExpress.XtraEditors.SimpleButton();
            this.ptb_Avatar = new System.Windows.Forms.PictureBox();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ChonHinh = new DevExpress.XtraEditors.SimpleButton();
            this.rtb_DiaChi = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_HienPass = new DevExpress.XtraEditors.SimpleButton();
            this.txt_NhapLaiMatKhau = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_HienNhapLaiMatKhau = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_TenDangNhap
            // 
            this.txt_TenDangNhap.Location = new System.Drawing.Point(320, 27);
            this.txt_TenDangNhap.Name = "txt_TenDangNhap";
            this.txt_TenDangNhap.ReadOnly = true;
            this.txt_TenDangNhap.Size = new System.Drawing.Size(135, 21);
            this.txt_TenDangNhap.TabIndex = 0;
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Location = new System.Drawing.Point(320, 64);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(176, 21);
            this.txt_MatKhau.TabIndex = 1;
            this.txt_MatKhau.UseSystemPasswordChar = true;
            this.txt_MatKhau.TextChanged += new System.EventHandler(this.txt_MatKhau_TextChanged);
            // 
            // txt_TenThat
            // 
            this.txt_TenThat.Location = new System.Drawing.Point(320, 133);
            this.txt_TenThat.Name = "txt_TenThat";
            this.txt_TenThat.Size = new System.Drawing.Size(154, 21);
            this.txt_TenThat.TabIndex = 3;
            this.txt_TenThat.TextChanged += new System.EventHandler(this.txt_TenThat_TextChanged);
            // 
            // txt_HinhAnh
            // 
            this.txt_HinhAnh.Location = new System.Drawing.Point(158, 380);
            this.txt_HinhAnh.Name = "txt_HinhAnh";
            this.txt_HinhAnh.Size = new System.Drawing.Size(297, 21);
            this.txt_HinhAnh.TabIndex = 8;
            this.txt_HinhAnh.TextChanged += new System.EventHandler(this.txt_HinhAnh_TextChanged);
            // 
            // txt_CMND
            // 
            this.txt_CMND.Location = new System.Drawing.Point(320, 175);
            this.txt_CMND.Name = "txt_CMND";
            this.txt_CMND.Size = new System.Drawing.Size(135, 21);
            this.txt_CMND.TabIndex = 4;
            this.txt_CMND.TextChanged += new System.EventHandler(this.txt_CMND_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(197, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên người dùng :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(197, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(197, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên thật :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Hình ảnh : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Quyền hạn : ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(9, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ngày sinh :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(9, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Địa chỉ :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(197, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Chứng minh ND :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(156, 256);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(130, 21);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cbb_PhanQuyen
            // 
            this.cbb_PhanQuyen.FormattingEnabled = true;
            this.cbb_PhanQuyen.Items.AddRange(new object[] {
            "Quản trị viên",
            "Quản lý"});
            this.cbb_PhanQuyen.Location = new System.Drawing.Point(156, 219);
            this.cbb_PhanQuyen.Name = "cbb_PhanQuyen";
            this.cbb_PhanQuyen.Size = new System.Drawing.Size(161, 21);
            this.cbb_PhanQuyen.TabIndex = 5;
            // 
            // btn_ThayDoiThongTin
            // 
            this.btn_ThayDoiThongTin.Location = new System.Drawing.Point(144, 429);
            this.btn_ThayDoiThongTin.Name = "btn_ThayDoiThongTin";
            this.btn_ThayDoiThongTin.Size = new System.Drawing.Size(75, 23);
            this.btn_ThayDoiThongTin.TabIndex = 9;
            this.btn_ThayDoiThongTin.Text = "Xác nhận";
            this.btn_ThayDoiThongTin.Click += new System.EventHandler(this.btn_ThayDoiThongTin_Click);
            // 
            // ptb_Avatar
            // 
            this.ptb_Avatar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptb_Avatar.Location = new System.Drawing.Point(12, 21);
            this.ptb_Avatar.Name = "ptb_Avatar";
            this.ptb_Avatar.Size = new System.Drawing.Size(148, 176);
            this.ptb_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_Avatar.TabIndex = 0;
            this.ptb_Avatar.TabStop = false;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(320, 429);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 10;
            this.simpleButton2.Text = "Thoát";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btn_ChonHinh
            // 
            this.btn_ChonHinh.Location = new System.Drawing.Point(467, 378);
            this.btn_ChonHinh.Name = "btn_ChonHinh";
            this.btn_ChonHinh.Size = new System.Drawing.Size(29, 23);
            this.btn_ChonHinh.TabIndex = 5;
            this.btn_ChonHinh.Text = "...";
            this.btn_ChonHinh.Click += new System.EventHandler(this.btn_ChonHinh_Click);
            // 
            // rtb_DiaChi
            // 
            this.rtb_DiaChi.Location = new System.Drawing.Point(158, 283);
            this.rtb_DiaChi.Name = "rtb_DiaChi";
            this.rtb_DiaChi.Size = new System.Drawing.Size(338, 68);
            this.rtb_DiaChi.TabIndex = 7;
            this.rtb_DiaChi.Text = "";
            this.rtb_DiaChi.TextChanged += new System.EventHandler(this.rtb_DiaChi_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btn_HienPass
            // 
            this.btn_HienPass.Location = new System.Drawing.Point(502, 67);
            this.btn_HienPass.Name = "btn_HienPass";
            this.btn_HienPass.Size = new System.Drawing.Size(29, 23);
            this.btn_HienPass.TabIndex = 5;
            this.btn_HienPass.Text = "Hiện";
            this.btn_HienPass.Click += new System.EventHandler(this.btn_HienPass_Click);
            // 
            // txt_NhapLaiMatKhau
            // 
            this.txt_NhapLaiMatKhau.Location = new System.Drawing.Point(320, 101);
            this.txt_NhapLaiMatKhau.Name = "txt_NhapLaiMatKhau";
            this.txt_NhapLaiMatKhau.Size = new System.Drawing.Size(176, 21);
            this.txt_NhapLaiMatKhau.TabIndex = 2;
            this.txt_NhapLaiMatKhau.UseSystemPasswordChar = true;
            this.txt_NhapLaiMatKhau.TextChanged += new System.EventHandler(this.txt_MatKhau_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(197, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Nhập lại mật khẩu :";
            // 
            // btn_HienNhapLaiMatKhau
            // 
            this.btn_HienNhapLaiMatKhau.Location = new System.Drawing.Point(502, 99);
            this.btn_HienNhapLaiMatKhau.Name = "btn_HienNhapLaiMatKhau";
            this.btn_HienNhapLaiMatKhau.Size = new System.Drawing.Size(29, 23);
            this.btn_HienNhapLaiMatKhau.TabIndex = 5;
            this.btn_HienNhapLaiMatKhau.Text = "Hiện";
            this.btn_HienNhapLaiMatKhau.Click += new System.EventHandler(this.btn_HienNhapLaiMatKhau_Click);
            // 
            // frm_ThongTinNguoiDung
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(563, 473);
            this.Controls.Add(this.rtb_DiaChi);
            this.Controls.Add(this.btn_ChonHinh);
            this.Controls.Add(this.btn_HienNhapLaiMatKhau);
            this.Controls.Add(this.btn_HienPass);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btn_ThayDoiThongTin);
            this.Controls.Add(this.cbb_PhanQuyen);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_CMND);
            this.Controls.Add(this.txt_TenThat);
            this.Controls.Add(this.txt_HinhAnh);
            this.Controls.Add(this.txt_NhapLaiMatKhau);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.txt_TenDangNhap);
            this.Controls.Add(this.ptb_Avatar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_ThongTinNguoiDung";
            this.Text = "Thông tin người dùng";
            this.Load += new System.EventHandler(this.frm_ThongTinNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_Avatar;
        private System.Windows.Forms.TextBox txt_TenDangNhap;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.TextBox txt_TenThat;
        private System.Windows.Forms.TextBox txt_HinhAnh;
        private System.Windows.Forms.TextBox txt_CMND;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbb_PhanQuyen;
        private DevExpress.XtraEditors.SimpleButton btn_ThayDoiThongTin;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btn_ChonHinh;
        private System.Windows.Forms.RichTextBox rtb_DiaChi;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraEditors.SimpleButton btn_HienPass;
        private DevExpress.XtraEditors.SimpleButton btn_HienNhapLaiMatKhau;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_NhapLaiMatKhau;
    }
}