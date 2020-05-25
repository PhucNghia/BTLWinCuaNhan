using ManagerAirport.DALs;
using ManagerAirport.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerAirport.BULs
{
    class RoutesBUL
    {
        RoutesDAL routesDAL = new RoutesDAL();
        public void update(RoutesDTO route)
        {
            routesDAL.update(route);
        }
    }
}
