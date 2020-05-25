using ManagerAirport.DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ManagerAirport.DALs
{
    public class SchedulesDAL : RootDALs
    {
        public SchedulesDAL() : base() { }

        public List<ScheduleManagersDTO> getList() // Trả về 1 ds Schedule
        {
            // Tạo 1 biến danh sách ScheduleManagers để lưu trữ
            List<ScheduleManagersDTO> schedules = new List<ScheduleManagersDTO>();
            try
            {
                conn.Open();
                string sql = "select DateFlight, TimeFlight, fromAirport.IATAcode as frmAirIATACode, " +
                    "toAirport.IATAcode as toAirIATACode, FlightNumber, Aircrafts.AircraftID, " +
                    "EconomyPrice, Confirmed, Routes.RouteID, AircraftName, SchedulesID from Schedules " +
                    "join Routes on Schedules.RouteID=Routes.RouteID " +
                    "join Airports as fromAirport on Routes.ArrivalAirportID=fromAirport.AirportID " +
                    "join Airports as toAirport on Routes.DepartureAirportID=toAirport.AirportID " +
                    "join Aircrafts on Schedules.AircraftID=Aircrafts.AircraftID";

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    float economyPrice = float.Parse(dr["EconomyPrice"].ToString().Trim());
                    float bussinessPrice = economyPrice * 35 / 100 + economyPrice;
                    float firstClassPrice = bussinessPrice * 30 / 100 + bussinessPrice;

                    ScheduleManagersDTO schedule = new ScheduleManagersDTO();
                    schedule.Date = DateTime.Parse(dr["DateFlight"].ToString().Trim());
                    schedule.Time = DateTime.Parse(dr["TimeFlight"].ToString().Trim());
                    schedule.From = dr["frmAirIATACode"].ToString().Trim();
                    schedule.To = dr["toAirIATACode"].ToString().Trim();
                    schedule.FlightNumber = dr["FlightNumber"].ToString().Trim();
                    schedule.AircraftID = dr["AircraftID"].ToString().Trim();
                    schedule.EconomyPrice = economyPrice;
                    schedule.BusinessPrice = bussinessPrice;
                    schedule.FirstClassPrice = firstClassPrice;
                    schedule.Confirmed = int.Parse(dr["Confirmed"].ToString().Trim());
                    schedule.RoutesID = dr["RouteID"].ToString().Trim();
                    schedule.AircraftName = dr["AircraftName"].ToString().Trim();
                    schedule.SchedulesID = dr["SchedulesID"].ToString().Trim();

                    schedules.Add(schedule);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }

            return schedules;
        }

        public void updateSchedule(SchedulesDTO schedule)
        {
            try
            {
                conn.Open();
                string sql = "update Schedules set EconomyPrice = @economyPrice, " +
                    "DateFlight = @dateFlight, TimeFlight = @timeFlight where SchedulesID = @scheduleID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("dateFlight", DateTime.Parse(schedule.Date));
                cmd.Parameters.AddWithValue("timeFlight", schedule.Time);
                cmd.Parameters.AddWithValue("economyPrice", schedule.EconomyPrice);
                cmd.Parameters.AddWithValue("scheduleID", schedule.ScheduleID);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        public void updateConfirmed(SchedulesDTO schedule)
        {
            try
            {
                conn.Open();
                string sql = "update Schedules set Confirmed = @confirmed where SchedulesID = @scheduleID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("scheduleID", schedule.ScheduleID);
                cmd.Parameters.AddWithValue("confirmed", schedule.Confirmed);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        public List<ScheduleManagersDTO> search(ScheduleManagersDTO scheduleManager,
            RoutesDTO route, string order)
        {
            // Tạo 1 biến danh sách ScheduleManagers để lưu trữ
            List<ScheduleManagersDTO> schedules = new List<ScheduleManagersDTO>();
            try
            {
                conn.Open();
                string sql = "select DateFlight, TimeFlight, fromAirport.IATAcode as frmAirIATACode, " +
                    "toAirport.IATAcode as toAirIATACode, FlightNumber, Aircrafts.AircraftID, " +
                    "EconomyPrice, Confirmed, Routes.RouteID, AircraftName, SchedulesID from Schedules " +
                    "join Routes on Schedules.RouteID=Routes.RouteID " +
                    "join Airports as fromAirport on Routes.ArrivalAirportID=fromAirport.AirportID " +
                    "join Airports as toAirport on Routes.DepartureAirportID=toAirport.AirportID " +
                    "join Aircrafts on Schedules.AircraftID=Aircrafts.AircraftID " +
                    "where Routes.ArrivalAirportID = @arrivalID " +
                    "OR Routes.DepartureAirportID = @departureID " +
                    "OR DateFlight = @outbound " +
                    "OR FlightNumber = @flightNumber " +
                    "ORDER BY " + order + " DESC";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("arrivalID", route.ArrivalAirportID);
                cmd.Parameters.AddWithValue("departureID", route.DepartureAirportID);
                cmd.Parameters.AddWithValue("outbound", scheduleManager.Date.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("flightNumber", scheduleManager.FlightNumber);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    float economyPrice = float.Parse(dr["EconomyPrice"].ToString().Trim());
                    float bussinessPrice = economyPrice * 35 / 100 + economyPrice;
                    float firstClassPrice = bussinessPrice * 30 / 100 + bussinessPrice;

                    ScheduleManagersDTO schedule = new ScheduleManagersDTO();
                    schedule.Date = DateTime.Parse(dr["DateFlight"].ToString().Trim());
                    schedule.Time = DateTime.Parse(dr["TimeFlight"].ToString().Trim());
                    schedule.From = dr["frmAirIATACode"].ToString().Trim();
                    schedule.To = dr["toAirIATACode"].ToString().Trim();
                    schedule.FlightNumber = dr["FlightNumber"].ToString().Trim();
                    schedule.AircraftID = dr["AircraftID"].ToString().Trim();
                    schedule.EconomyPrice = economyPrice;
                    schedule.BusinessPrice = bussinessPrice;
                    schedule.FirstClassPrice = firstClassPrice;
                    schedule.Confirmed = int.Parse(dr["Confirmed"].ToString().Trim());
                    schedule.RoutesID = dr["RouteID"].ToString().Trim();
                    schedule.AircraftName = dr["AircraftName"].ToString().Trim();
                    schedule.SchedulesID = dr["SchedulesID"].ToString().Trim();

                    schedules.Add(schedule);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }

            return schedules;
        }
    }
}