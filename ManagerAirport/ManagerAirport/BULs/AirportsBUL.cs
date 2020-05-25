using ManagerAirport.DALs;
using ManagerAirport.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
