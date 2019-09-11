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
using System.IO;
using System.Data.SqlClient;

namespace QLCaPheProject
{
    public partial class frm_QuanLyBan : DevExpress.XtraEditors.XtraForm
    {
        BaseFunctions<Categories> objCat = new BaseFunctions<Categories>();
        BaseFunctions<Tables> objTable = new BaseFunctions<Tables>();
        BaseFunctions<Orders> objOrder = new BaseFunctions<Orders>();
        BaseFunctions<OrderDetails> objOrderDetail = new BaseFunctions<OrderDetails>();

        List<Categories> listCat = new List<Categories>();
        List<Products> listPro = new List<Products>();
        List<Tables> listTables = new List<Tables>();
        List<Orders> listOrder = new List<Orders>();
        List<OrderDetails> listOrderDetail = new List<OrderDetails>();

        private int SoBan = 0;
        private int IDBanDangChon = -1;
        private int IDOrderDangChon = -1;
        public frm_QuanLyBan()
        {
            InitializeComponent();
        }
        //private Button MakeNewButtonLikeTable(string TableNAme,string TableText)
        //{

        //}
        private void LoadDSBan()
        {

            this.flowLayoutPanel1.Controls.Clear();
            listTables = objTable.SelectAll();
            this.groupBox_SoDoBan.Text = "Sơ đồ bàn  - Hiện tại có " + listTables.Count + " bàn";
            for (int i = 0; i < listTables.Count; i++)
            {
                //Tạo button mới 
                Button btn = new System.Windows.Forms.Button();
                btn.Location = new System.Drawing.Point(3, 3);
                btn.Size = new System.Drawing.Size(95, 95);
                btn.TabIndex = 0;
                btn.Margin = new Padding(8);
                btn.UseVisualStyleBackColor = true;
                btn.Click += new System.EventHandler(this.btnBan_Click);
                btn.Name = "btn_Table_" + listTables[i].TableID;
                btn.Text = "Bàn " + listTables[i].TableNumber;
                Image img = Image.FromFile("../../Resources/TableActive.png");
                btn.BackgroundImage = img;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                Font font = new Font("Time new Roman", 16, FontStyle.Bold, GraphicsUnit.Pixel);
                btn.Font = font;
                btn.TextAlign = ContentAlignment.BottomCenter;
                btn.ForeColor = Color.White;
                this.flowLayoutPanel1.Controls.Add(btn);

            }

            Button btnThemBan = new System.Windows.Forms.Button();
            btnThemBan.Location = new System.Drawing.Point(3, 3);
            btnThemBan.Size = new System.Drawing.Size(95, 95);
            btnThemBan.TabIndex = 0;
            btnThemBan.Margin = new Padding(8);
            btnThemBan.UseVisualStyleBackColor = true;
            btnThemBan.Click += new System.EventHandler(this.btnThemBan_Click);
            btnThemBan.Name = "btn_BanMoi";
            btnThemBan.Text = "Bàn mới";
            this.flowLayoutPanel1.Controls.Add(btnThemBan);
        }
        private void btnThemBan_Click(object sender, EventArgs e)
        {
            int soNguoi = 0;
            try
            {
                soNguoi = int.Parse(maskedTextBox_SoNguoi.Text);
            }
            catch
            {
            }
            frm_FormPhu_NhapSo f = new frm_FormPhu_NhapSo();
            f.ShowDialog();
            int SoBan = f.Number;
            if (SoBan <= 0)
                return;
            if (TimBanCoTrongHeThong(SoBan) == null)
            {

                Tables tempTable = new Tables(1, SoBan, this.txt_ViTriBan.Text, soNguoi);
                IDBanDangChon = Tables.AddWithOutput(tempTable);
                Orders tempOrder = new Orders(IDBanDangChon, this.txt_NhanVienOrder.Text, DateTime.Now, 0, 0, 0, 0);
                objOrder.Add(tempOrder);
                LoadDSBan();
                IDOrderDangChon = Orders.GetOrderByTableID(IDBanDangChon)[0].OrderID;
            }
            else
            {
                MessageBox.Show("Bàn này đã tồn tại trong hệ thống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.lblSoBan.Text = SoBan.ToString();
        }
        private void frm_QuanLyBan_Load(object sender, EventArgs e)
        {
            //Tao nut them moi ban
            this.txt_ThanhTien.ReadOnly = true;
            this.txt_TongTien.ReadOnly = true;
            LoadDSBan();
            listCat = objCat.SelectAll();
            for (int i = 0; i < listCat.Count; i++)
            {
                ListViewItem item = new ListViewItem((i + 1).ToString());
                item.SubItems.Add(listCat[i].Name);
                item.SubItems.Add(listCat[i].CatID.ToString());
                this.listView_Categories.Items.Add(item);
            }
        }

        private void listView_Categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listView_Categories.Items.Count != 0 && this.listView_Categories.SelectedItems.Count != 0)
            {
                this.groupBox_ChonSanPham.Enabled = true;
                this.listView_Products.Items.Clear();
                ListViewItem selectedCat = this.listView_Categories.SelectedItems[0];
                listPro = Products.SelectProductsByCatID(int.Parse(selectedCat.SubItems[2].Text));
                for (int i = 0; i < this.listPro.Count; i++)
                {
                    ListViewItem item = new ListViewItem((i + 1).ToString());
                    item.SubItems.Add(listPro[i].Name);
                    item.SubItems.Add(listPro[i].Unit);
                    item.SubItems.Add(listPro[i].ProductID.ToString());
                    this.listView_Products.Items.Add(item);
                }

            }
            else
                this.groupBox_ChonSanPham.Enabled = false;

        }
        public void SetUserName(string NAME)
        {
            this.txt_NhanVienOrder.Text = NAME;
        }
        private Tables TimBanCoTrongHeThong(int Number)
        {
            List<Tables> tempListTable = objTable.SelectAll();
            for (int i = 0; i < tempListTable.Count; i++)
            {
                if (tempListTable[i].TableNumber == Number)
                    return tempListTable[i];
            }
            return null;
        }
        private void btnBan_Click(object sender, EventArgs e)
        {

            this.btn_XoaMon.Enabled = false;
            this.btn_ThemMon.Enabled = false;
            this.btn_ThanhToan.Enabled = true;
            this.btn_InBill.Enabled = true;
            this.btn_XoaBan.Enabled = true;



            this.lblSoBan.Text = (sender as Button).Text.Split(' ')[1];
            IDBanDangChon = int.Parse((sender as Button).Name.Split('_')[2]);
            IDOrderDangChon = Orders.GetOrderByTableID(IDBanDangChon)[0].OrderID;

            //Lấy vị trí bàn
            if (SoBan <= 20)
                this.txt_ViTriBan.Text = "Tầng 1";
            if (SoBan > 20 && SoBan <= 40)
                this.txt_ViTriBan.Text = "Tầng 2";
            if (SoBan > 40)
                this.txt_ViTriBan.Text = "Dự phòng";

            this.groupBox_HoaDon.Text = "Thông tin hóa đơn : " + IDOrderDangChon;
            //Load các món ăn đã chọn của bàn
            LoadDSBan();
            LoadListView_CacMonDaChon();

        }
        private void LoadListView_CacMonDaChon()
        {
            this.listView_CacMonDaGoi.Items.Clear();
            listOrder = Orders.GetOrderByTableID(IDBanDangChon);
            this.listView_CacMonDaGoi.Items.Clear();
            for (int i = 0; i < listOrder.Count; i++)
            {
                int STT = 1;
                listOrderDetail = OrderDetails.GetByOrderID(listOrder[i].OrderID);
                for (int j = 0; j < listOrderDetail.Count; j++)
                {
                    ListViewItem item = new ListViewItem(STT.ToString());
                    item.SubItems.Add(listOrderDetail[j].Name);
                    item.SubItems.Add(listOrderDetail[j].Quantity.ToString());
                    item.SubItems.Add(Converts.ChuyenDoiTienTeVietNam(listOrderDetail[j].UnitPrice));
                    item.SubItems.Add(Converts.ChuyenDoiTienTeVietNam(listOrderDetail[j].SubTotal));
                    item.SubItems.Add(listOrderDetail[j].ProductID.ToString());
                    item.SubItems.Add(listOrderDetail[j].OrderDetailsID.ToString());
                    this.listView_CacMonDaGoi.Items.Add(item);
                    STT++;
                }
            }
            Load_ThanhTOan();

        }
        private void Load_ThanhTOan()
        {
            if (this.listView_CacMonDaGoi.Items.Count != 0)
            {
                float TongTien = 0;
                for (int i = 0; i < this.listView_CacMonDaGoi.Items.Count; i++)
                {
                    TongTien += Converts.ReturnFloat(this.listView_CacMonDaGoi.Items[i].SubItems[4].Text);
                }
                this.txt_ThanhTien.Text = Converts.ChuyenDoiTienTeVietNam(TongTien);
                try
                {
                    this.txt_TongTien.Text = Converts.ChuyenDoiTienTeVietNam((TongTien + float.Parse(txt_ThueVAT.Text) + float.Parse(txt_PhiDichVu.Text) - float.Parse(txt_GiamGia.Text)));
                }
                catch (Exception ex)
                {
                    txt_TongTien.Text = ex.Message;
                }
            }
        }

