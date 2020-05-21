using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerAirport
{
    public partial class frmMain : Form
    {
        SqlConnection conn;
        public frmMain()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //hiển thị dữ liệu trong data grid view
            //1.tạo, mở connection
            SqlConnection conn;
            string connString = @"Data Source=DESKTOP-63HOSBP\SQLEXPRESS;Initial Catalog=QLAirport;Integrated Security=True ";
            conn = new SqlConnection(connString);
            conn.Open();



        }

        private void btnCancelFlight_Click(object sender, EventArgs e)
        {

        }
    }
}
