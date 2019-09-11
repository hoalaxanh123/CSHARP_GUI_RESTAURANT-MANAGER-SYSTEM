using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using System.Data;
using System.Data.SqlClient;
namespace DataAccess
{
    public class Categories
    {
        public int CatID { get; set; }
        public string Name { get; set; }
        public string Descreption { get; set; }
        public Categories()
        {

        }
        public Categories(int CatID, string Name, string Descreption)
        {
            this.CatID = CatID;
            this.Name = Name;
            this.Descreption = Descreption;
        }
        public override string ToString()
        {
            return this.Name;
        }
    
    }
}
