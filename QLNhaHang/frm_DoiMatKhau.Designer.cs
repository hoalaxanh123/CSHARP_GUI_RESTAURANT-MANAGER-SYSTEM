namespace QLCaPheProject
{
    partial class frm_DoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DoiMatKhau));
            this.txt_XacNhanMKMoi = new System.Windows.Forms.TextBox();
            this.txt_MatKhauCu = new System.Windows.Forms.TextBox();
            this.txt_MatKhauMoi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_XacNhan = new DevExpress.XtraEditors.SimpleButton();
            this.btn_HuyBo = new DevExpress.XtraEditors.SimpleButton();
            this.btn_HienMatKhauCu = new DevExpress.XtraEditors.SimpleButton();
            this.btn_HienMatKhauMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btn_HienXNMKMoi = new DevExpress.XtraEditors.SimpleButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_XacNhanMKMoi
            // 
            this.txt_XacNhanMKMoi.Location = new System.Drawing.Point(171, 144);
            this.txt_XacNhanMKMoi.Name = "txt_XacNhanMKMoi";
            this.txt_XacNhanMKMoi.Size = new System.Drawing.Size(155, 21);
            this.txt_XacNhanMKMoi.TabIndex = 4;
            this.txt_XacNhanMKMoi.UseSystemPasswordChar = true;
            this.txt_XacNhanMKMoi.TextChanged += new System.EventHandler(this.txt_XacNhanMKMoi_TextChanged);
            // 
            // txt_MatKhauCu
            // 
            this.txt_MatKhauCu.Location = new System.Drawing.Point(171, 48);
            this.txt_MatKhauCu.Name = "txt_MatKhauCu";
            this.txt_MatKhauCu.Size = new System.Drawing.Size(155, 21);
            this.txt_MatKhauCu.TabIndex = 0;
            this.txt_MatKhauCu.UseSystemPasswordChar = true;
            this.txt_MatKhauCu.TextChanged += new System.EventHandler(this.txt_MatKhauCu_TextChanged);
            // 
            // txt_MatKhauMoi
            // 
            this.txt_MatKhauMoi.Location = new System.Drawing.Point(171, 96);
            this.txt_MatKhauMoi.Name = "txt_MatKhauMoi";
            this.txt_MatKhauMoi.Size = new System.Drawing.Size(155, 21);
            this.txt_MatKhauMoi.TabIndex = 2;
            this.txt_MatKhauMoi.UseSystemPasswordChar = true;
            this.txt_MatKhauMoi.TextChanged += new System.EventHandler(this.txt_MatKhauMoi_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chartreuse;
            this.label1.Location = new System.Drawing.Point(26, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mật khẩu cũ : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Chartreuse;
            this.label2.Location = new System.Drawing.Point(26, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu mới :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Chartreuse;
            this.label3.Location = new System.Drawing.Point(26, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "Xác nhận mật khẩu mới";
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.Location = new System.Drawing.Point(100, 186);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(75, 23);
            this.btn_XacNhan.TabIndex = 6;
            this.btn_XacNhan.Text = "Xác nhận";
            this.btn_XacNhan.Click += new System.EventHandler(this.btn_XacNhan_Click);
            // 
            // btn_HuyBo
            // 
            this.btn_HuyBo.Location = new System.Drawing.Point(212, 186);
            this.btn_HuyBo.Name = "btn_HuyBo";
            this.btn_HuyBo.Size = new System.Drawing.Size(75, 23);
            this.btn_HuyBo.TabIndex = 7;
            this.btn_HuyBo.Text = "Hủy bỏ";
            this.btn_HuyBo.Click += new System.EventHandler(this.btn_HuyBo_Click);
            // 
            // btn_HienMatKhauCu
            // 
            this.btn_HienMatKhauCu.Location = new System.Drawing.Point(343, 48);
            this.btn_HienMatKhauCu.Name = "btn_HienMatKhauCu";
            this.btn_HienMatKhauCu.Size = new System.Drawing.Size(29, 23);
            this.btn_HienMatKhauCu.TabIndex = 1;
            this.btn_HienMatKhauCu.Text = "Hiện";
            this.btn_HienMatKhauCu.Click += new System.EventHandler(this.btn_HienMatKhauCu_Click);
            // 
            // btn_HienMatKhauMoi
            // 
            this.btn_HienMatKhauMoi.Location = new System.Drawing.Point(343, 96);
            this.btn_HienMatKhauMoi.Name = "btn_HienMatKhauMoi";
            this.btn_HienMatKhauMoi.Size = new System.Drawing.Size(29, 23);
            this.btn_HienMatKhauMoi.TabIndex = 3;
            this.btn_HienMatKhauMoi.Text = "Hiện";
            this.btn_HienMatKhauMoi.Click += new System.EventHandler(this.btn_HienMatKhauMoi_Click);
            // 
            // btn_HienXNMKMoi
            // 
            this.btn_HienXNMKMoi.Location = new System.Drawing.Point(343, 144);
            this.btn_HienXNMKMoi.Name = "btn_HienXNMKMoi";
            this.btn_HienXNMKMoi.Size = new System.Drawing.Size(29, 23);
            this.btn_HienXNMKMoi.TabIndex = 5;
            this.btn_HienXNMKMoi.Text = "Hiện";
            this.btn_HienXNMKMoi.Click += new System.EventHandler(this.btn_HienXNMKMoi_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.LawnGreen;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(123, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Đổi mật khẩu";
            // 
            // frm_DoiMatKhau
            // 
            this.AcceptButton = this.btn_XacNhan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(388, 228);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_HienXNMKMoi);
            this.Controls.Add(this.btn_HienMatKhauMoi);
            this.Controls.Add(this.btn_HienMatKhauCu);
            this.Controls.Add(this.btn_HuyBo);
            this.Controls.Add(this.btn_XacNhan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_MatKhauMoi);
            this.Controls.Add(this.txt_MatKhauCu);
            this.Controls.Add(this.txt_XacNhanMKMoi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_DoiMatKhau";
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.frm_DoiMatKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_XacNhanMKMoi;
        private System.Windows.Forms.TextBox txt_MatKhauCu;
        private System.Windows.Forms.TextBox txt_MatKhauMoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btn_XacNhan;
        private DevExpress.XtraEditors.SimpleButton btn_HuyBo;
        private DevExpress.XtraEditors.SimpleButton btn_HienMatKhauCu;
        private DevExpress.XtraEditors.SimpleButton btn_HienMatKhauMoi;
        private DevExpress.XtraEditors.SimpleButton btn_HienXNMKMoi;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label4;
    }
}