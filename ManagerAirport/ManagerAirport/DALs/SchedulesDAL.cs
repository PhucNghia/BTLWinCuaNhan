using ManagerAirport.DTOs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerAirport.DALs
{
    class SchedulesDAL : RootDALs
    {        
        public SchedulesDAL() : base() { }

        public List<ScheduleManagersDTO> getList() // Trả về 1 ds Schedule
        {
            // Tạo 1 biến danh sách schedules để lưu trữ
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
                    schedule.Date = DateTime.Parse(dr["DateFlight"].ToString().Trim()).ToString("dd/MM/yyyy");
                    schedule.Time = DateTime.Parse(dr["TimeFlight"].ToString().Trim()).ToString("HH:mm");
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
            } catch(Exception)
            {
                conn.Close();
                return null;
            }

            return schedules;
        }

        public void update(SchedulesDTO schedule)
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
            catch (Exception e)
            {
                conn.Close();
            }
        }

        /*public List<ScheduleManagersDTO> getListByLinq()
        {
            DataDataContext db = new DataDataContext();
            List<ScheduleManagersDTO> list = (
                from schedule in db.Schedules
                join route in db.Routes on schedule.RouteID equals route.RouteID
                join aircraft in db.Aircrafts on schedule.AircraftID equals aircraft.AircraftID
                join fromAirport in db.Airports on route.DepartureAirportID equals fromAirport.AirportID
                join toAirport in db.Airports on route.ArrivalAirportID equals toAirport.AirportID
                select new ScheduleManagersDTO(
                    DateTime.Parse(schedule.DateFlight.ToString()).ToString("dd/MM/yyyy"),
                    DateTime.Parse(schedule.TimeFlight.ToString()).ToString("HH:mm"),
                    fromAirport.IATAcode,
                    toAirport.IATAcode,
                    schedule.FlightNumber,
                    aircraft.AircraftName,
                    (float)schedule.EconomyPrice,
                    (float)decimal.Round((decimal)(schedule.EconomyPrice * 35 / 100), 2),
                    (float)decimal.Round((decimal)(schedule.EconomyPrice * 30 / 100), 2),
                    (int)schedule.Confirmed)
                ).ToList();

            return list;
        }*/
    }
}
