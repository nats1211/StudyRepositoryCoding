using AppartmentSystem.FinancialData;
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

        private void btn_addRoom_Click(object sender, EventArgs e)
        {

            frm_addRoom room = new frm_addRoom();
            room.Show();
            this.Close();
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

            string roomId = dg_ManageRoom.SelectedRows[0].Cells["House Number"].Value.ToString();

            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?",
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(result == DialogResult.Yes)
            {
                roomAddingDAL room = new roomAddingDAL(connectionString);

                bool isDeleted = room.DeleteRoom(roomId);


                if(isDeleted)
                {
                    MessageBox.Show("Record deleted successfully!");
                    LoadData();
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

                string roomNumber = dg_ManageRoom.Rows[rowIndex].Cells["House Number"].Value.ToString();
                double roomPrice = Convert.ToDouble(dg_ManageRoom.Rows[rowIndex].Cells["Rent"].Value);

                frm_EditRoom editForm = new frm_EditRoom();             

                editForm.setRoomDetails(roomNumber, roomPrice);
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
                MessageBox.Show("Please select a house to edit.");
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
