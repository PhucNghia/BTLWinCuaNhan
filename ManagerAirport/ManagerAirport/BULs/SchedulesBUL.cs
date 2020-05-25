using ManagerAirport.DALs;
using ManagerAirport.DTOs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerAirport.BULs
{
    class SchedulesBUL
    {
        SchedulesDAL schedulesDAL = new SchedulesDAL();

        public List<ScheduleManagersDTO> getList() // trả về 1 ds schedulesDTO
        {
            return schedulesDAL.getList();
        }

        public void update(SchedulesDTO schedule)
        {
            schedulesDAL.update(schedule);
        }
    }
}
