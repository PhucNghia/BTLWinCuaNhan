using System;
using System.Data.SqlClient;

namespace ManagerAirport.DALs
{
    public class RootDALs
    {
        protected String connString = @"Data Source=DESKTOP-1LUT13O\SQLEXPRESS;Initial Catalog = QLAirport; Integrated Security = True";
        protected SqlConnection conn;
        public RootDALs()
        {
            conn = new SqlConnection(connString);
        }
    }
}
  