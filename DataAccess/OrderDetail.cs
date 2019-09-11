using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDetail
    {
        public int OrderDetailID { get; set; }
        public int OrderID { get; set; }
        public double UnitPrice { get; set; }
        public double Quantity { get; set; }
        public double Discount { get; set; }
        public OrderDetail()
        {

        }
        public static int Insert()
        {
            return 0;
        }
        public static int Update()
        {
            return 0;
        }
        public static int Delete()
        {
            return 0;
        }
        public static OrderDetail FindByID()
        {
            return null;
        }
    }
}
