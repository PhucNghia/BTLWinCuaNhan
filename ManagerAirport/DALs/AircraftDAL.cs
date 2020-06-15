using ManagerAirport.DTOs;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ManagerAirport.DALs
{
    public class AircraftDAL : RootDALs
    {
        public AircraftDAL() : base() { }

        public void update(AircraftDTO aircraft)
        {
            try
            {
                conn.Open();
                string sql = "update Aircrafts set AircraftName = @aircraftName where AircraftID = @aircraftID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("aircraftName", aircraft.AircraftName);
                cmd.Parameters.AddWithValue("aircraftID", aircraft.AircraftID);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                conn.Close();
            }
        }

        public String getAircraftID(String aircraftID)
        {
            String ID = null;
            try
            {
                conn.Open();
                string sql = "SELECT TOP 1 AircraftID FROM Aircrafts WHERE AircraftID = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id", aircraftID);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ID = dr["AircraftID"].ToString().Trim();
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }

            return ID;
        }
    }
}
