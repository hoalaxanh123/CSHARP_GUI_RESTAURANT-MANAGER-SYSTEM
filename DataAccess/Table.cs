using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
namespace DataAccess
{
    public class Table
    {
        public int NumberOfTables { get; set; }
        public List<Products> ListProductsSelected { get; set; }
        public double Discount { get; set; }
        public DateTime TimeIn { get; set; }
        public int Area { get; set; }
        public bool Using { get; set; }

        public Table()
        {

        }
        
        public Table(int NumberOfTables, List<Products> ListProductsSelected, double Discount, DateTime TimeIn, int Area, bool Using)
        {
            this.NumberOfTables = NumberOfTables;
            this.ListProductsSelected = ListProductsSelected;
            this.Discount = Discount;
            this.TimeIn = TimeIn;
            this.Area = Area;
            this.Using = Using;
        }
        public Table FindTable(int NumberOfTable)
        {
            try
            {
                return CBO.FillObject<Table>(DataProvider.Instance.ExecuteReader("Table_FindByNumberOfTable", NumberOfTable));
            }
            catch
            {

                return null;
            }
        }
        public static int InsertUpdateDelete(int NumberOfTables, List<Products> ListProductsSelected, double Discount, double TotalMoney, DateTime TimeIn, int Area, bool Using)
        {
            return 0;
        }

    }
}
