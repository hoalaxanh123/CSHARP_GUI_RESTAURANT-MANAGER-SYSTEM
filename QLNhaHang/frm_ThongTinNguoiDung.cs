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
    public partial class frm_ThongTinNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        BaseFunctions<User> objUser = new BaseFunctions<User>();
        public frm_ThongTinNguoiDung()
        {
            InitializeComponent();
        }
        public string ChucNang { get; set; }
        public string UserNameLogged = "";
        private string OldPASS = "", UserName = "";
        private void frm_ThongTinNguoiDung_Load(object sender, EventArgs e)
        {
            if (ChucNang == "Them")
                this.txt_TenDangNhap.ReadOnly = false;
            else
                this.txt_TenDangNhap.ReadOnly = true;
            this.cbb_PhanQuyen.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbb_PhanQuyen.SelectedItem = this.cbb_PhanQuyen.Items[0];
        }
   
        private void CheckLength(Control a, int length)
        {
            if (a.Text.Length < length)
            {
                errorProvider1.SetError(a, "Vui lòng nhập ít nhất " + length + " ký tự .");
                this.btn_ThayDoiThongTin.Enabled = false;
            }
            else
            {
                this.btn_ThayDoiThongTin.Enabled = true;
                errorProvider1.Clear();
            }

        }
        private void LoadHinh()
        {
            try
            {
                this.ptb_Avatar.Load("../../Resources/imageUser/" + this.txt_HinhAnh.Text);
            }
            catch (Exception)
            {

                this.ptb_Avatar.Load("../../Resources/Error.jpg");
            }
        }
        public void LoadForm(string UserName)
        {
     
            try
            {
                User NguoiDung = User.GetUserByUserName(UserName);
                this.txt_TenDangNhap.Text = NguoiDung.UserName.Trim();
                this.txt_MatKhau.Text = NguoiDung.PassWord.Trim();
                this.txt_NhapLaiMatKhau.Text = this.txt_MatKhau.Text;
                this.txt_TenThat.Text = NguoiDung.RealName.Trim();
                this.txt_CMND.Text = NguoiDung.indentityCard.Trim();
                this.rtb_DiaChi.Text = NguoiDung.Address.Trim();
                this.txt_HinhAnh.Text = NguoiDung.Avatar.Trim();
                this.dateTimePicker1.Value = NguoiDung.BirthDay;
                OldPASS = NguoiDung.PassWord.Trim();
                this.UserName = UserName;
                //  MessageBox.Show(NguoiDung.Administrators.ToString());
                LoadHinh();
                switch (NguoiDung.Administrators)
                {
                    case 0:
                        this.cbb_PhanQuyen.SelectedIndex = this.cbb_PhanQuyen.FindString("Quản trị viên");
                        break;
                    case 1:
                        this.cbb_PhanQuyen.SelectedIndex = this.cbb_PhanQuyen.FindString("Quản lý");
                        break;
                    case 2:
                        this.cbb_PhanQuyen.SelectedIndex = this.cbb_PhanQuyen.FindString("Nhân viên");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đã sảy ra , vui lòng kiểm tra lại hoặc liên hệ kỹ thuật viên với mô tả lỗi dưới đây : \n " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ChonHinh_Click(object sender, EventArgs e)
        {
            DialogResult ret = openFileDialog1.ShowDialog();
            if (ret == DialogResult.OK)
            {
                this.txt_HinhAnh.Text = this.openFileDialog1.SafeFileName;
                LoadHinh();
            }
        }
        
        private void btn_ThayDoiThongTin_Click(object sender, EventArgs e)
        {
            if(this.txt_MatKhau.Text!=this.txt_NhapLaiMatKhau.Text)
            {
                MessageBox.Show("Mật khẩu không khớp , vui lòng kiểm tra lại ", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult ret = MessageBox.Show("Bạn chắc chắn chứ ? ", "Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (ret == DialogResult.Yes)
            {
                User UserNew = new User();
                UserNew.Address = this.rtb_DiaChi.Text;
                switch (this.cbb_PhanQuyen.Text)
                {
                    case "Quản trị viên":
                        UserNew.Administrators = 0;
                        break;
                    case "Quản lý":
                        UserNew.Administrators = 1;
                        break;
                    case "Nhân viên":
                        UserNew.Administrators = 2;
                        break;
                }
                UserNew.Avatar = this.txt_HinhAnh.Text;
                UserNew.BirthDay = this.dateTimePicker1.Value;
                UserNew.indentityCard = this.txt_CMND.Text;
                UserNew.PassWord = Encode.Encrypt(this.txt_MatKhau.Text);
                UserNew.RealName = this.txt_TenThat.Text;
                UserNew.UserName = this.txt_TenDangNhap.Text;
                try
                {
                    if (ChucNang == "Them")
                    {
                        try
                        {
                            objUser.Add(UserNew);
                            MessageBox.Show("Thêm thành công , dữ liệu thay đổi ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi đã sảy ra , vui lòng kiểm tra lại hoặc liên hệ kỹ thuật viên với mô tả lỗi dưới đây : \n " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                        
                    else
                    {
                        objUser.Update(UserNew);
                        MessageBox.Show("Thay đổi thông tin thành công ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        if (OldPASS != this.txt_MatKhau.Text && this.txt_TenDangNhap.Text.Trim()==UserNameLogged)
                        {
                            this.Close();
                            frm_Login f = new frm_Login();
                            f.CaiDatThongBao();
                            f.ShowDialog();
                        }
                    }
                   

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi đã sảy ra , vui lòng kiểm tra lại hoặc liên hệ kỹ thuật viên với mô tả lỗi dưới đây : \n " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void txt_MatKhau_TextChanged(object sender, EventArgs e)
        {
            CheckLength(this.txt_MatKhau, 6);
        }

        private void txt_TenThat_TextChanged(object sender, EventArgs e)
        {
            CheckLength(this.txt_TenThat, 10);
        }

        private void txt_CMND_TextChanged(object sender, EventArgs e)
        {
            CheckLength(this.txt_CMND, 13);
        }

        private void rtb_DiaChi_TextChanged(object sender, EventArgs e)
        {
            CheckLength(this.rtb_DiaChi, 20);
        }

        private void txt_HinhAnh_TextChanged(object sender, EventArgs e)
        {
            CheckLength(this.txt_HinhAnh, 3);
        }
        private void HienPass(TextBox textBox,DevExpress.XtraEditors.SimpleButton button)
        {
            if (textBox.UseSystemPasswordChar)
            {
                textBox.UseSystemPasswordChar = false;
                button.Text = "Ẩn";
            }

            else
            {
                textBox.UseSystemPasswordChar = true;
                button.Text = "Hiện";
            }
        }

        private void btn_HienNhapLaiMatKhau_Click(object sender, EventArgs e)
        {
            HienPass(this.txt_NhapLaiMatKhau, btn_HienNhapLaiMatKhau);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if(dateTimePicker1.Value>DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không được lớn hơn ngày hiện tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePicker1.Value = DateTime.Now;
            }
        }

        private void btn_HienPass_Click(object sender, EventArgs e)
        {
            HienPass(this.txt_MatKhau, btn_HienPass);
        }
    }
}