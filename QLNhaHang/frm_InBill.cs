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

namespace QLCaPheProject
{
    public partial class frm_InBill : DevExpress.XtraEditors.XtraForm
    {
        public frm_InBill()
        {
            InitializeComponent();
        }
        BaseFunctions<Categories> objCat = new BaseFunctions<Categories>();
        BaseFunctions<Orders> objOrder = new BaseFunctions<Orders>();
        public List<Categories> tempCatList = new List<Categories>();

        List<Orders> listOrder = new List<Orders>();
        List<OrderDetails> listOrderDetail = new List<OrderDetails>();
        public string TenNV, SoBan = "0", ThanhTien = "0", ThueVAT = "0", GiamGia2 = "0", TongTien = "0", PhiDichVu = "0";
        bool thanhToan=false;

        private void rbtn_GiamTheoSoTien_CheckedChanged(object sender, EventArgs e)
        {
            this.lb_Status.Text = "Nhập vào số tiền : ";
            this.textBox_Giam.Text = "";
        }
        int IDBanDangChon;
        private void LoadCat()
        {
            tempCatList = objCat.SelectAll();
            this.comboBox_LoaiMon.DataSource = tempCatList;
            this.comboBox_LoaiMon.DisplayMember = "Name";
            this.comboBox_LoaiMon.ValueMember = "CatID";
            this.comboBox_LoaiMon.SelectedItem = this.comboBox_LoaiMon.Items[0];
        }
        public void LoadThongTin(string TenNV, string SoBan, string ThanhTien, string ThueVAT, string PhiDichVu, string GiamGia2, string TongTien, bool ThanhToan)
        {
            this.TenNV = TenNV;
            this.SoBan = SoBan;
            this.ThanhTien = ThanhTien;
            this.ThueVAT = ThueVAT;
            this.GiamGia2 = GiamGia2;
            this.TongTien = TongTien;
            this.thanhToan = ThanhToan;
        }

