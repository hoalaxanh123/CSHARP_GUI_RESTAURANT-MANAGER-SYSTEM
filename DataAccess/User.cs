using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using System.Data.SqlClient;
using System.Data;
namespace DataAccess
{
    public class User
    {
 
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string RealName { get; set; }
        public string Avatar { get; set; }
        public int Administrators { get; set; }
        public DateTime BirthDay { get; set; }
        public string Address { get; set; }
        public string indentityCard { get; set; }

        public User()
        {

        }

        public static User GetUserByUserName(string UserName)
        {
            try
            {
                DataProvider.Instance2(Link.ConnectionString);
                User temp =CBO.FillObject<User>(DataProvider.Instance.ExecuteReader("User_GetByUserName", UserName));
                return temp;
            }
            catch
            {
                return null;
            }

        }
        public static bool XoaNguoiDung(string UserName)
        {

            try
            {
                DataProvider.Instance2(Link.ConnectionString);
                User temp = CBO.FillObject<User>(DataProvider.Instance.ExecuteReader("User_Delete", UserName));
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
