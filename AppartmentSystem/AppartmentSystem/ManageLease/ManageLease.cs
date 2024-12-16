using AppartmentSystem.ManageRoom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace AppartmentSystem
{
    public partial class ManageLease : Form
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


        public ManageLease()
        {
            InitializeComponent();
            panel_sample.BackColor = Color.FromArgb(125, Color.Black);


            LoadData();
            Addbutton();
        }

        private void btn_updateLease_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_addLease_Click(object sender, EventArgs e)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            LeaseRepository lease = new LeaseRepository(connectionString);

            string room_id = lbl_roomNumberleaseOutput.Text;
            int room_price = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value);
            DateTime moved_in = dateTimePicker1.Value;
            DateTime moved_out = moved_in.AddMonths(1);


        }

        private void ManageLease_Load(object sender, EventArgs e)
        {

            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;

            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

            

            btn_historyLease.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_historyLease.Width,
            btn_historyLease.Height, 15, 15));

        }

        private void LoadData()
        {
            var dataAccess = new LeaseRepository(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            try
            {
                DataTable data = dataAccess.GetTenantRoomId();

                if (data.Rows.Count > 0)
                {
                    dataGridView1.DataSource = data;
                }
                else
                {
                    dataGridView1.DataSource = null;
                }
                
            }
            catch (Exception)
            { 
            }

        }

        private void btn_deleteLease_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a row to delete.");
                return;
            }

            string roomId = dataGridView1.SelectedRows[0].Cells["Room Number"].Value.ToString();

            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?",
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        private void btn_editLease_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a row you want to edit.");
                return;
            }

            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            string roomId = lbl_roomNumberleaseOutput.Text;
            string tenantName = txtTenantName.Text;
            DateTime moved_in = dateTimePicker1.Value;
            DateTime moved_out = moved_in.AddMonths(1);

            LeaseRepository lease = new LeaseRepository(connectionString);
            bool isUpdated = lease.editRoom(roomId, moved_in, moved_out);

            if (isUpdated)
            {
                MessageBox.Show("Record updated successfully!");
                btn_updateLease_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Error updating record");
            }
        }

        private void btn_archiveLease_Click(object sender, EventArgs e)
        {
            frm_Archive frm_Archive = new frm_Archive();
            frm_Archive.Show();
            this.Hide();
        }

        private void OpenAddLeaseForm(int rowIndex)
        {
            if (dataGridView1.CurrentCell != null && rowIndex >= 0)
            {

                string roomNumber = dataGridView1.Rows[rowIndex].Cells["Room Number"].Value.ToString();
                string tenantName = dataGridView1.Rows[rowIndex].Cells["Name"].Value.ToString();
                double roomPrice = Convert.ToDouble(dataGridView1.Rows[rowIndex].Cells["Rent"].Value);

                frm_EditRoom editForm = new frm_EditRoom();

                editForm.setRoomDetails(roomNumber, tenantName, roomPrice);
                editForm.Show();
                this.Close();
            }
        }

        private bool isButtonEnabled = true;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            LeaseRepository lease = new LeaseRepository(connectionString);

            int renewButtonColumnIndex = dataGridView1.Columns["RenewButton"].Index;
            int leaveButtonColumnIndex = dataGridView1.Columns["LeaveButton"].Index;

            long leaseId = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);
            string roomNumber = dataGridView1.Rows[e.RowIndex].Cells["Room Number"].Value.ToString();
            string tenantName = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            string status = e.ColumnIndex == renewButtonColumnIndex ? "Renewed" : "Left";
            DateTime dateNow = DateTime.Now;

            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == renewButtonColumnIndex && isButtonEnabled)
                {
                    isButtonEnabled = false;                                   

                    if (lease.RenewLease(leaseId, roomNumber, dateNow))
                    {

                        if (lease.AddToHistory(leaseId, tenantName, status, dateNow))
                        {
                            var timer = new System.Windows.Forms.Timer();
                            timer.Interval = 10000;
                            timer.Tick += (s, args) =>
                            {
                                isButtonEnabled = true;
                                timer.Stop();
                                timer.Dispose();
                            };
                            timer.Start();
                        }
                        MessageBox.Show("Lease renewed successfully!");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Error has encountered, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                if (e.ColumnIndex == leaveButtonColumnIndex)
                {

                   if (lease.MoveOutTenant(leaseId, roomNumber, tenantName))
                      {

                        if (lease.LeftInHistory(tenantName))
                        {

                        }
                            MessageBox.Show("Tenant left the apartment!");
                            LoadData();
                      }                                               
                }
            }
        }
        
        public void Addbutton()
        {
            DataGridViewButtonColumn renewButtonColumn = new DataGridViewButtonColumn();
            renewButtonColumn.Name = "RenewButton";
            renewButtonColumn.HeaderText = string.Empty;
            renewButtonColumn.Text = "Renew";
            renewButtonColumn.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn leaveButtonColumn = new DataGridViewButtonColumn();
            leaveButtonColumn.Name = "LeaveButton";
            leaveButtonColumn.HeaderText= string.Empty;
            leaveButtonColumn.Text = "Leave";
            leaveButtonColumn.UseColumnTextForButtonValue = true;

            dataGridView1.Columns.Add(renewButtonColumn);
            dataGridView1.Columns.Add(leaveButtonColumn);

            int lastIndex = dataGridView1.Columns.Count - 1;
            dataGridView1.Columns["RenewButton"].DisplayIndex = lastIndex - 1;
            dataGridView1.Columns["LeaveButton"].DisplayIndex = lastIndex;
        }

        private void btn_mlBack_Click(object sender, EventArgs e)
        {
            Frm_Dashboard dashboard = new Frm_Dashboard();
            dashboard.Show();
            this.Close();
        }

        private void ManageLease_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void btn_addLease_Click_1(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;

                OpenAddLeaseForm(rowIndex);
            }
            else
            {
                MessageBox.Show("Please select a house");
            }
        }

        //kailangan ayusin yung left btn
    }
}
