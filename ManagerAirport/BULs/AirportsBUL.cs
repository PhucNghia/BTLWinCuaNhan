using ManagerAirport.DALs;
using ManagerAirport.GUI;
using System.Collections.Generic;

namespace ManagerAirport.BULs
{
    class AirportsBUL
    {
        AirportsDAL airportsDAL = new AirportsDAL();

        public List<AirportsDTO> getList() // trả về 1 ds schedulesDTO
        {
            return airportsDAL.getList();
        }
    }
}
