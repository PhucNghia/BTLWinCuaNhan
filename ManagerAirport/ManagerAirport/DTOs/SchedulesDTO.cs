using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerAirport.DTOs
{
    class SchedulesDTO
    {
        private String scheduleID;
        private String date;
        private String time;
        private String aircraftID;
        private String routerID;
        private String flightNumber;
        private float economyPrice;
        private string confirmed;

        public string ScheduleID { get => scheduleID; set => scheduleID = value; }
        public string Date { get => date; set => date = value; }
        public string Time { get => time; set => time = value; }
        public string AircraftID { get => aircraftID; set => aircraftID = value; }
        public string RouterID { get => routerID; set => routerID = value; }
        public string FlightNumber { get => flightNumber; set => flightNumber = value; }
        public float EconomyPrice { get => economyPrice; set => economyPrice = value; }
        public string Confirmed { get => confirmed; set => confirmed = value; }

        public SchedulesDTO(string scheduleID, string date, string time, string aircraftID, string routerID, string flightNumber, float economyPrice, string confirmed)
        {
            this.scheduleID = scheduleID;
            this.date = date;
            this.time = time;
            this.aircraftID = aircraftID;
            this.routerID = routerID;
            this.flightNumber = flightNumber;
            this.economyPrice = economyPrice;
            this.confirmed = confirmed;
        }

        public SchedulesDTO()
        {
        }
    }
}

