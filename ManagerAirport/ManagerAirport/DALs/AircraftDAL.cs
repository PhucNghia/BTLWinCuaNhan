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
    class AircraftDAL : RootDALs
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
    }
}