        private void lbl_SoBan_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.txt_ThanhTien.Text = "0";
                this.txt_ThueVAT.Text = "0";
                this.txt_PhiDichVu.Text = "0";
                this.txt_GiamGia.Text = "0";
                this.txt_TongTien.Text = "0";
                this.groupBox_ChonLoai.Enabled = int.Parse(this.lblSoBan.Text) > 0;
                this.listView_CacMonDaGoi.Items.Clear();
                LoadListView_CacMonDaChon();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void listView_Products_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listView_Products.Items.Count != 0 && this.listView_Products.SelectedItems.Count != 0)
            {
                btn_ThemMon.Enabled = true;
            }
            else
                btn_ThemMon.Enabled = false;
        }

        private void btn_ThemMon_Click(object sender, EventArgs e)
        {
            frm_FormPhu_NhapSo f = new frm_FormPhu_NhapSo();
            f.ShowDialog();

            if (f.Number <= 0)
            {
                MessageBox.Show("Dữ liệu vừa nhập không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.listView_Products.Items.Count != 0 && this.listView_Products.SelectedItems.Count != 0)
            {
                int productID = int.Parse(this.listView_Products.SelectedItems[0].SubItems[3].Text);
                float Price = Prices.GetPriceByDateAndProductID(DateTime.Now, productID);
                IDOrderDangChon = Orders.GetOrderByTableID(IDBanDangChon)[0].OrderID;
                OrderDetails tempOrderDeTail = new OrderDetails(IDOrderDangChon, productID, Price, f.Number, 0);
                objOrderDetail.Add(tempOrderDeTail);
                LoadListView_CacMonDaChon();
                LoadDSBan();

            }
        }

        private void txt_ThueVAT_EditValueChanged(object sender, EventArgs e)
        {
            if (this.listView_CacMonDaGoi.Items.Count != 0)
            {
                float TongTien = 0;
                for (int i = 0; i < this.listView_CacMonDaGoi.Items.Count; i++)
                {
                    TongTien += float.Parse(this.listView_CacMonDaGoi.Items[i].SubItems[4].Text);
                }
                this.txt_ThanhTien.Text = Converts.ChuyenDoiTienTeVietNam(TongTien);
                try
                {
                    this.txt_TongTien.Text = Converts.ChuyenDoiTienTeVietNam(TongTien + Converts.ReturnFloat(txt_ThueVAT.Text) + Converts.ReturnFloat(txt_PhiDichVu.Text) - Converts.ReturnFloat(txt_GiamGia.Text));
                    this.btn_InBill.Enabled = true;
                    this.btn_ThanhToan.Enabled = true;
                }
                catch
                {
                    txt_TongTien.Text = "Thông tin đầu vào sai";
                    this.btn_InBill.Enabled = false;
                    this.btn_ThanhToan.Enabled = false;
                }
            }
        }

        private void listView_CacMonDaGoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listView_CacMonDaGoi.Items.Count != 0 && this.listView_CacMonDaGoi.SelectedItems.Count != 0)
            {
                btn_XoaMon.Enabled = true;
            }
            else
                btn_XoaMon.Enabled = false;
        }

        private void txt_ThanhTien_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_InBill_Click(object sender, EventArgs e)
        {
            if (this.listView_CacMonDaGoi.Items.Count == 0)
            {
                MessageBox.Show("Không có món nào để in", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

         
            frm_InBill f = new frm_InBill();
            f.LoadList(IDOrderDangChon);
            f.LoadThongTin(this.txt_NhanVienOrder.Text, this.lblSoBan.Text, this.txt_ThanhTien.Text, this.txt_ThueVAT.Text, this.txt_PhiDichVu.Text, this.txt_GiamGia.Text, this.txt_TongTien.Text,false);
            f.ShowDialog();

        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult ret1 = MessageBox.Show("Bạn muốn thanh toán  bàn này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret1 == DialogResult.Yes)
            {
                if (float.Parse(txt_TongTien.Text) == 0)
                {
                    MessageBox.Show("Không có gì để thanh toán cả", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.listView_CacMonDaGoi.Items.Count == 0)
                {
                    MessageBox.Show("Không có món nào để in", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                frm_InBill f = new frm_InBill();
                f.LoadList(IDOrderDangChon);
                f.LoadThongTin(this.txt_NhanVienOrder.Text, this.lblSoBan.Text, this.txt_ThanhTien.Text, this.txt_ThueVAT.Text, this.txt_PhiDichVu.Text, this.txt_GiamGia.Text, this.txt_TongTien.Text, true);
                f.ShowDialog();
                try
                {
                    objTable.Delete(IDBanDangChon);
                    LoadDSBan();

                  

                    this.listView_CacMonDaGoi.Items.Clear();
                    this.listView_Products.Items.Clear();
                    this.lblSoBan.Text = "0";
                    this.groupBox_HoaDon.Text = "Thông tin hóa đơn";
                    this.txt_ViTriBan.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi đã sảy ra , vui lòng kiểm tra lại hoặc liên hệ kỹ thuật viên với mô tả lỗi dưới đây \n " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }
        private void btn_XoaBan_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc muốn xóa bàn này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                try
                {
                    OrderDetails.DeleteOrderID(IDOrderDangChon);
                    objOrder.Delete(IDOrderDangChon);
                    objTable.Delete(IDBanDangChon);
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDSBan();
                    this.listView_CacMonDaGoi.Items.Clear();
                    this.listView_Products.Items.Clear();
                    this.lblSoBan.Text = "0";
                    this.groupBox_HoaDon.Text = "Thông tin hóa đơn";
                    this.txt_ViTriBan.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi đã sảy ra , vui lòng kiểm tra lại hoặc liên hệ kỹ thuật viên với mô tả lỗi dưới đây \n " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btn_XoaMon_Click(object sender, EventArgs e)
        {
            if (listView_CacMonDaGoi.Items.Count != 0 && this.listView_CacMonDaGoi.SelectedItems.Count != 0)
            {
                ListViewItem selectedItem = this.listView_CacMonDaGoi.SelectedItems[0];
                string TenMon = selectedItem.SubItems[1].Text;
                int ID = int.Parse(selectedItem.SubItems[6].Text);
                DialogResult ret = MessageBox.Show("Bạn có chắc chắn muốn xóa món " + TenMon + " ( " + ID + " )" + "không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    try
                    {
                        objOrderDetail.Delete(ID);
                        MessageBox.Show("Xóa thành công, dữ liệu thay đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadListView_CacMonDaChon();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi đã sảy ra , vui lòng kiểm tra lại hoặc liên hệ kỹ thuật viên với mô tả lỗi dưới đây \n " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void txt_ThueVAT_Leave(object sender, EventArgs e)
        {
            if ((sender as TextEdit).Name == "txt_ThueVAT")
                this.txt_ThueVAT.Text = Converts.ChuyenDoiTienTeVietNam(float.Parse(this.txt_ThueVAT.Text));
            if ((sender as TextEdit).Name == "txt_PhiDichVu")
                this.txt_PhiDichVu.Text = Converts.ChuyenDoiTienTeVietNam(float.Parse(this.txt_PhiDichVu.Text));
            if ((sender as TextEdit).Name == "txt_GiamGia")
                this.txt_GiamGia.Text = Converts.ChuyenDoiTienTeVietNam(float.Parse(this.txt_GiamGia.Text));
        }

        private void txt_TongTien_EditValueChanged(object sender, EventArgs e)
        {
            // this.txt_TongTien.Text = Converts.ChuyenDoiTienTeVietNam(float.Parse(this.txt_TongTien.Text));

        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.listView_CacMonDaGoi.Items.Count != 0 && this.listView_CacMonDaGoi.SelectedItems.Count != 0)
            {
                btn_XoaMon.PerformClick();
            }
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.listView_CacMonDaGoi.Items.Count != 0 && this.listView_CacMonDaGoi.SelectedItems.Count != 0)
            {
                frm_FormPhu_NhapSo f = new frm_FormPhu_NhapSo();
                f.ShowDialog();
                int ID = int.Parse(this.listView_CacMonDaGoi.SelectedItems[0].SubItems[6].Text);
                int SoLuong = f.Number;
                float GiaCa = Converts.ReturnFloat(this.listView_CacMonDaGoi.SelectedItems[0].SubItems[3].Text);
                try
                {
                    OrderDetails.Update(ID, SoLuong, GiaCa);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                LoadListView_CacMonDaChon();
            }

        }

        private void lblSoBan_Click(object sender, EventArgs e)
        {

        }
    }
}