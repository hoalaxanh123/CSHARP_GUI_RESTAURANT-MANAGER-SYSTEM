namespace QLCaPheProject
{
    partial class frm_Log
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Log));
            this.btn_Reload = new DevExpress.XtraEditors.SimpleButton();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.listView_Log = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_NgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_NgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_LocTheoMocThoiGian = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_xoaNhatKyHeThong = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Reload
            // 
            this.btn_Reload.Location = new System.Drawing.Point(565, 147);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(75, 23);
            this.btn_Reload.TabIndex = 9;
            this.btn_Reload.Text = "ReLoad";
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Status.ForeColor = System.Drawing.Color.White;
            this.lbl_Status.Location = new System.Drawing.Point(9, 147);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(83, 13);
            this.lbl_Status.TabIndex = 7;
            this.lbl_Status.Text = "Tổng nhật ký  : ";
            // 
            // listView_Log
            // 
            this.listView_Log.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView_Log.FullRowSelect = true;
            this.listView_Log.GridLines = true;
            this.listView_Log.Location = new System.Drawing.Point(9, 180);
            this.listView_Log.MultiSelect = false;
            this.listView_Log.Name = "listView_Log";
            this.listView_Log.Size = new System.Drawing.Size(631, 415);
            this.listView_Log.TabIndex = 6;
            this.listView_Log.UseCompatibleStateImageBehavior = false;
            this.listView_Log.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 74;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên đăng nhập";
            this.columnHeader2.Width = 118;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mốc thời gian";
            this.columnHeader3.Width = 132;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mô tả ";
            this.columnHeader4.Width = 300;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.dateTimePicker_NgayKetThuc);
            this.groupBox2.Controls.Add(this.dateTimePicker_NgayBatDau);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btn_LocTheoMocThoiGian);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(628, 86);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lọc theo thời gian";
            // 
            // dateTimePicker_NgayKetThuc
            // 
            this.dateTimePicker_NgayKetThuc.Location = new System.Drawing.Point(326, 36);
            this.dateTimePicker_NgayKetThuc.Name = "dateTimePicker_NgayKetThuc";
            this.dateTimePicker_NgayKetThuc.Size = new System.Drawing.Size(159, 21);
            this.dateTimePicker_NgayKetThuc.TabIndex = 6;
            this.dateTimePicker_NgayKetThuc.ValueChanged += new System.EventHandler(this.dateTimePicker_NgayBatDau_ValueChanged);
            // 
            // dateTimePicker_NgayBatDau
            // 
            this.dateTimePicker_NgayBatDau.Location = new System.Drawing.Point(102, 38);
            this.dateTimePicker_NgayBatDau.Name = "dateTimePicker_NgayBatDau";
            this.dateTimePicker_NgayBatDau.Size = new System.Drawing.Size(159, 21);
            this.dateTimePicker_NgayBatDau.TabIndex = 6;
            this.dateTimePicker_NgayBatDau.ValueChanged += new System.EventHandler(this.dateTimePicker_NgayBatDau_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(280, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tới  : ";
            // 
            // btn_LocTheoMocThoiGian
            // 
            this.btn_LocTheoMocThoiGian.Location = new System.Drawing.Point(511, 36);
            this.btn_LocTheoMocThoiGian.Name = "btn_LocTheoMocThoiGian";
            this.btn_LocTheoMocThoiGian.Size = new System.Drawing.Size(75, 23);
            this.btn_LocTheoMocThoiGian.TabIndex = 5;
            this.btn_LocTheoMocThoiGian.Text = "Lọc";
            this.btn_LocTheoMocThoiGian.Click += new System.EventHandler(this.btn_LocTheoMocThoiGian_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bắt đầu từ  : ";
            // 
            // btn_xoaNhatKyHeThong
            // 
            this.btn_xoaNhatKyHeThong.Location = new System.Drawing.Point(484, 147);
            this.btn_xoaNhatKyHeThong.Name = "btn_xoaNhatKyHeThong";
            this.btn_xoaNhatKyHeThong.Size = new System.Drawing.Size(75, 23);
            this.btn_xoaNhatKyHeThong.TabIndex = 9;
            this.btn_xoaNhatKyHeThong.Text = "Xóa nhật ký";
            this.btn_xoaNhatKyHeThong.Click += new System.EventHandler(this.btn_xoaNhatKyHeThong_Click);
            // 
            // frm_Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(665, 607);
            this.Controls.Add(this.btn_xoaNhatKyHeThong);
            this.Controls.Add(this.btn_Reload);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.listView_Log);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Log";
            this.Text = "Kiểm soát hệ thống";
            this.Load += new System.EventHandler(this.frm_Log_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_Reload;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.ListView listView_Log;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgayKetThuc;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgayBatDau;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btn_LocTheoMocThoiGian;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btn_xoaNhatKyHeThong;
    }
}