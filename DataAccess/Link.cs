using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Link
    {
        private static string _ConnectionString = "";

        public static string ConnectionString
        {
            get
            {
                if (_ConnectionString == "")
                    _ConnectionString = "Server=localhost\\SQLEXPRESS;Database=QuanLyNhaHang;Integrated Security=true";
                return _ConnectionString;
            }

            
        }
    }
}
