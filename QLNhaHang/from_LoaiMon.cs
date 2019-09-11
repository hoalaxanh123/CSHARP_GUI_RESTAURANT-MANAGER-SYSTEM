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
    public partial class from_LoaiMon : DevExpress.XtraEditors.XtraForm
    {
        public from_LoaiMon()
        {
            InitializeComponent();
        }
        BaseFunctions<Categories> objCat = new BaseFunctions<Categories>();
        private void from_LoaiMon_Load(object sender, EventArgs e)
        {
            LoadDS(objCat.SelectAll());
        }
        private void LoadDS(List<Categories> DSDauVao)
        {
            this.listView_Loai.Items.Clear();
            foreach (Categories cat in DSDauVao)
            {
                ListViewItem item = new ListViewItem(cat.CatID.ToString());
                item.SubItems.Add(cat.Name);
                item.SubItems.Add(cat.Descreption);
                this.listView_Loai.Items.Add(item);
            }
            this.lblTongSo.Text = "Tổng số Loại món: " + this.listView_Loai.Items.Count;
        }
        private void EnableEditButton(bool Off)
        {
            this.btSua.Enabled = Off;
            this.btThem.Enabled = Off;
            this.btXoa.Enabled = Off;
        }
        private void listView_Loai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listView_Loai.Items.Count != 0 && this.listView_Loai.SelectedItems.Count != 0)
            {
                EnableEditButton(true);
                ListViewItem item = this.listView_Loai.SelectedItems[0];
                this.txtID.Text = item.SubItems[0].Text;
                this.txtTenLM.Text = item.SubItems[1].Text;
                this.txtGhiChuLM.Text = item.SubItems[2].Text;
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            Them_Xoa_Sua("Them");
        }

        private void txtTenLM_TextChanged(object sender, EventArgs e)
        {
            if (this.txtTenLM.TextLength != 0)
            {
                EnableEditButton(true);
            }
            else
            {
                EnableEditButton(false);
            }

        }
        private void Them_Xoa_Sua(string ChucNang)
        {

            Categories cat = new Categories();
            try
            {
                cat.CatID = int.Parse(this.txtID.Text);
            }
            catch (Exception)
            {

                cat.CatID = 1;
            }
            cat.Name = this.txtTenLM.Text;
            cat.Descreption = this.txtGhiChuLM.Text;

            try
            {
                switch (ChucNang)
                {
                    case "Them":
                        objCat.Add(cat);
                        break;
                    case "Xoa":
                        objCat.Delete(cat.CatID);
                        break;
                    case "Sua":
                        objCat.Update(cat);
                        break;
                }

                MessageBox.Show("Thành công , dữ liệu đã thay đổi ");
                LoadDS(objCat.SelectAll());
                EnableEditButton(false);
                this.btXoaTrang.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
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
            this.txtTenLM.Text = "";
            this.txtGhiChuLM.Text = "";
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
            LoadDS(objCat.FindKeyWord(this.txt_tuKhoa.Text));
        }

        private void btn_LoadLai_Click(object sender, EventArgs e)
        {
            btXoaTrang.PerformClick();
            LoadDS(objCat.SelectAll());
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
        

        private void txtGhiChuLM_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            frm_GioiThieu f = new frm_GioiThieu();
            f.ShowDialog();
        }
    }
}