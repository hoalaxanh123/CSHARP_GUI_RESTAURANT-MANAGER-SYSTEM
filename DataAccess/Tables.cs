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
    public class Tables
    {
        public int TableID { get; set; }
        public int TableNumber { get; set; }
        public string Location { get; set; }
        public int AmountOfPeople { get; set; }
        public Tables()
        {

        }

        public Tables(int TableID, int TableNumber, string Location, int AmountOfPeople)
        {
            this.TableID = TableID;
            this.TableNumber = TableNumber;
            this.Location = Location;
            this.AmountOfPeople = AmountOfPeople;
        }
        public static int AddWithOutput(Tables table)
        {
            SqlConnection cns = new SqlConnection(Link.ConnectionString);
            SqlCommand cmd = cns.CreateCommand();
            cmd.CommandText = "Tables_Insert";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("TableID", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("NumberOfTable", SqlDbType.Int).Value = table.TableNumber;
            cmd.Parameters.Add("Location", SqlDbType.NVarChar,50).Value = table.Location;
            cmd.Parameters.Add("NumberOfPeople", SqlDbType.Int).Value = table.AmountOfPeople;
            cns.Open();
            cmd.ExecuteNonQuery();
            int t =(int)cmd.Parameters["TableID"].Value;
            return t;
        }
    }
}

