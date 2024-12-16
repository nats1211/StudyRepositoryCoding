using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppartmentSystem
{
    public partial class frm_financialData : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
             (
              int nLeft,
              int nTop,
              int nRight,
              int nBottom,
              int nWidthEllipse,
              int nHeightEllipse
               );

        public frm_financialData()
        {
            InitializeComponent();
            LoadData();
        }

        private void btn_fdUpdate_Click(object sender, EventArgs e)
        {

        }

        private void frm_financialData_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;

            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

           
            btn_fdPaid.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, btn_fdPaid.Width, btn_fdPaid.Height, 15, 15));

        }

        private void txt_fdroomNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_fdAdd_Click(object sender, EventArgs e)
        {

        }

        private void btn_fdEdit_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_fdPaid_Click(object sender, EventArgs e)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            FinanceDAL payment = new FinanceDAL(connectionString);
            var selection = MessageBox.Show("Do you want to print receipt?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            string roomNumber = selectedRow.Cells["Room Number"].Value.ToString();
            string tenantName = selectedRow.Cells["Name"].Value.ToString();
            double roomPrice = Convert.ToDouble(selectedRow.Cells["Room Price"].Value);
            double maintenanceCost = Convert.ToDouble(selectedRow.Cells["Maintenance Cost"].Value);
            double totalCost = roomPrice + maintenanceCost;

            if (selection == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {

                    PrintDocument printDoc = new PrintDocument();
                    printDoc.PrintPage += (x, f) => PrintReceipt(f, roomNumber, tenantName, roomPrice, maintenanceCost, totalCost);

                    PrintPreviewDialog previewDialog = new PrintPreviewDialog
                    {
                        Document = printDoc
                    };
                    previewDialog.ShowDialog();

                    printDoc.Print();
                    bool success = payment.paidLeaseMaintenance(roomNumber);
                    LoadData();
                }
            }
            else if (selection == DialogResult.No)
            {
                bool success = payment.paidLeaseMaintenance(roomNumber);
                MessageBox.Show("Payment successfull", "", MessageBoxButtons.OK);
                LoadData();
            }
            else
            {
                return;   
            }

        }

        private void PrintReceipt(PrintPageEventArgs e, string roomNumber, string tenantName, double roomPrice, double maintenanceCost, double totalCost)
        {
            Graphics g = e.Graphics;
            Font font = new Font("Courier New", 12);
            float yPosition = 10;
            float lineHeight = font.GetHeight();

            // Print the receipt content
            g.DrawString("Uno Rental", font, Brushes.Black, 10, yPosition); yPosition += lineHeight;
            g.DrawString("123 Store Address", font, Brushes.Black, 10, yPosition); yPosition += lineHeight;
            g.DrawString("Phone: (123) 456-7890", font, Brushes.Black, 10, yPosition); yPosition += lineHeight * 2;

            g.DrawString("Date: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), font, Brushes.Black, 10, yPosition); yPosition += lineHeight;
            g.DrawString("--------------------------------", font, Brushes.Black, 10, yPosition); yPosition += lineHeight;

            g.DrawString("Room Number: " + roomNumber, font, Brushes.Black, 10, yPosition); yPosition += lineHeight;
            g.DrawString("Tenant Name: " + tenantName, font, Brushes.Black, 10, yPosition); yPosition += lineHeight;
            g.DrawString("--------------------------------", font, Brushes.Black, 10, yPosition); yPosition += lineHeight;

            g.DrawString("Room Price: $" + roomPrice.ToString("F2"), font, Brushes.Black, 10, yPosition); yPosition += lineHeight;
            g.DrawString("Maintenance Cost: $" + maintenanceCost.ToString("F2"), font, Brushes.Black, 10, yPosition); yPosition += lineHeight;
            g.DrawString("--------------------------------", font, Brushes.Black, 10, yPosition); yPosition += lineHeight;
            g.DrawString("Total Cost: $" + totalCost.ToString("F2"), font, Brushes.Black, 10, yPosition); yPosition += lineHeight * 2;

            g.DrawString("Thank you!", font, Brushes.Black, 10, yPosition);
        }
  
        public void LoadData()
        {
                var data_access = new FinanceDAL(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

                DataTable table = data_access.getMaintenanceList();

                if (table.Rows.Count > 0)
                {
                    dataGridView1.DataSource = table;
                }
                else
                {
                    dataGridView1.DataSource = null;
                }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_fdBack_Click(object sender, EventArgs e)
        {
            Frm_Dashboard dashboard = new Frm_Dashboard();
            dashboard.Show();
            this.Close();
        }

        private void frm_financialData_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridView1.ClearSelection();
        }
    }
}
