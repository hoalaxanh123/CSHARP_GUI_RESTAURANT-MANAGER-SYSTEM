using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDetails
    {
        public int OrderDetailsID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        //Tên của sản phẩm
        public string Name { get; set; }
        //Giá sản phẩm
        public float UnitPrice { get; set; }
        //Giam Gia
        public float Discount { get; set; }

        //Số lượng
        public int Quantity { get; set; }
        //Thành tiền
        public float SubTotal { get; set; }
        public OrderDetails()
        {

        }
        public OrderDetails( int OrderID, int ProductID, float UnitPrice,float discount, int Quantity)
        {
            this.OrderDetailsID = 1;
            this.OrderID = OrderID;
            this.ProductID = ProductID;
            this.Name = Products.FindByID(ProductID).Name;
            this.UnitPrice = Prices.GetPriceByDateAndProductID(DateTime.Now,ProductID);
            this.Quantity = Quantity;
            this.Discount = Discount;
            this.SubTotal = this.UnitPrice * Quantity-Discount;
        }
        public static List<OrderDetails> GetByOrderID(int OrderID)
        {
            return CBO.FillCollection<OrderDetails>(SqlDataProvider.Instance.ExecuteReader("OrderDetails_GetByOrderID", OrderID));
        }
        public static int DeleteOrderID(int OrderID)
        {
            return SqlDataProvider.Instance.ExecuteNonQuery("OrderDetails_DeleteByOrderID", OrderID);
        }
        public static int Update(int ID,int Quantity,float UnitPrice)
        {
            return SqlDataProvider.Instance.ExecuteNonQuery("OrderDetails_Update", ID,Quantity, UnitPrice);
        }

    }
}
