using System;

namespace ManagerAirport.DTOs
{
    public class AircraftDTO
    {
        private String aircraftID;
        private String aircraftName;
        private String makeModel;
        private String totalSeats;
        private String economySeats;
        private String businessSeats;

        public AircraftDTO()
        {
        }

        public AircraftDTO(string aircraftID, string aircraftName, string makeModel, string totalSeats, string economySeats, string businessSeats)
        {
            this.aircraftID = aircraftID;
            this.aircraftName = aircraftName;
            this.makeModel = makeModel;
            this.totalSeats = totalSeats;
            this.economySeats = economySeats;
            this.businessSeats = businessSeats;
        }

        public string AircraftID { get => aircraftID; set => aircraftID = value; }
        public string AircraftName { get => aircraftName; set => aircraftName = value; }
        public string MakeModel { get => makeModel; set => makeModel = value; }
        public string TotalSeats { get => totalSeats; set => totalSeats = value; }
        public string EconomySeats { get => economySeats; set => economySeats = value; }
        public string BusinessSeats { get => businessSeats; set => businessSeats = value; }
    }
}
