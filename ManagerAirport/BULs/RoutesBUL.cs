using ManagerAirport.DALs;
using ManagerAirport.DTOs;

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
