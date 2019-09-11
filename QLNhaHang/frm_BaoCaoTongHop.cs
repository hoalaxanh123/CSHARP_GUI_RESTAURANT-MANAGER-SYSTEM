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
    public partial class frm_BaoCaoTongHop : DevExpress.XtraEditors.XtraForm
    {
        BaseFunctions<Orders> objOrders = new BaseFunctions<Orders>();
        public frm_BaoCaoTongHop()
        {
            InitializeComponent();
        }

        private void frm_BaoCaoTongHop_Load(object sender, EventArgs e)
        {
            slider1.Value = DateTime.Now.Month;
            AddYear();
            ThongKe();
            XuLyBieuDo();
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            frm_GioiThieu f = new frm_GioiThieu();
            f.ShowDialog();
        }
        private void AddYear()
        {
            for (int i = DateTime.Now.Year; i >= DateTime.Now.Year - 10; i--)
                cbbNam.Items.Add(i.ToString());
            cbbNam.SelectedIndex = 0;
        }
        private void slider1_ValueChanged(object sender, EventArgs e)
        {
            lblThang.Text = "Tháng: " + slider1.Value.ToString();

            ThongKe();
        }
        private void ThongKe()
        {
            listViewEx1.Items.Clear();
            if (cbbNam.SelectedItem != null)
            {
                int Thang = slider1.Value;
                int Nam = int.Parse(cbbNam.SelectedItem.ToString());
                List<Orders> L = objOrders.SelectAll();
                int count = 1;

                int SLmonan = 0;
                long tongTien = 0;
                foreach (Orders c in L)
                {
                    if (c.DateCreated.Year == Nam && c.DateCreated.Month == Thang)
                    {
                        List<OrderDetails> L1 = OrderDetails.GetByOrderID(c.OrderID);
                    
                        foreach (OrderDetails c1 in L1)
                            if (c1.OrderID == c.OrderID)
                            {
                                ListViewItem Item = listViewEx1.Items.Add(count.ToString());
                                count++;

                                SLmonan++;
                                Products TD = Products.FindByID(c1.ProductID);
                                Item.SubItems.Add(TD.Name);

                                Item.SubItems.Add(c1.Quantity.ToString());
                                Item.SubItems.Add(Converts.ChuyenDoiTienTeVietNam(c1.UnitPrice));
                                Item.SubItems.Add(Converts.ChuyenDoiTienTeVietNam(c1.SubTotal));
                                //MessageBox.Show(tongTien.ToString());
                                tongTien += (long)c1.SubTotal;
                            }
                    }
                }

                if (tongTien != 0)
                {
                    ListViewItem Item1 = listViewEx1.Items.Add(" ");
                    Item1.SubItems.Add("");
                    Item1.SubItems.Add("");
                    ListViewItem.ListViewSubItem sub = Item1.SubItems.Add("Tổng ");
                    sub.ForeColor = Color.Blue;
                    sub.Font = new Font(new FontFamily("Tahoma"), 10f, FontStyle.Bold);
                    ListViewItem.ListViewSubItem sub1 = Item1.SubItems.Add(Converts.ChuyenDoiTienTeVietNam(tongTien));
                    sub1.ForeColor = Color.Blue;
                    sub1.Font = new Font(new FontFamily("Tahoma"), 10f, FontStyle.Bold);

                }

            }
        }

        private void cbbNam_SelectedIndexChanged(object sender, EventArgs e)
        {

            slider1.Value = DateTime.Now.Month;
            XuLyBieuDo();
        }
        private void XuLyBieuDo()
        {
            chartControl1.Series.Clear();
            DevExpress.XtraCharts.Series series = new DevExpress.XtraCharts.Series("THÁNG", DevExpress.XtraCharts.ViewType.Bar);
            chartControl1.Series.Add(series);

            // Generate a data table and bind the series to it.
            series.DataSource = CreateChartData(12);

            // Specify data members to bind the series.
            series.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
            series.ArgumentDataMember = "Argument";
            series.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
            series.ValueDataMembers.AddRange(new string[] { "Value" });
        }
        private DataTable CreateChartData(int rowCount)
        {
            // Create an empty table.
            DataTable table = new DataTable("Table1");

            // Add two columns to the table.
            table.Columns.Add("Argument", typeof(Int32));
            table.Columns.Add("Value", typeof(Int32));

            // Add data rows to the table.
            Random rnd = new Random();
            DataRow row = null;

            List<Orders> L = objOrders.SelectAll();
            for (int i = 1; i <= rowCount; i++)
            {
                row = table.NewRow();
                row["Argument"] = i;

                int Nam = int.Parse(cbbNam.SelectedItem.ToString());
                long tongTien = 0;
                foreach (Orders c in L)
                {
                    if (c.DateCreated.Year == Nam && c.DateCreated.Month == i)
                    {
                        List<OrderDetails> L1 = OrderDetails.GetByOrderID(c.OrderID);
                        foreach (OrderDetails c1 in L1)
                            {
                                tongTien += (long)c1.SubTotal;
                            }
                    }
                }
                row["Value"] = tongTien;
                table.Rows.Add(row);
            }
            return table;
        }
    }
}