        public void LoadList(int ID)
        {
            IDBanDangChon = ID;
            listOrder = Orders.GetOrderByTableID(IDBanDangChon);
            this.Text = "In bill bàn : " + IDBanDangChon;
            this.listView_CacMonDaGoi.Items.Clear();
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
                    item.SubItems.Add(Converts.ChuyenDoiTienTeVietNam(listOrderDetail[j].Discount));
                    item.SubItems.Add(Converts.ChuyenDoiTienTeVietNam(listOrderDetail[j].SubTotal));
                    item.SubItems.Add(listOrderDetail[j].ProductID.ToString());
                    item.SubItems.Add(listOrderDetail[j].OrderDetailsID.ToString());
                    this.listView_CacMonDaGoi.Items.Add(item);
                    STT++;
                }
            }

        }

        private void rbtn_GiamTheoPhanTram_CheckedChanged(object sender, EventArgs e)
        {
            this.lb_Status.Text = "Nhập vào % giảm giá : ";
            this.textBox_Giam.Text = "";
        }
        private void textBox_Giam_Leave(object sender, EventArgs e)
        {
            try
            {
                float SoTien = float.Parse(this.textBox_Giam.Text);
                if (rbtn_GiamTheoPhanTram.Checked)
                    this.textBox_Giam.Text += " %";
                if (rbtn_GiamTheoSoTien.Checked)
                    this.textBox_Giam.Text = DataAccess.Converts.ChuyenDoiTienTeVietNam(SoTien);
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu không hợp lệ, vui lòng kiểm tra lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void btn_HuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frm_InBill_Load(object sender, EventArgs e)
        {
            this.btn_ThanhToan.Visible = thanhToan;
            LoadCat();
            TinhTongTien();
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Thanh toán cho bàn này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                Orders order = new Orders();
                order.DateCreated = DateTime.Now;
                order.Discount = float.Parse(GiamGia2);
                order.OrderID = IDBanDangChon;
                order.ServiceCharge = float.Parse(this.PhiDichVu);
                order.TableID = IDBanDangChon;
                order.TaxVAT = Converts.ReturnFloat(this.ThueVAT);
                order.TotalMoney = Converts.ReturnFloat(this.TongTien);
                order.UserName = this.TenNV;
                objOrder.Update(order);
                this.Close();
            }
        }

        private void btn_ApDung_Click(object sender, EventArgs e)
        {
            if (rbtn_ToanBo.Checked)
                GiamToanBoDS();
            else
                if (rbtn_CacMonDuocChon.Checked)
                GiamCacMonDuocChon();

            TinhTongTien();

        }
        private void TinhTongTien()
        {
            float TTien = 0;
            for (int i = 0; i < this.listView_CacMonDaGoi.Items.Count; i++)
            {
                TTien += DataAccess.Converts.ReturnFloat(this.listView_CacMonDaGoi.Items[i].SubItems[6].Text);
            }
            TongTien = DataAccess.Converts.ChuyenDoiTienTeVietNam(TTien);
            this.lb_TongTien.Text = "Tổng số tiền : " + TongTien;
        }
        private void GiamToanBoDS()
        {
            for (int i = 0; i < this.listView_CacMonDaGoi.Items.Count; i++)
            {
                float TongTien = DataAccess.Converts.ReturnFloat(this.listView_CacMonDaGoi.Items[i].SubItems[4].Text);
                //this.listView_CacMonDaGoi.Items[i].SubItems[4].Text = DataAccess.Converts.ChuyenDoiTienTeVietNam(TongTien);
                float SoTien = 0;
                if (rbtn_GiamTheoPhanTram.Checked)
                {
                    SoTien = (TongTien / 100) * float.Parse(this.textBox_Giam.Text.Split(' ')[0]);
                }
                if (rbtn_GiamTheoSoTien.Checked)
                {
                    SoTien = float.Parse(this.textBox_Giam.Text);
                }
                this.listView_CacMonDaGoi.Items[i].SubItems[5].Text = DataAccess.Converts.ChuyenDoiTienTeVietNam(SoTien);
                this.listView_CacMonDaGoi.Items[i].SubItems[6].Text = DataAccess.Converts.ChuyenDoiTienTeVietNam(TongTien - SoTien);
            }
        }
        private void GiamCacMonDuocChon()
        {
            for (int i = 0; i < this.listView_CacMonDaGoi.CheckedItems.Count; i++)
            {
                float TongTien = DataAccess.Converts.ReturnFloat(this.listView_CacMonDaGoi.CheckedItems[i].SubItems[4].Text);
                float SoTien = 0;
                if (rbtn_GiamTheoPhanTram.Checked)
                {
                    SoTien = (TongTien / 100) * float.Parse(this.textBox_Giam.Text.Split(' ')[0]);
                }
                if (rbtn_GiamTheoSoTien.Checked)
                {
                    SoTien = float.Parse(this.textBox_Giam.Text);
                }
                this.listView_CacMonDaGoi.CheckedItems[i].SubItems[5].Text = DataAccess.Converts.ChuyenDoiTienTeVietNam(SoTien);
                this.listView_CacMonDaGoi.CheckedItems[i].SubItems[6].Text = DataAccess.Converts.ChuyenDoiTienTeVietNam(TongTien - SoTien);
            }
        }
        private void textBox_Giam_Enter(object sender, EventArgs e)
        {
            try
            {
                if (this.textBox_Giam.Text.Length > 0 && this.rbtn_GiamTheoPhanTram.Checked)
                    this.textBox_Giam.Text = this.textBox_Giam.Text.Remove(this.textBox_Giam.Text.Length - 1);
            }
            catch (Exception)
            {
                throw;
            }
            try
            {
                if (this.textBox_Giam.Text.Length > 0 && rbtn_GiamTheoSoTien.Checked)
                    this.textBox_Giam.Text = DataAccess.Converts.ReturnFloat(this.textBox_Giam.Text).ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btn_InBill_Click(object sender, EventArgs e)
        {
            string FileName = "Bill_" + this.TenNV + "_Table " + this.SoBan + "_" + DateTime.Now.ToShortDateString().Replace('/', '-') + "_" + DateTime.Now.ToShortTimeString().Replace(':', '.') + ".txt";
            using (StreamWriter sw = new StreamWriter("../../Bills/" + FileName + ""))
            {

                sw.WriteLine("NHÀ HÀNG ABC XIN KÍNH CHÀO QUÝ KHÁCH");
                sw.WriteLine(DateTime.Now);
                sw.WriteLine("Bàn : " + this.SoBan);
                sw.WriteLine("Danh sách các món đã dùng : ");
                sw.WriteLine("----------------------------------------------------------------------------------------------------------------");
                sw.Write("STT\t\t");
                sw.Write("Tên món\t\t\t\t");
                sw.Write("Số lượng\t\t");
                sw.Write("Giá 1SP\t\t");
                sw.Write("Giá chưa giảm\t\t");
                sw.Write("Giá đã giảm\t\t\n");
                sw.WriteLine();
                for (int i = 0; i < this.listView_CacMonDaGoi.Items.Count; i++)
                {
                    ListViewItem item = this.listView_CacMonDaGoi.Items[i];
                    sw.WriteLine();
                    sw.Write(item.SubItems[0].Text + "\t\t");
                    if (item.SubItems[1].Text.Length <= 17)
                        sw.Write(item.SubItems[1].Text + ".\t\t\t");
                    else
                        sw.Write(item.SubItems[1].Text + "\t\t");
                    sw.Write(item.SubItems[2].Text + "\t\t");
                    sw.Write(item.SubItems[3].Text + "\t\t");
                    sw.Write(item.SubItems[4].Text + "\t\t");
                    sw.Write(item.SubItems[6].Text + "\t\t\n");
                    sw.WriteLine();
                }
                sw.WriteLine("----------------------------------------------------------------------------------------------------------------");
                sw.WriteLine("Thành tiền : \t\t\t\t\t\t\t\t\t\t\t\t\t" + this.ThanhTien);
                sw.WriteLine("Thuế VAT : \t\t\t\t\t\t\t\t\t\t\t\t\t\t" + this.ThueVAT);
                sw.WriteLine("Phí dịch vụ : \t\t\t\t\t\t\t\t\t\t\t\t\t\t" + this.PhiDichVu);
                sw.WriteLine("Giảm giá  : \t\t\t\t\t\t\t\t\t\t\t\t\t\t" + this.GiamGia2);
                sw.WriteLine("Tổng tiền : \t\t\t\t\t\t\t\t\t\t\t\t\t" + this.TongTien);
            }


            try
            {

                System.Diagnostics.Process.Start("..\\..\\Bills\\" + FileName + "");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}