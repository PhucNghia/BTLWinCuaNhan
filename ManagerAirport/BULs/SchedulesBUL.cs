using ManagerAirport.DALs;
using ManagerAirport.DTOs;
using ManagerAirport.GUI;
using System;
using System.Collections.Generic;

namespace ManagerAirport.BULs
{
    class SchedulesBUL
    {
        SchedulesDAL schedulesDAL = new SchedulesDAL();
        AircraftDAL aircraftDAL = new AircraftDAL();
        RoutesDAL routesDAL = new RoutesDAL();
        AirportsDAL airportsDAL = new AirportsDAL();
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

        public List<List<int>> importSchedule(String[][] data)
        {
            // tạo ra các danh sách status khi import.
            // mỗi ds status bao gồm: phần tử đầu tiên là status, các phần tử còn lại là dòng trong excel ứng vs mỗi status
            List<int> success = new List<int> { 1 };
            List<int> duplicate = new List<int> { 0 };
            List<int> recordMissing = new List<int> { -1 };
            List<int> aircraftInvalid = new List<int> { -2 };
            List<int> routesInvalid = new List<int> { -3 };
            List<int> recordNotFound = new List<int> { -4 };
            List<List<int>> statusImport = new List<List<int>>();   // trả về 1 danh sách bao gồm các danh sách status

            for (int i = 0; i < data.Length; i++)
            {
                bool isContinue = false;
                for (int j = 0; j < data[i].Length; j++)
                {
                    if (data[i][j] == null)  // check thiếu dữ liệu
                    {
                        recordMissing.Add(i + 2); // thêm dòng excel bị lỗi. dữ liệu tính từ dòng thứ 2 trong excel => (+2)
                        isContinue = true;
                    }
                }
                if (isContinue) { continue; }

                String operation = data[i][0];
                String date = data[i][1];
                String time = data[i][2];
                String from = data[i][3];
                String to = data[i][4];
                String flightNumber = data[i][5];
                String aircraft = data[i][6];
                float economyPrice;
                try { economyPrice = float.Parse(data[i][7]); } catch { economyPrice = 0; };
                int confirmed = data[i][8].Equals("OK") ? 1 : 0;

                SchedulesDTO schedule = schedulesDAL.getSchedule(flightNumber, date);
                String aircraftID = aircraftDAL.getAircraftID(aircraft);
                String routesID = routesDAL.getRoutesID(from, to);

                if (operation.Equals("ADD"))
                {
                    if (schedule.ScheduleID != null)  // check trùng bản ghi dựa vào flightNumber & date
                    {
                        duplicate.Add(i + 2);
                        continue;
                    }
                    else
                    {
                        if (aircraftID == null)  // check tồn tại Aircraft
                        {
                            aircraftInvalid.Add(i + 2);
                            continue;
                        }
                        else
                        {
                            if(routesID == null) // check tồn tại Routes
                            {
                                routesInvalid.Add(i + 2);
                                continue;
                            } 
                            else // thêm thành công
                            {
                                String lastScheduleID = schedulesDAL.getLastID(); // lấy id của bản ghi cuối cùng
                                String id = "S01";
                                if (lastScheduleID != null) 
                                {
                                    id = (int.Parse(lastScheduleID.Substring(1)) + 1).ToString(); // tăng id lên 1
                                    id = "S" + id.PadLeft(2, '0');
                                }
                                schedule.ScheduleID = id;
                                schedule.Date = DateTime.Parse(date);
                                schedule.Time = time;
                                schedule.RoutesID = routesID;
                                schedule.AircraftID = aircraftID;
                                schedule.FlightNumber = flightNumber;
                                schedule.EconomyPrice = economyPrice;
                                schedule.Confirmed = confirmed;

                                schedulesDAL.create(schedule);
                                success.Add(i + 2);
                            }
                        }
                    }
                }
                if (operation.Equals("EDIT"))
                {
                    if (schedule.ScheduleID == null)  // check tồn tại ghi dựa vào flightNumber & date
                    {
                        recordNotFound.Add(i + 2);
                        continue;
                    }
                    else
                    {
                        if (aircraftID == null)  // check tồn tại Aircraft
                        {
                            aircraftInvalid.Add(i + 2);
                            continue;
                        }
                        else
                        {
                            String fromAirportID = airportsDAL.getByIATAcode(from);
                            String toAirportID = airportsDAL.getByIATAcode(to);
                            if (fromAirportID == null || toAirportID == null)
                            {
                                routesInvalid.Add(i + 2);
                                continue;
                            }
                            else
                            {
                                schedule.ScheduleID = schedule.ScheduleID;
                                schedule.Date = DateTime.Parse(date);
                                schedule.Time = time;
                                schedule.RoutesID = routesID;
                                schedule.AircraftID = aircraftID;
                                schedule.FlightNumber = flightNumber;
                                schedule.EconomyPrice = economyPrice;
                                schedule.Confirmed = confirmed;
                                schedulesDAL.updateWhenImport(schedule);

                                RoutesDTO routes = new RoutesDTO();
                                routes.RoutesID = schedule.RoutesID;
                                routes.DepartureAirportID = fromAirportID;
                                routes.ArrivalAirportID = toAirportID;
                                routesDAL.update(routes);

                                success.Add(i + 2);
                            }
                        }
                    }
                }
            }
            statusImport.Add(success);
            statusImport.Add(duplicate);
            statusImport.Add(recordMissing);
            statusImport.Add(aircraftInvalid);
            statusImport.Add(routesInvalid);

            return statusImport;
        }
    }
}
