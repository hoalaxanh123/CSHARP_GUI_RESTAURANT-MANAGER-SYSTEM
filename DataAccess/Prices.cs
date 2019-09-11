using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core;
namespace DataAccess
{
    public class Prices
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public float Price { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }

        public Prices()
        {

        }
        public Prices(int ID, int ProductID, float Price, DateTime DateStart, DateTime DateEnd)
        {
            this.ID = ID;
            this.ProductID = ProductID;
            this.Price = Price;
            this.DateStart = DateStart;
            this.DateEnd = DateEnd;
        }
        public static int DeleteByProductID(int ID)
        {
            return SqlDataProvider.Instance.ExecuteNonQuery("Prices_DeleteByProductID", ID);
        }
        public static float GetPriceByDateAndProductID(DateTime date,int ProductID)
        {
            try
            {
                return float.Parse(SqlDataProvider.Instance.ExecuteScalar("Prices_GetPriceByIDAndDate", ProductID,date).ToString());
            }
            catch 
            {

                return -1;
            }
           
        }





    }
}
