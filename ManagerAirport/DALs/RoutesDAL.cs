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
                string sql = "update Routes set DepartureAirportID = @from, ArrivalAirportID = @to where RoutesID = @id ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("from", route.DepartureAirportID);
                cmd.Parameters.AddWithValue("to", route.ArrivalAirportID);
                cmd.Parameters.AddWithValue("id", route.RoutesID);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        public String getRoutesID(String from, String to)
        {
            String routesID = null;
            try
            {
                conn.Open();
                string sql = "SELECT TOP 1 RoutesID FROM Routes " +
                    "JOIN Airports AS fromAirport ON Routes.DepartureAirportID = fromAirport.AirportID " +
                    "JOIN Airports AS toAirport ON Routes.ArrivalAirportID = toAirport.AirportID " +
                    "WHERE fromAirport.IATAcode = @from and toAirport.IATAcode = @to";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("from", from);
                cmd.Parameters.AddWithValue("to", to);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    routesID = dr["RoutesID"].ToString().Trim();
                }
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }

            return routesID;
        }

    }
}
