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
    public partial class frm_DoanhThuTheoSanPham : DevExpress.XtraEditors.XtraForm
    {
        BaseFunctions<Categories> objCategories = new BaseFunctions<Categories>();
        BaseFunctions<Products> objProducts = new BaseFunctions<Products>();
        BaseFunctions<OrderDetails> objOrderDetails = new BaseFunctions<OrderDetails>();
        public frm_DoanhThuTheoSanPham()
        {
            InitializeComponent();
        }
        private void advTree1_NodeClick(object sender, DevComponents.AdvTree.TreeNodeMouseEventArgs e)
        {
            List<OrderDetails> listOrderDetails = objOrderDetails.SelectAll();
            if(e.Node.Name.Contains("Produt_"))
            {
                this.listViewEx1.Items.Clear();
                int ProductId = int.Parse(e.Node.Name.Split('_')[1]);
                int STT = 0;
                float TongTien = 0;
                for (int i = 0; i < listOrderDetails.Count; i++)
                {
                    if(listOrderDetails[i].ProductID==ProductId)
                    {
                        STT++;
                        ListViewItem item = new ListViewItem(STT.ToString());
                        item.SubItems.Add(listOrderDetails[i].OrderID.ToString());
                        item.SubItems.Add(listOrderDetails[i].Quantity.ToString());
                        item.SubItems.Add(Converts.ChuyenDoiTienTeVietNam(listOrderDetails[i].UnitPrice));
                        item.SubItems.Add(Converts.ChuyenDoiTienTeVietNam(listOrderDetails[i].SubTotal));
                        this.listViewEx1.Items.Add(item);
                        TongTien += listOrderDetails[i].SubTotal;
                    }
                }
                this.lblThongKE.Text = "Tổng số lượng bán  ra : " + STT + " , giúp thu vào : " + Converts.ChuyenDoiTienTeVietNam(TongTien);
            }
               
        }
        private void frm_DoanhThuTheoSanPham_Load(object sender, EventArgs e)
        {
            DevComponents.AdvTree.Node NodeMain = new DevComponents.AdvTree.Node();
            NodeMain.Text = "Loại món ";
            List<Categories> L = objCategories.SelectAll();
            List<Products> L1 = objProducts.SelectAll();
            foreach (Categories N in L)
            {
                DevComponents.AdvTree.Node NTD = new DevComponents.AdvTree.Node();
                NTD.Text = N.Name;
                NTD.Name = "Category_" + N.CatID;
                foreach (Products T in L1)
                {
                    if (T.CatId == N.CatID)
                    {
                        DevComponents.AdvTree.Node TD = new DevComponents.AdvTree.Node();
                        TD.Text = T.Name;
                        TD.Name = "Produt_" + T.ProductID;
                        NTD.Nodes.Add(TD);
                    }
                }
                NodeMain.Nodes.Add(NTD);
            }
            advTree1.Nodes.Clear();
            advTree1.Nodes.Add(NodeMain);
        }

    }
}