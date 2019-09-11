namespace QLCaPheProject
{
    partial class frm_QuanLyGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QuanLyGia));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Thoat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ThemMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btn_LoadLai = new DevExpress.XtraEditors.SimpleButton();
            this.btn_XoaTrang = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_XacNhan = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_NgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtp_NgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_GiaTien = new DevExpress.XtraEditors.TextEdit();
            this.txt_ID = new DevExpress.XtraEditors.TextEdit();
            this.txt_TenMon = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GiaTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenMon.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_Thoat);
            this.groupBox1.Controls.Add(this.btn_ThemMoi);
            this.groupBox1.Controls.Add(this.btn_LoadLai);
            this.groupBox1.Controls.Add(this.btn_XoaTrang);
            this.groupBox1.Controls.Add(this.btn_Xoa);
            this.groupBox1.Controls.Add(this.btn_XacNhan);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txt_GiaTien);
            this.groupBox1.Controls.Add(this.txt_ID);
            this.groupBox1.Controls.Add(this.txt_TenMon);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 393);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(205, 336);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(62, 23);
            this.btn_Thoat.TabIndex = 8;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_ThemMoi
            // 
            this.btn_ThemMoi.Location = new System.Drawing.Point(26, 336);
            this.btn_ThemMoi.Name = "btn_ThemMoi";
            this.btn_ThemMoi.Size = new System.Drawing.Size(62, 23);
            this.btn_ThemMoi.TabIndex = 6;
            this.btn_ThemMoi.Text = "Thêm mới";
            this.btn_ThemMoi.Click += new System.EventHandler(this.btn_ThemMoi_Click);
            // 
            // btn_LoadLai
            // 
            this.btn_LoadLai.Location = new System.Drawing.Point(113, 336);
            this.btn_LoadLai.Name = "btn_LoadLai";
            this.btn_LoadLai.Size = new System.Drawing.Size(62, 23);
            this.btn_LoadLai.TabIndex = 7;
            this.btn_LoadLai.Text = "Load lại";
            this.btn_LoadLai.Click += new System.EventHandler(this.btn_LoadLai_Click);
            // 
            // btn_XoaTrang
            // 
            this.btn_XoaTrang.Location = new System.Drawing.Point(205, 283);
            this.btn_XoaTrang.Name = "btn_XoaTrang";
            this.btn_XoaTrang.Size = new System.Drawing.Size(62, 23);
            this.btn_XoaTrang.TabIndex = 5;
            this.btn_XoaTrang.Text = "Xóa trắng";
            this.btn_XoaTrang.Click += new System.EventHandler(this.btn_XoaTrang_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(113, 283);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(62, 23);
            this.btn_Xoa.TabIndex = 4;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.Location = new System.Drawing.Point(26, 283);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(62, 23);
            this.btn_XacNhan.TabIndex = 3;
            this.btn_XacNhan.Text = "Xác nhận";
            this.btn_XacNhan.Click += new System.EventHandler(this.btn_XacNhan_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dtp_NgayKetThuc);
            this.groupBox2.Controls.Add(this.dtp_NgayBatDau);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(14, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 107);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ngày áp dụng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày bắt đầu : ";
            // 
            // dtp_NgayKetThuc
            // 
            this.dtp_NgayKetThuc.CustomFormat = "HH:mm dd/MM/yyyy";
            this.dtp_NgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayKetThuc.Location = new System.Drawing.Point(125, 64);
            this.dtp_NgayKetThuc.Name = "dtp_NgayKetThuc";
            this.dtp_NgayKetThuc.Size = new System.Drawing.Size(141, 21);
            this.dtp_NgayKetThuc.TabIndex = 1;
            this.dtp_NgayKetThuc.ValueChanged += new System.EventHandler(this.dtp_NgayKetThuc_ValueChanged);
            // 
            // dtp_NgayBatDau
            // 
            this.dtp_NgayBatDau.CustomFormat = "HH:mm dd/MM/yyyy";
            this.dtp_NgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayBatDau.Location = new System.Drawing.Point(125, 17);
            this.dtp_NgayBatDau.Name = "dtp_NgayBatDau";
            this.dtp_NgayBatDau.Size = new System.Drawing.Size(141, 21);
            this.dtp_NgayBatDau.TabIndex = 0;
            this.dtp_NgayBatDau.ValueChanged += new System.EventHandler(this.dtp_NgayBatDau_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày kết thúc";
            // 
            // txt_GiaTien
            // 
            this.txt_GiaTien.Location = new System.Drawing.Point(88, 76);
            this.txt_GiaTien.Name = "txt_GiaTien";
            this.txt_GiaTien.Size = new System.Drawing.Size(136, 20);
            this.txt_GiaTien.TabIndex = 2;
            // 
            // txt_ID
            // 
            this.txt_ID.Enabled = false;
            this.txt_ID.Location = new System.Drawing.Point(88, 14);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(71, 20);
            this.txt_ID.TabIndex = 0;
            // 
            // txt_TenMon
            // 
            this.txt_TenMon.Enabled = false;
            this.txt_TenMon.Location = new System.Drawing.Point(88, 45);
            this.txt_TenMon.Name = "txt_TenMon";
            this.txt_TenMon.Size = new System.Drawing.Size(179, 20);
            this.txt_TenMon.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Giá tiền : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên món :";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(339, 24);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(369, 381);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 27;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Giá  tiền";
            this.columnHeader2.Width = 145;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày áp dụng";
            this.columnHeader3.Width = 93;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày kết thúc";
            this.columnHeader4.Width = 100;
            // 
            // frm_QuanLyGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(720, 445);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_QuanLyGia";
            this.Text = "Cài đặt giá món";
            this.Load += new System.EventHandler(this.frm_QuanLyGia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GiaTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenMon.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txt_TenMon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtp_NgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtp_NgayBatDau;
        private DevExpress.XtraEditors.TextEdit txt_GiaTien;
        private DevExpress.XtraEditors.SimpleButton btn_Thoat;
        private DevExpress.XtraEditors.SimpleButton btn_LoadLai;
        private DevExpress.XtraEditors.SimpleButton btn_XoaTrang;
        private DevExpress.XtraEditors.SimpleButton btn_Xoa;
        private DevExpress.XtraEditors.SimpleButton btn_XacNhan;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private DevExpress.XtraEditors.TextEdit txt_ID;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton btn_ThemMoi;
    }
}