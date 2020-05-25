using ManagerAirport.BULs;
using ManagerAirport.DTOs;
using ManagerAirport.GUI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerAirport
{
    public partial class frmMain : Form
    {
        SchedulesBUL schedulesBUL = new SchedulesBUL();
        public static List<ScheduleManagersDTO> schedules = new List<ScheduleManagersDTO>();
        public static ScheduleManagersDTO schedule = new ScheduleManagersDTO();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            schedules = schedulesBUL.getList();
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
                    dt.Rows.Add(schedule.Date, schedule.Time, schedule.From, schedule.To, 
                        schedule.FlightNumber, schedule.AircraftName, schedule.EconomyPrice, 
                        schedule.BusinessPrice, schedule.FirstClassPrice);
                }
            }
            dgv.DataSource = dt;
            setBackground();
        }

        public static void loadData()
        {
            
            //schedules = schedulesBUL.getList();
        }

        private void btnCancelFlight_Click(object sender, EventArgs e)
        {

        }

        private void setBackground()
        {
            if(schedules == null) { return; }
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

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < schedules.Count)
            {
                if (schedules.ElementAt(e.RowIndex).Confirmed == 0)
                {
                    btnCancelFlight.Text = "Confirm Flight";
                }
                else
                {
                    btnCancelFlight.Text = "Cancel Flight";
                }
            }
        }

        private void btnEditFlight_Click(object sender, EventArgs e)
        {
            schedule = schedules.ElementAt(dgv.CurrentCell.RowIndex);
            frmScheduleEdit frmEdit = new frmScheduleEdit();
            if (schedule.Confirmed == 1)
            {
                frmEdit.ShowDialog();
                this.Hide();
            } else
            {
                MessageBox.Show("Chuyến bay nay đã bị hủy, vui lòng chọn 'Confirm Flight'");
            }
        }
    }
}
