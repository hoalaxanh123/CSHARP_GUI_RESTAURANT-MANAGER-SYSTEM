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
namespace QLCaPheProject
{
    public partial class frm_QuanLyNhanSu : DevExpress.XtraEditors.XtraForm
    {
        BaseFunctions<User> objUser = new BaseFunctions<User>();

        public frm_QuanLyNhanSu()
        {
            InitializeComponent();
        }
        public string UserNameLogged = "";

        private void frm_QuanLyNhanSu_Load(object sender, EventArgs e)
        {
            btn_Reload.PerformClick();
        }
        private void listView_NguoiDung_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void xemThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.listView_NguoiDung.Items.Count != 0 && this.listView_NguoiDung.SelectedItems.Count != 0)
            {
                frm_ThongTinNguoiDung f = new frm_ThongTinNguoiDung();
                f.LoadForm(this.listView_NguoiDung.SelectedItems[0].SubItems[0].Text);
                f.UserNameLogged = UserNameLogged;
                f.ShowDialog();
            }
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            LoadDS(objUser.SelectAll());
        }
        private void LoadDS(List<User> DSDauVao)
        {
            this.listView_NguoiDung.Items.Clear();
            foreach (User user in DSDauVao)
            {
                ListViewItem item = new ListViewItem(user.UserName.Trim());
                item.SubItems.Add(user.RealName.Trim());
                item.SubItems.Add(user.BirthDay.ToShortDateString().Trim());
                item.SubItems.Add(user.Address.Trim());
                this.listView_NguoiDung.Items.Add(item);
                this.lbl_Status.Text = ("Tổng số người dùng : " + this.listView_NguoiDung.Items.Count);
            }
        }
        private void listView_NguoiDung_DoubleClick(object sender, EventArgs e)
        {
            xemThôngTinToolStripMenuItem.PerformClick();
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.listView_NguoiDung.Items.Count != 0 && this.listView_NguoiDung.SelectedItems.Count != 0)
            {
                DialogResult ret = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên " +
                    this.listView_NguoiDung.SelectedItems[0].SubItems[1].Text + " không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (ret == DialogResult.Yes)
                {
                    if (User.XoaNguoiDung(this.listView_NguoiDung.SelectedItems[0].SubItems[0].Text))
                    {
                        MessageBox.Show("Xóa thành công , dữ liệu đã thay đổi ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        btn_Reload.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi sảy ra  ,vui lòng kiểm tra lại  hoặc liên hệ kỹ thuật viên", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ThongTinNguoiDung f = new frm_ThongTinNguoiDung();
            f.ChucNang = "Them";
            f.ShowDialog();
            btn_Reload.PerformClick();
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xemThôngTinToolStripMenuItem.PerformClick();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            LoadDS(objUser.FindKeyWord(this.txt_keyword.Text));
        }
    }
}