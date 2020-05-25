using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerAirport.GUI
{
    class AirportsDTO
    {
        private String airportID;
        private String countryID;
        private String iATACode;
        private String airportName;

        public AirportsDTO()
        {
        }

        public AirportsDTO(string airportID, string countryID, string iATACode, string airportName)
        {
            this.airportID = airportID;
            this.countryID = countryID;
            this.iATACode = iATACode;
            this.airportName = airportName;
        }

        public string AirportID { get => airportID; set => airportID = value; }
        public string CountryID { get => countryID; set => countryID = value; }
        public string IATACode { get => iATACode; set => iATACode = value; }
        public string AirportName { get => airportName; set => airportName = value; }
    }
}
