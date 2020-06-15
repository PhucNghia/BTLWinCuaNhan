using ManagerAirport.BULs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ManagerAirport.GUI
{
    public partial class frmApplyScheduleChanges : Form
    {
        OpenFileDialog fopen = new OpenFileDialog();    // Tạo đối tượng mở tập tin
        SchedulesBUL schedulesBUL = new SchedulesBUL();
        public frmApplyScheduleChanges()
        {
            InitializeComponent();
        }

        private void lblImport_Click(object sender, EventArgs e)
        {
            fopen.Filter = "(Tất cả các tệp)|*.*|(Các tệp excel)|*.xlsx";   // Tìm file có đuôi dạng excel
            fopen.ShowDialog();
        }

        private void txtImportPath_Click(object sender, EventArgs e)
        {
            fopen.Filter = "(Tất cả các tệp)|*.*|(Các tệp excel)|*.xlsx";   // Tìm file có đuôi dạng excel
            fopen.ShowDialog();
            if (fopen.FileName != null)
            {
                txtImportPath.Text = fopen.FileName;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (fopen.FileName != "")
            {
                Excel.Application app = new Excel.Application();    // Tạo đối tượng Exel
                Excel.Workbook wb = app.Workbooks.Open(fopen.FileName);     // Mở tệp Exel
                String[][] data;       // Mảng lưu giá trị trong Excel

                try
                {
                    Excel._Worksheet sheet = wb.Sheets[1];  // Lựa chọn sheet
                    Excel.Range range = sheet.UsedRange;    // Tham chiếu đến tất cả vùng dl có trong sheet

                    // Get số lượng rows và cols
                    int rows = range.Rows.Count - 1;    // trừ row header
                    int cols = range.Columns.Count;

                    data = new String[rows][];
                    for (int i = 0; i < rows; i++)
                        data[i] = new String[cols];

                    for (int r = 0; r < rows; r++)
                    {
                        for (int c = 0; c < cols; c++)
                        {
                            var cell = range.Cells[r + 2, c + 1].Value;
                            data[r][c] = cell != null ? cell.ToString() : null;
                        }
                    }
                    List<List<int>> statusImport = schedulesBUL.importSchedule(data);   // trả về status khi import
                    List<String> status = new List<string>();
                    String listRows = "";
                    if (statusImport[0].Count > 1)
                    {
                        statusImport[0].RemoveAt(0);
                        listRows = string.Join(", ", statusImport[0].ToArray());
                        status.Add("Successful Changes Applied:  [" + listRows + "]");
                    }
                    if(statusImport[1].Count > 1)
                    {
                        statusImport[1].RemoveAt(0);
                        listRows = string.Join(", ", statusImport[1].ToArray());
                        status.Add("Duplicate Records Discarded:  [" + listRows + "]");
                    }
                    if (statusImport[2].Count > 1)
                    {
                        statusImport[2].RemoveAt(0);
                        listRows = string.Join(", ", statusImport[2].ToArray());
                        status.Add("Record with missing fields discarded:  [" + listRows + "]");
                    }
                    if (statusImport[3].Count > 1)
                    {
                        statusImport[3].RemoveAt(0);
                        listRows = string.Join(", ", statusImport[3].ToArray());
                        status.Add("Aircaft is invalid:  [" + listRows + "]");
                    }
                    if (statusImport[4].Count > 1)
                    {
                        statusImport[4].RemoveAt(0);
                        listRows = string.Join(", ", statusImport[4].ToArray());
                        status.Add("DepartureAirport or ArrivalAirport is invalid:  [" + listRows + "]");
                    }
                    listBox.DataSource = status;    // Hiển thị status lên listbox
                    txtImportPath.Text = null;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    app.Quit();
                    wb = null;
                }
            }
            else
            {
                MessageBox.Show("Bạn không chọn tệp tin nào!", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnImport_Click_1(object sender, EventArgs e)
        {

        }
    }
}
