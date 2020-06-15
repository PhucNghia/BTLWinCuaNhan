using System;

namespace ManagerAirport.DTOs
{
    public class SchedulesDTO
    {
        private String scheduleID;
        private DateTime date;
        private String time;
        private String aircraftID;
        private String routesID;
        private String flightNumber;
        private float economyPrice;
        private int confirmed;

        public SchedulesDTO()
        {
        }

        public SchedulesDTO(string scheduleID, DateTime date, String time, string aircraftID, string routesID, string flightNumber, float economyPrice, int confirmed)
        {
            this.scheduleID = scheduleID;
            this.date = date;
            this.time = time;
            this.aircraftID = aircraftID;
            this.routesID = routesID;
            this.flightNumber = flightNumber;
            this.economyPrice = economyPrice;
            this.confirmed = confirmed;
        }

        public string ScheduleID { get => scheduleID; set => scheduleID = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Time { get => time; set => time = value; }
        public string AircraftID { get => aircraftID; set => aircraftID = value; }
        public string RoutesID { get => routesID; set => routesID = value; }
        public string FlightNumber { get => flightNumber; set => flightNumber = value; }
        public float EconomyPrice { get => economyPrice; set => economyPrice = value; }
        public int Confirmed { get => confirmed; set => confirmed = value; }
    }
}

