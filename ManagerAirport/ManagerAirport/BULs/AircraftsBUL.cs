using ManagerAirport.DALs;
using ManagerAirport.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
