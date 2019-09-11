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

namespace QLCaPheProject
{
    public partial class frm_DoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        User tempUser = new User();
        public frm_DoiMatKhau()
        {
            InitializeComponent();
        }
        BaseFunctions<User> objUser = new BaseFunctions<User>();
        private void frm_DoiMatKhau_Load(object sender, EventArgs e)
        {

        }
        public void KiemTraDoiMatKhau()
        {

        }
        private string userName = "";

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }
        
        private void btn_HienMatKhauCu_Click(object sender, EventArgs e)
        {
            if(this.txt_MatKhauCu.UseSystemPasswordChar)
            {
                this.txt_MatKhauCu.UseSystemPasswordChar = false;
                this.btn_HienMatKhauCu.Text = "Ẩn";
            }
                
            else
            {
                this.txt_MatKhauCu.UseSystemPasswordChar = true;
                this.btn_HienMatKhauCu.Text = "Hiện";
            }
        }

        private void txt_MatKhauCu_TextChanged(object sender, EventArgs e)
        {
            Check(this.txt_MatKhauCu);
        }

        private void txt_MatKhauMoi_TextChanged(object sender, EventArgs e)
        {
            Check(this.txt_MatKhauMoi);
        }

        private void txt_XacNhanMKMoi_TextChanged(object sender, EventArgs e)
        {
            Check(this.txt_XacNhanMKMoi);
              
        }
        private void Check(TextBox txt)
        {
            if (txt.TextLength <6)
                errorProvider1.SetError(txt, "Vui lòng nhập đủ 6 ký tự");
            else
                this.errorProvider1.Clear();
        }

        private void btn_HuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_HienMatKhauMoi_Click(object sender, EventArgs e)
        {
            if (this.txt_MatKhauMoi.UseSystemPasswordChar)
            {
                this.txt_MatKhauMoi.UseSystemPasswordChar = false;
                this.btn_HienMatKhauMoi.Text = "Ẩn";
            }

            else
            {
                this.txt_MatKhauMoi.UseSystemPasswordChar = true;
                this.btn_HienMatKhauMoi.Text = "Hiện";
            }
        }

        private void btn_HienXNMKMoi_Click(object sender, EventArgs e)
        {
            if (this.txt_XacNhanMKMoi.UseSystemPasswordChar)
            {
                this.txt_XacNhanMKMoi.UseSystemPasswordChar = false;
                this.btn_HienXNMKMoi.Text = "Ẩn";
            }

            else
            {
                this.txt_XacNhanMKMoi.UseSystemPasswordChar = true;
                this.btn_HienXNMKMoi.Text = "Hiện";
            }
        }
        private bool KiemTraMatKhauCu()
        {
            tempUser = User.GetUserByUserName(UserName);
            if (tempUser.PassWord ==Encode.Encrypt( this.txt_MatKhauCu.Text))
                return true;
            else
                return false;
        }
       
        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            //Trường hợp mật khẩu cũ không đúng
            if(!KiemTraMatKhauCu())
            {
                MessageBox.Show("Mật khẩu cũ không đúng , vui lòng kiểm tra lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(this.txt_MatKhauMoi.Text!=this.txt_XacNhanMKMoi.Text)
            {
                MessageBox.Show("Mật khẩu mới không khớp, vui lòng kiểm tra lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult ret = MessageBox.Show("Bạn chắc chắn muốn đổi mật khẩu chứ ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(ret==DialogResult.Yes)
            {
                tempUser.PassWord = Encode.Encrypt(this.txt_MatKhauMoi.Text);
                try
                {
                    objUser.Update(tempUser);
                    MessageBox.Show("Đã thay đổi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    frm_Login f = new frm_Login();
                    f.CaiDatThongBao();
                    f.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi đã sảy ra , vui lòng kiểm tra lại hoặc liên hệ kỹ thuật viên với mô tả lỗi dưới đây : \n " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }
    }
}