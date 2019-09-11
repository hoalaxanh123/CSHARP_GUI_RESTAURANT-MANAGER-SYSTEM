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
    public partial class frm_MonAn : DevExpress.XtraEditors.XtraForm
    {
        BaseFunctions<Products> objProducts = new BaseFunctions<Products>();
        BaseFunctions<Categories> objCat = new BaseFunctions<Categories>();
        public frm_MonAn()
        {
            InitializeComponent();
        }
        public List<Categories> tempCatList = new List<Categories>();
        private void frm_MonAn_Load(object sender, EventArgs e)
        {
            LoadCat();
            LoadDS(objProducts.SelectAll());
        }
        private void LoadCat()
        {
            tempCatList = objCat.SelectAll();
            this.comboBox1.DataSource = tempCatList;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.ValueMember = "CatID";
            this.comboBox1.SelectedItem = this.comboBox1.Items[0];

            this.cbb_LoaiMon.DataSource = tempCatList;
            this.cbb_LoaiMon.DisplayMember = "Name";
            this.cbb_LoaiMon.ValueMember = "CatID";
            this.cbb_LoaiMon.SelectedItem = this.comboBox1.Items[0];
        }
        private void EnableEditButton(bool Off)
        {
            this.btSua.Enabled = Off;
            this.btThem.Enabled = Off;
            this.btXoa.Enabled = Off;
            this.btn_KiemSoatGia.Enabled = Off;
        }
        private void LoadDS(List<Products> DSDauVao)
        {
            EnableEditButton(false);
            this.listView_MonAn.Items.Clear();
            foreach (Products product in DSDauVao)
            {
                float Price = Prices.GetPriceByDateAndProductID(DateTime.Now, product.ProductID);
                ListViewItem item = new ListViewItem(product.ProductID.ToString());
                item.SubItems.Add(product.Name);
                item.SubItems.Add(product.Description);
                if(Price!=-1)
                 item.SubItems.Add(Price.ToString());
                else
                {
                    item.SubItems.Add("Chưa cài đặt giá");

                    this.btn_KiemSoatGia.Enabled = true;
                }
                item.SubItems.Add(product.Image);
                item.SubItems.Add(product.Unit);
                item.SubItems.Add(FindCatNameByCatId(product.CatId));
                item.SubItems.Add(product.Type ? "Nhập" : "Bán");
                this.listView_MonAn.Items.Add(item);
            }
            this.lblTongSo.Text = "Tổng số món: " + this.listView_MonAn.Items.Count;

        }
        private bool CheckOK()
        {

            //for (int i = 0; i < this.Controls.Count; i++)
            //{
            //    if ((Controls[i].GetType() is TextBox || Controls[i] is RichTextBox )&&(this.Controls[i]!=this.txt_tuKhoa))
            //    {
            //        if (this.Controls[i].Text.Length == 0)
            //        {
            //            this.errorProvider1.SetError(this.Controls[i], "Vui lòng không bỏ trống trường này ");
            //            EnableEditButton(false);
            //            return false;
            //        }
            //        else
            //        {
            //            EnableEditButton(true);
            //        }

            //    }
            //}
            return true;
        }
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                LoadDS(Products.SelectProductsByCatID(this.comboBox1.SelectedValue));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Lỗi");
            }

        }

        private void txt_tuKhoa_TextChanged(object sender, EventArgs e)
        {
            if (this.txt_tuKhoa.TextLength != 0)
                this.btn_TimKiem.Enabled = true;
            else
                this.btn_TimKiem.Enabled = false;
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            LoadDS(objProducts.FindKeyWord(this.txt_tuKhoa.Text));
        }

        private void btn_LoadLai_Click(object sender, EventArgs e)
        {
            LoadDS(objProducts.SelectAll());
        }

        private void listView_Loai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listView_MonAn.Items.Count != 0 && this.listView_MonAn.SelectedItems.Count != 0)
            {
                EnableEditButton(true);
                ListViewItem selectedRow = this.listView_MonAn.SelectedItems[0];
                this.txtID.Text = selectedRow.SubItems[0].Text;
                this.txt_TenMon.Text = selectedRow.SubItems[1].Text;
                this.txt_MoTa.Text = selectedRow.SubItems[2].Text;
                this.txt_GiaTien.Text = selectedRow.SubItems[3].Text;
                this.txt_HinhAnh.Text = selectedRow.SubItems[4].Text;
                this.txt_DonViTinh.Text = selectedRow.SubItems[5].Text;
                if (selectedRow.SubItems[6].Text == "Bán")
                    this.rb_Nhap.Checked = true;
                else
                    this.rb_Nhap.Checked = false;
                this.cbb_LoaiMon.SelectedIndex = this.cbb_LoaiMon.FindString(selectedRow.SubItems[6].Text);
                try
                {
                    this.pictureBox_Avatar.Load("../../Resources/Image_Products/" + this.txt_HinhAnh.Text);
                }
                catch (Exception)
                {
                    this.pictureBox_Avatar.Load("../../Resources/Image_Products/404.jpg");
                }
            }

        }
        public string FindCatNameByCatId(int CatID)
        {
            for (int i = 0; i < tempCatList.Count; i++)
            {
                if (tempCatList[i].CatID == CatID)
                    return tempCatList[i].Name;
            }
            return null;
        }
        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
        private bool KiemTraTinhHopLe()
        {
            if (this.txt_TenMon.TextLength == 0)
                return false;
            if (this.txt_DonViTinh.TextLength == 0)
                return false;
            if (this.txt_GiaTien.TextLength == 0)
                return false;
            if (this.txt_HinhAnh.TextLength == 0)
                return false;
            if (this.txt_MoTa.TextLength == 0)
                return false;

            return true;
        }
        private void btThem_Click(object sender, EventArgs e)
        {

            Them_Xoa_Sua("Them");
        }
        private void Them_Xoa_Sua(string ChucNang)
        {
            if (!KiemTraTinhHopLe())
            {
                MessageBox.Show("Có vẻ như bạn chưa nhập đầy đủ thông tin , vui lòng kiểm tra lại hoặc liên hệ kỹ thuật viên","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            Products pro = new Products();
            try
            {
                pro.ProductID = int.Parse(this.txtID.Text);
            }
            catch (Exception)
            {

                pro.ProductID = 1;
            }
            pro.Name = this.txt_TenMon.Text;
            pro.Image = this.txt_HinhAnh.Text;
            pro.CatId = (int)this.cbb_LoaiMon.SelectedValue;
            pro.Description = this.txt_MoTa.Text;
            pro.Unit = this.txt_DonViTinh.Text;
            if (rd_Ban.Checked)
                pro.Type = false;
            else
                pro.Type = true;

            try
            {
                switch (ChucNang)
                {
                    case "Them":
                        objProducts.Add(pro);
                        frm_QuanLyGia f = new frm_QuanLyGia();
                        f.LoadForm(pro.Name, pro.ProductID);
                        f.ShowDialog();
                        break;
                    case "Xoa":
                        Prices.DeleteByProductID(pro.ProductID);
                        objProducts.Delete(pro.ProductID);
                        break;
                    case "Sua":
                        objProducts.Update(pro);
                        break;
                }

                MessageBox.Show("Thành công , dữ liệu đã thay đổi ");
                LoadDS(objProducts.SelectAll());
                EnableEditButton(false);
                this.btXoaTrang.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đã sảy ra , vui lòng kiểm tra lại hoặc liên hệ kỹ thuật viên với mô tả lỗi dưới đây \n " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt_GiaTien_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    double giaTien = (double.Parse(this.txt_GiaTien.Text));
            //    this.EnableEditButton(true);
            //    this.errorProvider1.Clear();
            //}
            //catch
            //{
            //    this.errorProvider1.SetError(this.txt_GiaTien, "Vui lòng chỉ nhập số");
            //    this.EnableEditButton(false);
            //}
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            Them_Xoa_Sua("Xoa");
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            Them_Xoa_Sua("Sua");
        }

        private void btXoaTrang_Click(object sender, EventArgs e)
        {
            this.txtID.Text = "";
            this.txt_TenMon.Text = "";
            this.txt_MoTa.Text = "";
            this.txt_GiaTien.Text = "";
            this.txt_HinhAnh.Text = "";
            this.txt_DonViTinh.Text = "";
            this.cbb_LoaiMon.SelectedIndex = 1;
        }

        private void txt_TenMon_TextChanged(object sender, EventArgs e)
        {
            CheckOK();
        }

        private void txt_DonViTinh_TextChanged(object sender, EventArgs e)
        {
            CheckOK();
        }

        private void txt_HinhAnh_TextChanged(object sender, EventArgs e)
        {
            CheckOK();
        }

        private void txt_MoTa_TextChanged(object sender, EventArgs e)
        {
            CheckOK();
        }

        private void btn_ChonHinh_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Chọn file ảnh";
            openFileDialog1.Filter = "Image file (*.jpg)|*.jpg|All files (*.*)|*.*";
            DialogResult ret = openFileDialog1.ShowDialog();
            if(ret==DialogResult.OK)
            {
                this.txt_HinhAnh.Text = openFileDialog1.SafeFileName;
                try
                {
                    this.pictureBox_Avatar.Load("../../Resources/Image_Products/" + this.txt_HinhAnh.Text);
                }
                catch (Exception)
                {
                    this.pictureBox_Avatar.Load("../../Resources/Image_Products/404.jpg");
                }
            }
        }

        private void btn_KiemSoatGia_Click(object sender, EventArgs e)
        {
            frm_QuanLyGia f = new frm_QuanLyGia();
            f.LoadForm(this.txt_TenMon.Text,int.Parse(this.txtID.Text));
            f.ShowDialog();
            btn_LoadLai.PerformClick();

        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}