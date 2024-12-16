using AppartmentSystem.ManageRoom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace AppartmentSystem
{
    public partial class frm_room : Form
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

        public frm_room()
        {
            InitializeComponent();
            LoadRoomComboBox();

        }

        //pwede pang mabago
        private void frm_room_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Now;
            LoadData();
            txt_RoomNo.Text = "";
            txt_RoomNo.DropDownStyle = ComboBoxStyle.DropDownList;

            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;

            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);    

            btn_addRoom.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_addRoom.Width,
            btn_addRoom.Height, 15, 15));

            btn_deleteRoom.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_deleteRoom.Width,
            btn_deleteRoom.Height, 15, 15));

            btn_editRoom.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_editRoom.Width,
            btn_editRoom.Height, 15, 15));

            btn_editRoomLog.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_editRoomLog.Width,
                btn_editRoomLog.Height, 15, 15));
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            string query = @"
            SELECT
            r.room_id as 'Room Number',
            r.tenant_name as 'Name',
            r.room_price as 'Rent',
            t.move_in as 'Move in'
            FROM room r
            LEFT JOIN tenant t ON r.room_id = t.room_id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dg_ManageRoom.DataSource = table;
            }
        }

        private void btn_addRoom_Click(object sender, EventArgs e)
        {
            try
            {
                
                //Connection ng database
                string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                roomAddingDAL add = new roomAddingDAL(connectionString);
                //baliktad
                string roomNum = txt_tenant.Text;
                double roomPrice = double.Parse(txt_price.Text);
                string tenantName = txt_RoomNo.Text;
                DateTime movedIn = dateTimePicker1.Value;
                DateTime moved_out = movedIn.AddMonths(1);

                //eto yung kinuha yung process
                bool success = add.AddRoom(roomNum,roomPrice, tenantName);
                bool tenant = add.AddTenant(tenantName, roomNum, movedIn, moved_out);


                if (IsRoomExists(roomNum))
                {
                    MessageBox.Show("Room already exists in the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (success)
                {
                    MessageBox.Show("Room and tenant have been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txt_price.Clear();
                    txt_tenant.Clear();
                }
                else
                {
                    MessageBox.Show("Failed to add room and tenant. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                btn_Update_Click(sender, e);

            }
            catch (FormatException ex)
            {
                DialogResult result = MessageBox.Show("Check your input details",
                "Please try again!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                       
        }

        private bool IsRoomExists(string roomId)
        {
            foreach (DataGridViewRow row in dg_ManageRoom.Rows)
            {
                if (row.Cells["Room Number"].Value != null && row.Cells["Room Number"].Value.ToString() == roomId)
                { 

                    return true;                  
                }
            }
            return false;
        }

        private void LoadRoomComboBox()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            tenantDAL tenat = new tenantDAL(connectionString);

            var tenantList = tenat.getTenant();
            txt_RoomNo.DisplayMember = "full_name";
            txt_RoomNo.ValueMember = "tenant_id";
            txt_RoomNo.DataSource = tenantList;

        }

        private void btn_deleteRoom_Click(object sender, EventArgs e)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            if (dg_ManageRoom.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a row to delete.");
                return;
            }

            string roomId = dg_ManageRoom.SelectedRows[0].Cells["Room Number"].Value.ToString();

            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?",
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(result == DialogResult.Yes)
            {
                roomAddingDAL room = new roomAddingDAL(connectionString);

                bool isDeleted = room.DeleteRoom(roomId);


                if(isDeleted)
                {
                    MessageBox.Show("Record deleted successfully!");
                    btn_Update_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Error: Record could not be deleted");
                }
            }
        }

        private void dg_ManageRoom_SelectionChanged(object sender, EventArgs e)
        {
            if (dg_ManageRoom.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dg_ManageRoom.SelectedRows[0];
                txt_RoomNo.Text = selectedRow.Cells[0].Value.ToString();
            }
        }
        //need ng edit sa grid
        private void LoadData()
        {
            var dataAccess = new roomAddingDAL(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

            try
            {
                DataTable data = dataAccess.GetRoomTable();

                if (data.Rows.Count > 0)
                {
                    dg_ManageRoom.DataSource = data;
                }
                else
                {
                    dg_ManageRoom.DataSource = null;
                }
            }
            catch (Exception)
            { 
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Now;
        }

        private void btn_roomBack_Click(object sender, EventArgs e)
        {
            Frm_Dashboard dashboard = new Frm_Dashboard();
            dashboard.Show();
            this.Close();
        }

        private void txt_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_RoomNo_Click(object sender, EventArgs e)
        {
            btn_addRoom.Enabled = true;
            btn_editRoom.Enabled = false;
        }

        private void txt_tenant_MouseClick(object sender, MouseEventArgs e)
        {
            btn_addRoom.Enabled = true;
            btn_editRoom.Enabled = true;
        }

        private void txt_price_MouseClick(object sender, MouseEventArgs e)
        {
            btn_addRoom.Enabled = true;
            btn_editRoom.Enabled = true;
        }

        private void txt_RoomNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

            if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txt_tenant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

            if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }

            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void OpenEditRoomForm(int rowIndex)
        {
            if (dg_ManageRoom.CurrentCell != null && rowIndex >= 0)
            {

                string roomNumber = dg_ManageRoom.Rows[rowIndex].Cells["Room Number"].Value.ToString();
                string tenantName = dg_ManageRoom.Rows[rowIndex].Cells["Name"].Value.ToString();
                double roomPrice = Convert.ToDouble(dg_ManageRoom.Rows[rowIndex].Cells["Rent"].Value);

                frm_EditRoom editForm = new frm_EditRoom();

                editForm.setRoomDetails(roomNumber, tenantName, roomPrice);
                editForm.Show();
                this.Close();
            }
        }

        private void btn_editRoom_Click_1(object sender, EventArgs e)
        {
            if (dg_ManageRoom.SelectedRows.Count > 0)
            {
                int rowIndex = dg_ManageRoom.SelectedRows[0].Index;

                OpenEditRoomForm(rowIndex);
            }
            else
            {
                MessageBox.Show("Please select a room to edit.");
            }
        }

        private void btn_editRoomLog_Click(object sender, EventArgs e)
        {
            frm_EditRoomLog editForm = new frm_EditRoomLog();
            editForm.Show();
        }

        private void txt_RoomNo_Leave(object sender, EventArgs e)
        {
            string selectedName = txt_RoomNo.Text.Trim();
            bool nameExists = false;

            foreach (DataGridViewRow row in dg_ManageRoom.Rows)
            {
                if (row.IsNewRow)
                {
                    string cellName = row.Cells["Name"].Value?.ToString().Trim();
                    if (selectedName.Equals(cellName, StringComparison.OrdinalIgnoreCase))
                    {
                        nameExists = true;
                        break;
                    }
                }
            }

            if (nameExists)
            {
                MessageBox.Show("The selected name already exists in the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_RoomNo.Text = "";
                dg_ManageRoom.Focus();
            }
        }

        private void frm_room_MouseClick(object sender, MouseEventArgs e)
        {
            dg_ManageRoom.ClearSelection();
        }
    }
}
