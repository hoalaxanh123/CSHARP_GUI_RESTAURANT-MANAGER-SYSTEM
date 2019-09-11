using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
namespace DataAccess
{
    public class Products
    {
        public int ProductID { get; set; }
        public int CatId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public string Unit { get; set; }
        public bool Type { get; set; }
        public Products()
        {

        }
        public  Products(int ProductID, int CatId, string Name, string Description, string Image, string Unit,bool Type)
        {
            this.ProductID = ProductID;
            this.CatId = CatId;
            this.Name = Name;
            this.Description = Description;
            this.Type = Type;
            this.Image = Image;
            this.Unit = Unit;
        }
        public static List<Products>  SelectProductsByCatID(object catID)
        {
            return CBO.FillCollection<Products>(DataProvider.Instance.ExecuteReader("Products_GetByCatID", catID));
        }
        public static Products FindByID(int proID)
        {
            return CBO.FillObject<Products>(DataProvider.Instance.ExecuteReader("Products_FindByID", proID));
        }


    }
}
