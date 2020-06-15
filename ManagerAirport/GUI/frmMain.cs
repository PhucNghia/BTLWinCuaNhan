using ManagerAirport.BULs;
using ManagerAirport.DTOs;
using ManagerAirport.GUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ManagerAirport
{
    public partial class frmMain : Form
    {
        SchedulesBUL schedulesBUL = new SchedulesBUL();
        AirportsBUL airportsBUL = new AirportsBUL();
        public static List<ScheduleManagersDTO> schedules;
        public static ScheduleManagersDTO schedule = new ScheduleManagersDTO();
        public frmMain()
        {
            InitializeComponent();            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            schedules = schedulesBUL.getList();
            loadData();
            loadCombobox();

            // Disable sort in header column
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        public void loadData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Date");
            dt.Columns.Add("Time");
            dt.Columns.Add("From");
            dt.Columns.Add("To");
            dt.Columns.Add("Flight number");
            dt.Columns.Add("Aircraft");
            dt.Columns.Add("Economy price");
            dt.Columns.Add("Business price");
            dt.Columns.Add("First class price");

            if (schedules != null)
            {
                foreach (ScheduleManagersDTO schedule in schedules)
                {
                    dt.Rows.Add(schedule.Date.ToString("dd/MM/yyyy"), schedule.Time.ToString("HH:mm"), 
                        schedule.From, schedule.To, schedule.FlightNumber, schedule.AircraftName,
                        schedule.EconomyPrice, schedule.BusinessPrice, schedule.FirstClassPrice);
                }
            }
            dgv.DataSource = dt;
            setBackground();
        }

        private void setBackground()
        {
            if (schedules == null) { return; }
            int i = 0;
            foreach (ScheduleManagersDTO schedule in schedules)
            {
                if (schedule.Confirmed == 0)
                {
                    dgv.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                i++;
            }
        }

        private void loadCombobox()
        {
            List<AirportsDTO> airportsFrom = airportsBUL.getList();
            List<AirportsDTO> airportsTo = airportsBUL.getList();

            cbbFrom.DataSource = airportsFrom;
            cbbFrom.DisplayMember = "IATACode";
            cbbFrom.ValueMember = "AirportId";

            cbbTo.DataSource = airportsTo;
            cbbTo.DisplayMember = "IATACode";
            cbbTo.ValueMember = "AirportId";
            cbbTo.SelectedIndex = 1;

            dtpOutbound.CustomFormat = "dd/MM/yyyy";
            cbbSortBy.SelectedIndex = 0;
        }

        private void btnConfirmFlight_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentCell == null) { return; }

            schedule = schedules.ElementAt(dgv.CurrentCell.RowIndex);
            SchedulesDTO schedulesDTO = new SchedulesDTO();
            if(schedule.Confirmed == 1)
            {
                schedulesDTO.Confirmed = 0;
                btnConfirmlFlight.Text = "Confirm Flight";
            } else
            {
                schedulesDTO.Confirmed = 1;
                btnConfirmlFlight.Text = "Cancel Flight";
            }
            schedulesDTO.ScheduleID = schedule.SchedulesID;

            schedulesBUL.updateConfirmed(schedulesDTO);

            schedules = schedulesBUL.getList();
            this.loadData();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < schedules.Count) // ktra khi ấn vào ô header
            {
                if (schedules.ElementAt(e.RowIndex).Confirmed == 0)
                {
                    btnConfirmlFlight.Text = "Confirm Flight";
                }
                else
                {
                    btnConfirmlFlight.Text = "Cancel Flight";
                }
            }
        }

        private void btnEditFlight_Click(object sender, EventArgs e)
        {
            if(dgv.CurrentCell == null) { return; }

            schedule = schedules.ElementAt(dgv.CurrentCell.RowIndex);
            frmScheduleEdit frmEdit = new frmScheduleEdit();
            if (schedule.Confirmed == 1)
            {
                frmEdit.ShowDialog();
                this.loadData();
            } else
            {
                MessageBox.Show("Chuyến bay nay đã bị hủy, vui lòng chọn 'Confirm Flight'");
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            RoutesDTO route = new RoutesDTO();
            ScheduleManagersDTO scheduleManager = new ScheduleManagersDTO();
            string order;
     
            route.ArrivalAirportID = cbbFrom.SelectedValue.ToString();
            route.DepartureAirportID = cbbTo.SelectedValue.ToString();
            if (cbbSortBy.SelectedItem.ToString() == "Price")
            {
                order = "EconomyPrice";
            }
            else if (cbbSortBy.SelectedItem.ToString() == "Confirmed")
            {
                order = "Confirmed";
            }
            else
            {
                order = "DateFlight";
            }
            dtpOutbound.CustomFormat = "dd/MM/yyyy";
            scheduleManager.Date = dtpOutbound.Value;
            scheduleManager.FlightNumber = txtFlightNumber.Text;

            if (cbbFrom.SelectedValue.Equals(cbbTo.SelectedValue))
            {
                MessageBox.Show("Sân bay đi và Sân bay đến không được trùng nhau");
            } else
            {
                schedules = schedulesBUL.search(scheduleManager, route, order);
                this.loadData();
            }
        }

        private void btnImportChanges_Click(object sender, EventArgs e)
        {
            frmApplyScheduleChanges frmApplySchedule = new frmApplyScheduleChanges();
            frmApplySchedule.ShowDialog();
            schedules = schedulesBUL.getList();
            this.loadData();
        }
    }
}
