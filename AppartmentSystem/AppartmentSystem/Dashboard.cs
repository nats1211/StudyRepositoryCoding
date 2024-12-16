using AppartmentSystem.Maintenance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppartmentSystem
{
    public partial class Frm_Dashboard : Form
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

        public Frm_Dashboard()
        {
            InitializeComponent();
            //panel_headDashboard.BackColor = Color.FromArgb(125, Color.Black);
            LoadData();
            dataGridView1.Enabled = false;
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Frm_Dashboard_Load(object sender, EventArgs e)
        {
            //GetActiveRoomCount();
            //GetInActiveRoomCount();

            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;

            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

            btn_AssignMaintenance.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_AssignMaintenance.Width, btn_AssignMaintenance.Height, 15, 15));
            btn_financialData.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_financialData.Width, btn_financialData.Height, 15, 15));
            btn_manageLeases.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_manageLeases.Width, btn_manageLeases.Height, 15, 15));
            btn_manageRoom.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_manageRoom.Width, btn_manageRoom.Height, 15, 15));
            btn_tenantProfile.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_tenantProfile.Width, btn_tenantProfile.Height, 20, 20));

           
        }

        private void btn_manageRoom_Click(object sender, EventArgs e)
        {
                frm_room frm_Room = new frm_room();
                frm_Room.Show();
                this.Hide();
        }

        private void GetActiveRoomCount()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Rooms WHERE IsActive = 1";
                    SqlCommand command = new SqlCommand(query, connection);

                    int activeRoomCount = (int)command.ExecuteScalar();

                   
                }
                catch (Exception ex)
                {
                    // Handle any errors
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void GetInActiveRoomCount()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Rooms WHERE IsActive = 0";
                    SqlCommand command = new SqlCommand(query, connection);

                    int InactiveRoomCount = (int)command.ExecuteScalar();

                    
                }
                catch (Exception ex)
                {
                    // Handle any errors
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void panel_dockleft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_ActiveRoomOutput_Click(object sender, EventArgs e)
        {

        }

        private void btn_manageLeases_Click(object sender, EventArgs e)
        {
            Lease lease = new Lease();
            lease.Show();
            this.Close();
        }

        private void panel_headDashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_financialData_Click(object sender, EventArgs e)
        {
            frm_financialData financialData = new frm_financialData();
            financialData.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Frm_Maintenance maintenance = new Frm_Maintenance();
            maintenance.Show();
            this.Close();
        }

        private void btn_tenantProfile_Click(object sender, EventArgs e)
        {
            frm_tenantProfile profile = new frm_tenantProfile();
            profile.Show();
            this.Close();
        }

        public void LoadData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            string query = @"SELECT
                            t.room_id AS 'Room',
                            CONCAT(t.last_name, ' ', t.first_name, ' ', ISNULL(t.middle_name, '')) AS 'Name',
                            t.age AS 'Age',
                            t.move_in AS 'Move In',
                            l.LeaseEndDate AS 'Lease End Date'
                            FROM
                            tenant t
                            LEFT JOIN
                            LeaseDetails l
                            ON
                            t.room_id = l.room_id";

            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            dataGridView1.DataSource = dataTable;
        }

    }
}
