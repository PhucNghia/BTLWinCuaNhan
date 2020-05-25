using ManagerAirport.DALs;
using ManagerAirport.DTOs;
using System.Collections.Generic;

namespace ManagerAirport.BULs
{
    class SchedulesBUL
    {
        SchedulesDAL schedulesDAL = new SchedulesDAL();

        public List<ScheduleManagersDTO> getList() // trả về 1 ds ScheduleManagersDTO
        {
            return schedulesDAL.getList();
        }

        public void updateSchedule(SchedulesDTO schedule)
        {
            schedulesDAL.updateSchedule(schedule);
        }

        public void updateConfirmed(SchedulesDTO schedule)
        {
            schedulesDAL.updateConfirmed(schedule);
        }

        public List<ScheduleManagersDTO> search(ScheduleManagersDTO scheduleManager,
            RoutesDTO route, string order)
        {
            return schedulesDAL.search(scheduleManager, route, order);
        }
    }
}
