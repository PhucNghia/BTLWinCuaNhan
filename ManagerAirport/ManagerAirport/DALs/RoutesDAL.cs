using ManagerAirport.DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerAirport.DALs
{
    class RoutesDAL : RootDALs
    {
        public RoutesDAL() : base() { }

        public void update(RoutesDTO route)
        {
            try
            {
                conn.Open();
                string sql = "update Routes set DepartureAirportID = @from, ArrivalAirportID = @to where RouteID = @id ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("from", route.DepartureAirportID);
                cmd.Parameters.AddWithValue("to", route.ArrivalAirportID);
                cmd.Parameters.AddWithValue("id", route.RouteID);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                conn.Close();
            }
        }
    }
}
