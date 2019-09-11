namespace QLCaPheProject
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.button_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.button_Login = new DevExpress.XtraEditors.SimpleButton();
            this.textBox_PassWord = new System.Windows.Forms.TextBox();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_HienMK = new DevExpress.XtraEditors.SimpleButton();
            this.ckb_LuuMatKhau = new System.Windows.Forms.CheckBox();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Cancel
            // 
            this.button_Cancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_Cancel.Location = new System.Drawing.Point(212, 164);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 3;
            this.button_Cancel.Text = "Thoát";
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Login
            // 
            this.button_Login.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_Login.Location = new System.Drawing.Point(90, 164);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(75, 23);
            this.button_Login.TabIndex = 2;
            this.button_Login.Text = "Đăng nhập";
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // textBox_PassWord
            // 
            this.textBox_PassWord.Location = new System.Drawing.Point(168, 106);
            this.textBox_PassWord.Name = "textBox_PassWord";
            this.textBox_PassWord.Size = new System.Drawing.Size(147, 21);
            this.textBox_PassWord.TabIndex = 1;
            this.textBox_PassWord.Text = "123456";
            this.textBox_PassWord.UseSystemPasswordChar = true;
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Location = new System.Drawing.Point(168, 71);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(189, 21);
            this.textBox_UserName.TabIndex = 0;
            this.textBox_UserName.Text = "admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label2.ForeColor = System.Drawing.Color.Chartreuse;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(102, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label1.ForeColor = System.Drawing.Color.Chartreuse;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(68, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 14);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tên đăng nhập";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.LawnGreen;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(78, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Đăng nhập hệ thống";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(359, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(19, 21);
            this.button1.TabIndex = 14;
            this.button1.Text = "X";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_HienMK
            // 
            this.btn_HienMK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_HienMK.Location = new System.Drawing.Point(321, 104);
            this.btn_HienMK.Name = "btn_HienMK";
            this.btn_HienMK.Size = new System.Drawing.Size(36, 23);
            this.btn_HienMK.TabIndex = 12;
            this.btn_HienMK.Text = "Hiện";
            this.btn_HienMK.Click += new System.EventHandler(this.btn_HienMK_Click);
            // 
            // ckb_LuuMatKhau
            // 
            this.ckb_LuuMatKhau.AutoSize = true;
            this.ckb_LuuMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.ckb_LuuMatKhau.Checked = true;
            this.ckb_LuuMatKhau.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_LuuMatKhau.ForeColor = System.Drawing.Color.Lime;
            this.ckb_LuuMatKhau.Location = new System.Drawing.Point(168, 134);
            this.ckb_LuuMatKhau.Name = "ckb_LuuMatKhau";
            this.ckb_LuuMatKhau.Size = new System.Drawing.Size(91, 17);
            this.ckb_LuuMatKhau.TabIndex = 16;
            this.ckb_LuuMatKhau.Text = "Lưu mật khẩu";
            this.ckb_LuuMatKhau.UseVisualStyleBackColor = false;
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Note.Location = new System.Drawing.Point(84, 164);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(0, 13);
            this.lbl_Note.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(12, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.ForeColor = System.Drawing.Color.White;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(328, 196);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(54, 13);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Trợ giúp ?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frm_Login
            // 
            this.AcceptButton = this.button_Login;
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(394, 218);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lbl_Note);
            this.Controls.Add(this.ckb_LuuMatKhau);
            this.Controls.Add(this.btn_HienMK);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.textBox_PassWord);
            this.Controls.Add(this.textBox_UserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Login";
            this.Load += new System.EventHandler(this.frm_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton button_Cancel;
        private DevExpress.XtraEditors.SimpleButton button_Login;
        private System.Windows.Forms.TextBox textBox_PassWord;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton btn_HienMK;
        private System.Windows.Forms.CheckBox ckb_LuuMatKhau;
        private System.Windows.Forms.Label lbl_Note;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}