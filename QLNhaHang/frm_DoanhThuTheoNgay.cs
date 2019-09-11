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
using System.Collections;

namespace QLCaPheProject
{
    public partial class frm_DoanhThuTheoNgay : DevExpress.XtraEditors.XtraForm
    {
        BaseFunctions<Orders> objOrder = new BaseFunctions<Orders>();
        List<Orders> ListOrder = new List<Orders>();
        public frm_DoanhThuTheoNgay()
        {
            InitializeComponent();
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            this.listViewEx1.Items.Clear();
            DateTime Time = DateTime.Now;
            if (rdHomNay.Checked)
            {
                Time = DateTime.Now;
            }
            if (rdHomQua.Checked)
            {
                Time = Time.AddDays(-1);
            }
            if (rdNgayKhac.Checked)
            {
                Time = this.dateNavigator_Ngay.DateTime;
            }
            ListOrder = objOrder.SelectAll();
            int STT = 0;
            float TongTien = 0;
            for (int i = 0; i < ListOrder.Count; i++)
            {
                
                if(ListOrder[i].DateCreated.ToShortDateString()==Time.ToShortDateString())
                {
                    ListViewItem item = new ListViewItem(STT.ToString());
                    item.SubItems.Add(ListOrder[i].OrderID.ToString());
                    item.SubItems.Add(ListOrder[i].DateCreated.ToShortTimeString());
                    item.SubItems.Add(ListOrder[i].UserName);
                    item.SubItems.Add(Converts.ChuyenDoiTienTeVietNam(ListOrder[i].TotalMoney));
                    TongTien += ListOrder[i].TotalMoney;
                    this.listViewEx1.Items.Add(item);
                    STT++;
                }

            }
            this.lblThongKe.Text = "Số bàn : " + STT + " , thu về được : " + Converts.ChuyenDoiTienTeVietNam(TongTien);

        }

        private void frm_DoanhThuTheoNgay_Load(object sender, EventArgs e)
        {
           // MessageBox.Show(Converts.ReturnFloat("1.000.000").ToString());
            this.dateNavigator_Ngay.DateTime = DateTime.Now;
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            frm_GioiThieu f = new frm_GioiThieu();
            f.ShowDialog();
        }

        private void office2007StartButton1_Click(object sender, EventArgs e)
        {

        }
    }
}