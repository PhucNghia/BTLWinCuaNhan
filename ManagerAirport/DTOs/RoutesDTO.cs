using System;

namespace ManagerAirport.DTOs
{
    public class RoutesDTO
    {
        private String routesID;
        private String departureAirportID;
        private string arrivalAirportID;
        private string distance;
        private String flightTime;

        public RoutesDTO()
        {
        }

        public RoutesDTO(string routesID, string departureAirportID, string arrivalAirportID, string distance, string flightTime)
        {
            this.routesID = routesID;
            this.departureAirportID = departureAirportID;
            this.arrivalAirportID = arrivalAirportID;
            this.distance = distance;
            this.flightTime = flightTime;
        }

        public string RoutesID { get => routesID; set => routesID = value; }
        public string DepartureAirportID { get => departureAirportID; set => departureAirportID = value; }
        public string ArrivalAirportID { get => arrivalAirportID; set => arrivalAirportID = value; }
        public string Distance { get => distance; set => distance = value; }
        public string FlightTime { get => flightTime; set => flightTime = value; }
    }
}
