using ManagerAirport.DALs;
using ManagerAirport.DTOs;

namespace ManagerAirport.BULs
{
    class AircraftsBUL
    {
        AircraftDAL aircraftDAL = new AircraftDAL();
        public void update(AircraftDTO aircraft)
        {
            aircraftDAL.update(aircraft);
        }
    }
}
