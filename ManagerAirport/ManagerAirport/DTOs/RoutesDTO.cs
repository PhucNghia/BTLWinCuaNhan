using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerAirport.DTOs
{
    class RoutesDTO
    {
        private String routeID;
        private String departureAirportID;
        private string arrivalAirportID;
        private string distance;
        private String flightTime;

        public RoutesDTO()
        {
        }

        public RoutesDTO(string routeID, string departureAirportID, string arrivalAirportID, string distance, string flightTime)
        {
            this.routeID = routeID;
            this.departureAirportID = departureAirportID;
            this.arrivalAirportID = arrivalAirportID;
            this.distance = distance;
            this.flightTime = flightTime;
        }

        public string RouteID { get => routeID; set => routeID = value; }
        public string DepartureAirportID { get => departureAirportID; set => departureAirportID = value; }
        public string ArrivalAirportID { get => arrivalAirportID; set => arrivalAirportID = value; }
        public string Distance { get => distance; set => distance = value; }
        public string FlightTime { get => flightTime; set => flightTime = value; }
    }
}
