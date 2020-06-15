using ManagerAirport.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
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
                    "EconomyPrice, Confirmed, Routes.RoutesID, AircraftName, SchedulesID from Schedules " +
                    "join Routes on Schedules.RoutesID=Routes.RoutesID " +
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
                    schedule.RoutesID = dr["RoutesID"].ToString().Trim();
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
                cmd.Parameters.AddWithValue("dateFlight", schedule.Date);
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

        public void updateWhenImport(SchedulesDTO schedule)
        {
            try
            {
                conn.Open();
                string sql = "update Schedules set DateFlight = @dateFlight, TimeFlight = @timeFlight, " +
                    "AircraftID = @aircraftID, FlightNumber = @flightNumber, EconomyPrice = @economyPrice, " +
                    "Confirmed = @confirmed where SchedulesID = @scheduleID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("dateFlight", schedule.Date);
                cmd.Parameters.AddWithValue("timeFlight", schedule.Time);
                cmd.Parameters.AddWithValue("aircraftID", schedule.AircraftID);
                cmd.Parameters.AddWithValue("flightNumber", schedule.FlightNumber);
                cmd.Parameters.AddWithValue("economyPrice", schedule.EconomyPrice);
                cmd.Parameters.AddWithValue("confirmed", schedule.Confirmed);
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
                    "EconomyPrice, Confirmed, Routes.RoutesID, AircraftName, SchedulesID from Schedules " +
                    "join Routes on Schedules.RoutesID=Routes.RoutesID " +
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
                    schedule.RoutesID = dr["RoutesID"].ToString().Trim();
                    schedule.AircraftName = dr["AircraftName"].ToString().Trim();
                    schedule.SchedulesID = dr["SchedulesID"].ToString().Trim();

                    schedules.Add(schedule);
                }
                conn.Close();
            }
            catch (Exception e)
            {
                conn.Close();
                MessageBox.Show(e.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return schedules;
        }

        public SchedulesDTO getSchedule(String flightNumber, String depatureDate)
        {
            SchedulesDTO schedule = new SchedulesDTO();
            try
            {
                conn.Open();
                string sql = "SELECT TOP 1 SchedulesID, RoutesID FROM schedules where FlightNumber = @flightNumber and DateFlight = @depatureDate";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("flightNumber", flightNumber);
                cmd.Parameters.AddWithValue("depatureDate", DateTime.Parse(depatureDate).ToString("yyyy-MM-dd"));
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    schedule.ScheduleID = dr["SchedulesID"].ToString().Trim();
                    schedule.RoutesID = dr["RoutesID"].ToString().Trim();
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }

            return schedule;
        }

        public String getLastID()
        {
            String scheduleID = null;
            try
            {
                conn.Open();
                string sql = "SELECT TOP 1 SchedulesID FROM schedules ORDER BY SchedulesID DESC";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    scheduleID = dr["SchedulesID"].ToString();
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }

            return scheduleID;
        }

        public void create(SchedulesDTO schedule)
        {
            try
            {
                conn.Open();
                string sql = "INSERT INTO Schedules VALUES(@id, @date, CONVERT(VARCHAR(8), @time,  108), @aircraftID, @routesID, @flightNumber, " +
                    "@economyPrice, @confirmed)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("id", schedule.ScheduleID);
                cmd.Parameters.AddWithValue("date", schedule.Date.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("time", schedule.Time);
                cmd.Parameters.AddWithValue("aircraftID", schedule.AircraftID);
                cmd.Parameters.AddWithValue("routesID", schedule.RoutesID);
                cmd.Parameters.AddWithValue("flightNumber", schedule.FlightNumber);
                cmd.Parameters.AddWithValue("economyPrice", schedule.EconomyPrice);
                cmd.Parameters.AddWithValue("confirmed", schedule.Confirmed);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                conn.Close();
                MessageBox.Show(e.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}