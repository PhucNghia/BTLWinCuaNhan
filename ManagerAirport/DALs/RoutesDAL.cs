using ManagerAirport.DTOs;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ManagerAirport.DALs
{
    public class RoutesDAL : RootDALs
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }
    }
}
