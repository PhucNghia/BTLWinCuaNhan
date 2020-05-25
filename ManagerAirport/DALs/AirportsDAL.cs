using ManagerAirport.GUI;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ManagerAirport.DALs
{
    public class AirportsDAL : RootDALs
    {
        public AirportsDAL() : base() { }

        public List<AirportsDTO> getList() // Trả về 1 ds Airports
        {
            List<AirportsDTO> airports = new List<AirportsDTO>();

            try
            {
                conn.Open();
                string sql = "select AirportID, AirportName, IATACode from Airports";

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    AirportsDTO airport = new AirportsDTO();

                    airport.AirportID = dr["AirportID"].ToString().Trim();
                    airport.AirportName = dr["AirportName"].ToString().Trim();
                    airport.IATACode = dr["IATACode"].ToString().Trim();
                    airports.Add(airport);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }

            return airports;
        }
    }
}
