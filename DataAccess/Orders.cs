using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
namespace DataAccess
{
    public class Orders
    {


        public int OrderID { get; set; }
        public int TableID { get; set; }
        public string UserName { get; set; }
        public DateTime DateCreated { get; set; }
        public float TaxVAT { get; set; }
        public float ServiceCharge { get; set; }
        public float Discount { get; set; }
        public float TotalMoney { get; set; }
        public Orders()
        {

        }
        public Orders(int TableID, string UserName, DateTime DateCreated, float TaxVAT,
            float ServiceCharge, float Discount, float TotalMoney)
        {
            this.TableID = TableID;
            this.UserName = UserName;
            this.DateCreated = DateCreated;
            this.TaxVAT = TaxVAT;
            this.ServiceCharge = ServiceCharge;
            this.Discount = Discount;
            this.TotalMoney = TotalMoney;
        }
        public static List<Orders> GetOrderByTableID(int TableID)
        {
            return CBO.FillCollection<Orders>(SqlDataProvider.Instance.ExecuteReader("Orders_GetOrderByTableID", TableID));
        }
    }
}
