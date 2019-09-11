using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DataAccess;
using System.Security.Cryptography;
using System.IO;
namespace QLCaPheProject
{
    public partial class frm_Login : DevExpress.XtraEditors.XtraForm
    {

        BaseFunctions<Log> objLog = new BaseFunctions<Log>();
        public frm_Login()
        {
            InitializeComponent();
        }
        private User _User = new User();

        public User User
        {
            get
            {
                return _User;
            }

            set
            {
                _User = value;
            }
        }

        public bool Logged
        {
            get
            {
                return logged;
            }

            set
            {
                logged = value;
            }
        }

        private bool logged;
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Hàm mã hóa mật khẩu lưu xuống database
        private void button_Login_Click(object sender, EventArgs e)
        {

            if (this.textBox_UserName.Text.Length > 0 && this.textBox_PassWord.Text.Length >= 6)
            {
                this.errorProvider1.Clear();
                User User = User.GetUserByUserName(this.textBox_UserName.Text);
                if (User == null)
                    MessageBox.Show("Tài khoản không tồn tại hoặc không kết nối được CSDL , kiểm tra lại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (User.PassWord.CompareTo(Encode.Encrypt(this.textBox_PassWord.Text)) == 0)
                    {
                        if (ckb_LuuMatKhau.Checked)
                        {
                            using (StreamWriter sw = new StreamWriter("Config.ini"))
                            {
                                sw.WriteLine(Encode.Encrypt(this.textBox_UserName.Text) + ";" + Encode.Encrypt(this.textBox_PassWord.Text));
                            }

                        }
                        else
                        {
                            using (StreamWriter sw = new StreamWriter("Config.ini"))
                            {
                                sw.WriteLine(Encode.Encrypt(" ") + ";" + Encode.Encrypt(""));
                            }
                        }
                        Log log = new Log();
                        log.ID = 1;
                        log.Date = DateTime.Now;
                        log.Description = "Đăng nhập";
                        log.UserName = this.textBox_UserName.Text;
                        objLog.Add(log);
                        _User = User;
                        Logged = true;
                        MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.Close();
                    }

                    else
                        MessageBox.Show("Sai mật khẩu , kiểm tra lại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                if (this.textBox_UserName.TextLength == 0)
                    this.errorProvider1.SetError(this.textBox_UserName, "Không bỏ trống trường này");
                if (this.textBox_PassWord.TextLength == 0)
                    this.errorProvider1.SetError(this.textBox_PassWord, "Không bỏ trống trường này");
                else
                     if (this.textBox_PassWord.TextLength < 6)
                    this.errorProvider1.SetError(this.textBox_PassWord, "mật khẩu ít nhất 6 ký tự");


            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_HienMK_Click(object sender, EventArgs e)
        {
            if (this.textBox_PassWord.UseSystemPasswordChar)
            {
                this.textBox_PassWord.UseSystemPasswordChar = false;
                this.btn_HienMK.Text = "Ẩn";
            }

            else
            {
                this.textBox_PassWord.UseSystemPasswordChar = true;
                this.btn_HienMK.Text = "Hiện";
            }
        }
        public void CaiDatThongBao()
        {
            this.lbl_Note.Text = "Phiên đăng nhập hết hạn, vui lòng đăng nhập lại";
        }
        private void frm_Login_Load(object sender, EventArgs e)
        {
            frm_StartForm f = new frm_StartForm();
            f.ShowDialog();
            string line = "";
            using (StreamReader sr = new StreamReader("Config.ini"))
            {
                if ((line = sr.ReadLine()) != null)
                {
                    string[] temp = line.Split(';');
                    this.textBox_UserName.Text =Encode.Decrypt(temp[0]).Trim();
                    this.textBox_PassWord.Text = Encode.Decrypt(temp[1]).Trim();
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string line = "Nếu cần trợ giúp xin hãy liên hệ cho đội ngũ kỹ thuật viên chúng tôi : \n  " +
                "Email :\n\t-nguyenvanvuong972@gmail.com \n" +
                "\t-cao.khanh.1997@gmail.com\n" +
                "\t-thoaixuan97@gmail.com\n" +
                "\t-nguyenhuuson1997it@gmail.com\n\n" +
                "Hotline: 0123.456.7789\n" +
                "Xin trân trọng cảm ơn\n" +
                "D.E.V Team";
            MessageBox.Show(line, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}