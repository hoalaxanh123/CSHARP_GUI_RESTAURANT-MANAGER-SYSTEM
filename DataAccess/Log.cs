using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
namespace DataAccess
{
   public class Log
    {

        public int ID { get; set; }
        public string UserName { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        
        public Log()
        {

        }
        public Log( string UserName, string Description, DateTime Date)
        {
            this.ID = 1;
            this.UserName = UserName;
            this.Description = Description;
            this.Date = Date;
        }
        public static int XoaToanBo()
        {
            return SqlDataProvider.Instance.ExecuteNonQuery("Log_DeleteAll");
        }
      
    }
}
