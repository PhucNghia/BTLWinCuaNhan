using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerAirport.DALs
{
    class RootDALs
    {
        protected String connString = @"Data Source=DESKTOP-1LUT13O\SQLEXPRESS;Initial Catalog = QLAirport; Integrated Security = True";
        protected SqlConnection conn;
        public RootDALs()
        {
            conn = new SqlConnection(connString);
        }
    }
}
  