using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerAirport.DTOs
{
    public class ScheduleManagersDTO
    {
        private String date;
        private String time;
        private String from;
        private String to;
        private String flightNumber;
        private String aircraftID;
        private String aircraftName;
        private float economyPrice;
        private float businessPrice;
        private float firstClassPrice;
        private int confirmed;
        private String routesID;
        private String schedulesID;

        public ScheduleManagersDTO()
        {
        }

        public ScheduleManagersDTO(string date, string time, string from, string to, string flightNumber, string aircraftID, string aircraftName, float economyPrice, float businessPrice, float firstClassPrice, int confirmed, string routesID, string schedulesID)
        {
            this.date = date;
            this.time = time;
            this.from = from;
            this.to = to;
            this.flightNumber = flightNumber;
            this.aircraftID = aircraftID;
            this.aircraftName = aircraftName;
            this.economyPrice = economyPrice;
            this.businessPrice = businessPrice;
            this.firstClassPrice = firstClassPrice;
            this.confirmed = confirmed;
            this.routesID = routesID;
            this.schedulesID = schedulesID;
        }

        public string Date { get => date; set => date = value; }
        public string Time { get => time; set => time = value; }
        public string From { get => from; set => from = value; }
        public string To { get => to; set => to = value; }
        public string FlightNumber { get => flightNumber; set => flightNumber = value; }
        public string AircraftID { get => aircraftID; set => aircraftID = value; }
        public string AircraftName { get => aircraftName; set => aircraftName = value; }
        public float EconomyPrice { get => economyPrice; set => economyPrice = value; }
        public float BusinessPrice { get => businessPrice; set => businessPrice = value; }
        public float FirstClassPrice { get => firstClassPrice; set => firstClassPrice = value; }
        public int Confirmed { get => confirmed; set => confirmed = value; }
        public string RoutesID { get => routesID; set => routesID = value; }
        public string SchedulesID { get => schedulesID; set => schedulesID = value; }
    }
}
