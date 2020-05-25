using ManagerAirport.BULs;
using ManagerAirport.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerAirport.GUI
{
    public partial class frmScheduleEdit : Form
    {
        AirportsBUL airportsBUL = new AirportsBUL();
        AircraftsBUL aircraftsBUL = new AircraftsBUL();
        RoutesBUL routesBUL = new RoutesBUL();
        SchedulesBUL schedulesBUL = new SchedulesBUL();
        List<AirportsDTO> airportsFrom = new List<AirportsDTO>();
        List<AirportsDTO> airportsTo = new List<AirportsDTO>();
        ScheduleManagersDTO scheduleManager = new ScheduleManagersDTO();

        public frmScheduleEdit()
        {
            InitializeComponent();
            this.scheduleManager = frmMain.schedule;
        }

        private void frmScheduleEdit_Load(object sender, EventArgs e)
        {
            dtpDate.CustomFormat = "dd/MM/yyyy";
            dtpTime.CustomFormat = "HH:mm";
            dtpDate.Value = scheduleManager.Date;
            dtpTime.Value = scheduleManager.Time;

            airportsFrom = airportsBUL.getList();
            airportsTo = airportsBUL.getList();

            cbbFrom.DataSource = airportsFrom;
            cbbFrom.DisplayMember = "IATACode";
            cbbFrom.ValueMember = "AirportId";
            // tìm IATACode của sân bay đi
            int indexFrom = airportsFrom.FindIndex(airport => airport.IATACode == scheduleManager.From);
            cbbFrom.SelectedIndex = indexFrom;

            cbbTo.DataSource = airportsTo;
            cbbTo.DisplayMember = "IATACode";
            cbbTo.ValueMember = "AirportId";
            // tìm IATACode của sân bay đến
            int indexTo = airportsTo.FindIndex(airport => airport.IATACode == scheduleManager.To);
            cbbTo.SelectedIndex = indexTo;

            txtAircraft.Text = scheduleManager.AircraftName;
            txtEconomyPrice.Text = scheduleManager.EconomyPrice.ToString();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string from = cbbFrom.Text;
            string to = cbbTo.Text;
            if(from == to)
            {
                MessageBox.Show("Sân bay đi và Sân bay đên không được trùng nhau, mời bạn chọn lại");
                return;
            }

            AircraftDTO aircraft = new AircraftDTO();
            aircraft.AircraftName = txtAircraft.Text;
            aircraft.AircraftID = scheduleManager.AircraftID;

            RoutesDTO route = new RoutesDTO();
            route.ArrivalAirportID = airportsFrom.ElementAt(cbbFrom.SelectedIndex).AirportID;
            route.DepartureAirportID = airportsTo.ElementAt(cbbTo.SelectedIndex).AirportID;
            route.RouteID = scheduleManager.RoutesID;
            
            SchedulesDTO schedule = new SchedulesDTO();
            schedule.Date = dtpDate.Value.ToString();
            schedule.Time = dtpTime.Value.ToString();
            schedule.EconomyPrice = float.Parse(txtEconomyPrice.Text);
            schedule.ScheduleID = scheduleManager.SchedulesID;

            try
            {
                aircraftsBUL.update(aircraft);
                routesBUL.update(route);
                schedulesBUL.updateSchedule(schedule);
                frmMain.schedules = schedulesBUL.getList();
                MessageBox.Show("Cập nhật thành công");
            } catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            this.Close();
        }
    }
}
