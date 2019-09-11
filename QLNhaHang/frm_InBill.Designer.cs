namespace QLCaPheProject
{
    partial class frm_InBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_InBill));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox_PhamVi = new System.Windows.Forms.GroupBox();
            this.btn_ApDung = new DevExpress.XtraEditors.SimpleButton();
            this.checkBox_LuuThietLap = new System.Windows.Forms.CheckBox();
            this.comboBox_LoaiMon = new System.Windows.Forms.ComboBox();
            this.rbtn_GiamTheoLoai = new System.Windows.Forms.RadioButton();
            this.rbtn_CacMonDuocChon = new System.Windows.Forms.RadioButton();
            this.rbtn_ToanBo = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_Giam = new System.Windows.Forms.TextBox();
            this.lb_Status = new System.Windows.Forms.Label();
            this.rbtn_GiamTheoPhanTram = new System.Windows.Forms.RadioButton();
            this.rbtn_GiamTheoSoTien = new System.Windows.Forms.RadioButton();
            this.listView_CacMonDaGoi = new System.Windows.Forms.ListView();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TienChuaGiam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GiamGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TienSauGiam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_InBill = new DevExpress.XtraEditors.SimpleButton();
            this.btn_HuyBo = new DevExpress.XtraEditors.SimpleButton();
            this.lb_TongTien = new System.Windows.Forms.Label();
            this.btn_ThanhToan = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            this.groupBox_PhamVi.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.groupBox_PhamVi);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 166);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn kiểu giảm giá";
            // 
            // groupBox_PhamVi
            // 
            this.groupBox_PhamVi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox_PhamVi.BackgroundImage")));
            this.groupBox_PhamVi.Controls.Add(this.btn_ApDung);
            this.groupBox_PhamVi.Controls.Add(this.checkBox_LuuThietLap);
            this.groupBox_PhamVi.Controls.Add(this.comboBox_LoaiMon);
            this.groupBox_PhamVi.Controls.Add(this.rbtn_GiamTheoLoai);
            this.groupBox_PhamVi.Controls.Add(this.rbtn_CacMonDuocChon);
            this.groupBox_PhamVi.Controls.Add(this.rbtn_ToanBo);
            this.groupBox_PhamVi.ForeColor = System.Drawing.Color.White;
            this.groupBox_PhamVi.Location = new System.Drawing.Point(264, 20);
            this.groupBox_PhamVi.Name = "groupBox_PhamVi";
            this.groupBox_PhamVi.Size = new System.Drawing.Size(355, 120);
            this.groupBox_PhamVi.TabIndex = 0;
            this.groupBox_PhamVi.TabStop = false;
            this.groupBox_PhamVi.Text = "Phạm vi áp dụng";
            // 
            // btn_ApDung
            // 
            this.btn_ApDung.Location = new System.Drawing.Point(251, 42);
            this.btn_ApDung.Name = "btn_ApDung";
            this.btn_ApDung.Size = new System.Drawing.Size(75, 67);
            this.btn_ApDung.TabIndex = 5;
            this.btn_ApDung.Text = "Áp dụng";
            this.btn_ApDung.Click += new System.EventHandler(this.btn_ApDung_Click);
            // 
            // checkBox_LuuThietLap
            // 
            this.checkBox_LuuThietLap.AutoSize = true;
            this.checkBox_LuuThietLap.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_LuuThietLap.ForeColor = System.Drawing.Color.White;
            this.checkBox_LuuThietLap.Location = new System.Drawing.Point(251, 20);
            this.checkBox_LuuThietLap.Name = "checkBox_LuuThietLap";
            this.checkBox_LuuThietLap.Size = new System.Drawing.Size(88, 17);
            this.checkBox_LuuThietLap.TabIndex = 4;
            this.checkBox_LuuThietLap.Text = "Lưu thiết đặt";
            this.checkBox_LuuThietLap.UseVisualStyleBackColor = false;
            // 
            // comboBox_LoaiMon
            // 
            this.comboBox_LoaiMon.FormattingEnabled = true;
            this.comboBox_LoaiMon.Location = new System.Drawing.Point(27, 90);
            this.comboBox_LoaiMon.Name = "comboBox_LoaiMon";
            this.comboBox_LoaiMon.Size = new System.Drawing.Size(135, 21);
            this.comboBox_LoaiMon.TabIndex = 3;
            // 
            // rbtn_GiamTheoLoai
            // 
            this.rbtn_GiamTheoLoai.AutoSize = true;
            this.rbtn_GiamTheoLoai.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_GiamTheoLoai.ForeColor = System.Drawing.Color.White;
            this.rbtn_GiamTheoLoai.Location = new System.Drawing.Point(6, 67);
            this.rbtn_GiamTheoLoai.Name = "rbtn_GiamTheoLoai";
            this.rbtn_GiamTheoLoai.Size = new System.Drawing.Size(122, 17);
            this.rbtn_GiamTheoLoai.TabIndex = 2;
            this.rbtn_GiamTheoLoai.TabStop = true;
            this.rbtn_GiamTheoLoai.Text = "Các món thuộc loại :";
            this.rbtn_GiamTheoLoai.UseVisualStyleBackColor = false;
            // 
            // rbtn_CacMonDuocChon
            // 
            this.rbtn_CacMonDuocChon.AutoSize = true;
            this.rbtn_CacMonDuocChon.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_CacMonDuocChon.ForeColor = System.Drawing.Color.White;
            this.rbtn_CacMonDuocChon.Location = new System.Drawing.Point(6, 44);
            this.rbtn_CacMonDuocChon.Name = "rbtn_CacMonDuocChon";
            this.rbtn_CacMonDuocChon.Size = new System.Drawing.Size(119, 17);
            this.rbtn_CacMonDuocChon.TabIndex = 1;
            this.rbtn_CacMonDuocChon.TabStop = true;
            this.rbtn_CacMonDuocChon.Text = "Các món được chọn";
            this.rbtn_CacMonDuocChon.UseVisualStyleBackColor = false;
            // 
            // rbtn_ToanBo
            // 
            this.rbtn_ToanBo.AutoSize = true;
            this.rbtn_ToanBo.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_ToanBo.ForeColor = System.Drawing.Color.White;
            this.rbtn_ToanBo.Location = new System.Drawing.Point(6, 21);
            this.rbtn_ToanBo.Name = "rbtn_ToanBo";
            this.rbtn_ToanBo.Size = new System.Drawing.Size(106, 17);
            this.rbtn_ToanBo.TabIndex = 0;
            this.rbtn_ToanBo.TabStop = true;
            this.rbtn_ToanBo.Text = "Toàn bộ các món";
            this.rbtn_ToanBo.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.textBox_Giam);
            this.groupBox2.Controls.Add(this.lb_Status);
            this.groupBox2.Controls.Add(this.rbtn_GiamTheoPhanTram);
            this.groupBox2.Controls.Add(this.rbtn_GiamTheoSoTien);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(10, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 120);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giảm theo : ";
            // 
            // textBox_Giam
            // 
            this.textBox_Giam.Location = new System.Drawing.Point(9, 90);
            this.textBox_Giam.Name = "textBox_Giam";
            this.textBox_Giam.Size = new System.Drawing.Size(177, 21);
            this.textBox_Giam.TabIndex = 3;
            this.textBox_Giam.Enter += new System.EventHandler(this.textBox_Giam_Enter);
            this.textBox_Giam.Leave += new System.EventHandler(this.textBox_Giam_Leave);
            // 
            // lb_Status
            // 
            this.lb_Status.AutoSize = true;
            this.lb_Status.BackColor = System.Drawing.Color.Transparent;
            this.lb_Status.ForeColor = System.Drawing.Color.White;
            this.lb_Status.Location = new System.Drawing.Point(6, 54);
            this.lb_Status.Name = "lb_Status";
            this.lb_Status.Size = new System.Drawing.Size(69, 13);
            this.lb_Status.TabIndex = 2;
            this.lb_Status.Text = "Nhập  vào  : ";
            // 
            // rbtn_GiamTheoPhanTram
            // 
            this.rbtn_GiamTheoPhanTram.AutoSize = true;
            this.rbtn_GiamTheoPhanTram.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_GiamTheoPhanTram.ForeColor = System.Drawing.Color.White;
            this.rbtn_GiamTheoPhanTram.Location = new System.Drawing.Point(112, 21);
            this.rbtn_GiamTheoPhanTram.Name = "rbtn_GiamTheoPhanTram";
            this.rbtn_GiamTheoPhanTram.Size = new System.Drawing.Size(74, 17);
            this.rbtn_GiamTheoPhanTram.TabIndex = 1;
            this.rbtn_GiamTheoPhanTram.TabStop = true;
            this.rbtn_GiamTheoPhanTram.Text = "Phần trăm";
            this.rbtn_GiamTheoPhanTram.UseVisualStyleBackColor = false;
            this.rbtn_GiamTheoPhanTram.CheckedChanged += new System.EventHandler(this.rbtn_GiamTheoPhanTram_CheckedChanged);
            // 
            // rbtn_GiamTheoSoTien
            // 
            this.rbtn_GiamTheoSoTien.AutoSize = true;
            this.rbtn_GiamTheoSoTien.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_GiamTheoSoTien.ForeColor = System.Drawing.Color.White;
            this.rbtn_GiamTheoSoTien.Location = new System.Drawing.Point(7, 21);
            this.rbtn_GiamTheoSoTien.Name = "rbtn_GiamTheoSoTien";
            this.rbtn_GiamTheoSoTien.Size = new System.Drawing.Size(58, 17);
            this.rbtn_GiamTheoSoTien.TabIndex = 0;
            this.rbtn_GiamTheoSoTien.TabStop = true;
            this.rbtn_GiamTheoSoTien.Text = "Số tiền";
            this.rbtn_GiamTheoSoTien.UseVisualStyleBackColor = false;
            this.rbtn_GiamTheoSoTien.CheckedChanged += new System.EventHandler(this.rbtn_GiamTheoSoTien_CheckedChanged);
            // 
            // listView_CacMonDaGoi
            // 
            this.listView_CacMonDaGoi.CheckBoxes = true;
            this.listView_CacMonDaGoi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.Ten,
            this.SoLuong,
            this.gia,
            this.TienChuaGiam,
            this.GiamGia,
            this.TienSauGiam,
            this.MaSP,
            this.ID});
            this.listView_CacMonDaGoi.FullRowSelect = true;
            this.listView_CacMonDaGoi.GridLines = true;
            this.listView_CacMonDaGoi.Location = new System.Drawing.Point(12, 203);
            this.listView_CacMonDaGoi.MultiSelect = false;
            this.listView_CacMonDaGoi.Name = "listView_CacMonDaGoi";
            this.listView_CacMonDaGoi.Size = new System.Drawing.Size(648, 195);
            this.listView_CacMonDaGoi.TabIndex = 0;
            this.listView_CacMonDaGoi.UseCompatibleStateImageBehavior = false;
            this.listView_CacMonDaGoi.View = System.Windows.Forms.View.Details;
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 38;
            // 
            // Ten
            // 
            this.Ten.Text = "Tên";
            this.Ten.Width = 130;
            // 
            // SoLuong
            // 
            this.SoLuong.Text = "SL";
            this.SoLuong.Width = 45;
            // 
            // gia
            // 
            this.gia.Text = "Giá 1 sản phẩm";
            this.gia.Width = 119;
            // 
            // TienChuaGiam
            // 
            this.TienChuaGiam.Text = "Tổng Tiền";
            this.TienChuaGiam.Width = 114;
            // 
            // GiamGia
            // 
            this.GiamGia.Text = "Giảm giá ";
            this.GiamGia.Width = 104;
            // 
            // TienSauGiam
            // 
            this.TienSauGiam.Text = "Thành tiền ";
            this.TienSauGiam.Width = 94;
            // 
            // MaSP
            // 
            this.MaSP.Text = "Mã SP";
            this.MaSP.Width = 0;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 0;
            // 
            // btn_InBill
            // 
            this.btn_InBill.Location = new System.Drawing.Point(175, 423);
            this.btn_InBill.Name = "btn_InBill";
            this.btn_InBill.Size = new System.Drawing.Size(75, 23);
            this.btn_InBill.TabIndex = 1;
            this.btn_InBill.Text = "In bill";
            this.btn_InBill.Click += new System.EventHandler(this.btn_InBill_Click);
            // 
            // btn_HuyBo
            // 
            this.btn_HuyBo.Location = new System.Drawing.Point(423, 423);
            this.btn_HuyBo.Name = "btn_HuyBo";
            this.btn_HuyBo.Size = new System.Drawing.Size(75, 23);
            this.btn_HuyBo.TabIndex = 3;
            this.btn_HuyBo.Text = "Hủy bỏ";
            this.btn_HuyBo.Click += new System.EventHandler(this.btn_HuyBo_Click);
            // 
            // lb_TongTien
            // 
            this.lb_TongTien.AutoSize = true;
            this.lb_TongTien.Location = new System.Drawing.Point(12, 185);
            this.lb_TongTien.Name = "lb_TongTien";
            this.lb_TongTien.Size = new System.Drawing.Size(0, 13);
            this.lb_TongTien.TabIndex = 4;
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.Location = new System.Drawing.Point(303, 423);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(75, 23);
            this.btn_ThanhToan.TabIndex = 2;
            this.btn_ThanhToan.Text = "Thanh toán";
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // frm_InBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(689, 472);
            this.Controls.Add(this.btn_ThanhToan);
            this.Controls.Add(this.lb_TongTien);
            this.Controls.Add(this.btn_HuyBo);
            this.Controls.Add(this.btn_InBill);
            this.Controls.Add(this.listView_CacMonDaGoi);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_InBill";
            this.Text = "Xuất bill";
            this.Load += new System.EventHandler(this.frm_InBill_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox_PhamVi.ResumeLayout(false);
            this.groupBox_PhamVi.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox_PhamVi;
        private System.Windows.Forms.RadioButton rbtn_CacMonDuocChon;
        private System.Windows.Forms.RadioButton rbtn_ToanBo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb_Status;
        private System.Windows.Forms.RadioButton rbtn_GiamTheoPhanTram;
        private System.Windows.Forms.RadioButton rbtn_GiamTheoSoTien;
        private DevExpress.XtraEditors.SimpleButton btn_ApDung;
        private System.Windows.Forms.CheckBox checkBox_LuuThietLap;
        private System.Windows.Forms.ListView listView_CacMonDaGoi;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader Ten;
        private System.Windows.Forms.ColumnHeader SoLuong;
        private System.Windows.Forms.ColumnHeader gia;
        private System.Windows.Forms.ColumnHeader GiamGia;
        private System.Windows.Forms.ColumnHeader TienChuaGiam;
        private System.Windows.Forms.ColumnHeader MaSP;
        private System.Windows.Forms.ColumnHeader ID;
        private DevExpress.XtraEditors.SimpleButton btn_InBill;
        private DevExpress.XtraEditors.SimpleButton btn_HuyBo;
        private System.Windows.Forms.TextBox textBox_Giam;
        private System.Windows.Forms.ColumnHeader TienSauGiam;
        private System.Windows.Forms.ComboBox comboBox_LoaiMon;
        private System.Windows.Forms.RadioButton rbtn_GiamTheoLoai;
        private System.Windows.Forms.Label lb_TongTien;
        private DevExpress.XtraEditors.SimpleButton btn_ThanhToan;
    }
}