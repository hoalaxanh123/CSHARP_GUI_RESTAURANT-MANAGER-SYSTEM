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
    public partial class frm_QuanLyGia : DevExpress.XtraEditors.XtraForm
    {
        BaseFunctions<Prices> objPrice = new BaseFunctions<Prices>();
        public frm_QuanLyGia()
        {
            InitializeComponent();
        }
        private int ProductId = 0;
        private string Productname;
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void LoadForm(string ProductName, int ProductID)
        {
            this.dtp_NgayBatDau.Value = DateTime.Now;
            EnableEdit(false);
            this.listView1.Items.Clear();
            this.ProductId = ProductID;
            this.Productname = ProductName;
            this.Text = "Cài đặt giá cho món : " + ProductName;
            List<Prices> Prices = objPrice.FindKeyWord(ProductID.ToString());
            for (int i = 0; i < Prices.Count; i++)
            {
                ListViewItem item = new ListViewItem(Prices[i].ID.ToString());
                item.SubItems.Add(Prices[i].Price.ToString());
                item.SubItems.Add(DataAccess.Converts.ToShortDateTimeStringVI(Prices[i].DateStart));
                item.SubItems.Add(DataAccess.Converts.ToShortDateTimeStringVI(Prices[i].DateEnd));
                this.listView1.Items.Add(item);
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listView1.Items.Count != 0 && this.listView1.SelectedItems.Count != 0)
            {
                EnableEdit(true);
                ListViewItem selectedRow = this.listView1.SelectedItems[0];
                this.txt_ID.Text = selectedRow.SubItems[0].Text;
                this.txt_TenMon.Text = this.Text.Split(':')[1];
                this.txt_GiaTien.Text = selectedRow.SubItems[1].Text;
                this.dtp_NgayKetThuc.Value = DataAccess.Converts.DateTimeDotParseVI(selectedRow.SubItems[3].Text);
                this.dtp_NgayBatDau.Value = DataAccess.Converts.DateTimeDotParseVI(selectedRow.SubItems[2].Text);
            }
        }
        private void EnableEdit(bool Off)
        {
            this.btn_XacNhan.Enabled = Off;
            this.btn_Xoa.Enabled = Off;
        }
        private bool CheckDate()
        {
            if (this.dtp_NgayKetThuc.Value <= this.dtp_NgayBatDau.Value)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }
        private void dtp_NgayBatDau_ValueChanged(object sender, EventArgs e)
        {
            this.dtp_NgayKetThuc.Value=this.dtp_NgayBatDau.Value.AddDays(1);

        }
        private void dtp_NgayKetThuc_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_XoaTrang_Click(object sender, EventArgs e)
        {

        }
        private void Them_Sua(string ChucNang)
        {
            if (!CheckDate())
                return;
            Prices price = new Prices();
            price.ID = int.Parse(this.txt_ID.Text);
            price.ProductID = this.ProductId;
            price.Price = float.Parse(this.txt_GiaTien.Text);
            price.DateStart = this.dtp_NgayBatDau.Value;
            price.DateEnd = this.dtp_NgayKetThuc.Value;
            try
            {
                switch (ChucNang)
                {
                    case "Them":
                        objPrice.Add(price);
                        break;
                    case "Sua":
                        objPrice.Update(price);
                        break;
                }
                MessageBox.Show("Thành công , dữ liệu đã thay đổi");
                btn_LoadLai.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đã sảy ra , vui lòng kiểm tra lại hoặc liên hệ kỹ thuật viên với mô tả lỗi dưới đây \n " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            Them_Sua("Them");
        }



        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            Them_Sua("Sua");
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn  chắc chắn muốn xóa chứ  ? ", "Cảnh báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ret == DialogResult.Yes)
            {
                try
                {
                    objPrice.Delete(int.Parse(this.txt_ID.Text));
                    MessageBox.Show("Xóa sửa thành công");
                    btn_LoadLai.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi đã sảy ra , vui lòng kiểm tra lại hoặc liên hệ kỹ thuật viên với mô tả lỗi dưới đây \n " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btn_LoadLai_Click(object sender, EventArgs e)
        {
            LoadForm(this.Productname, this.ProductId);
        }

        private void frm_QuanLyGia_Load(object sender, EventArgs e)
        {
            this.txt_ID.Text = ProductId.ToString();
            this.txt_TenMon.Text = Productname;
        }
    }
}