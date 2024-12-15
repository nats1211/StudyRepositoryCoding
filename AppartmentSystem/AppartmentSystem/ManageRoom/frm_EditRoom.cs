using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppartmentSystem.ManageRoom
{
    public partial class frm_EditRoom : Form
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

        public string RoomNumber { get; set; }
        public string TenantName { get; set; }
        public double RoomPrice { get; set; }

        public frm_EditRoom()
        {
            InitializeComponent();
            LoadComboBox();
            textBox1.ReadOnly = true;
            txt_editRoomtenant.ReadOnly = true;
        }

        private void frm_EditRoom_Load(object sender, EventArgs e)
        {
            btn_editRoomSave.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_editRoomSave.Width, btn_editRoomSave.Height, 15, 15));
            
            btn_editRoomCancel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_editRoomCancel.Width, btn_editRoomCancel.Height, 15, 15));
        }

        public void setRoomDetails(string roomName, string tenantName, double rent)
        {
            RoomNumber = roomName;
            textBox1.Text = roomName;

            TenantName = tenantName;
            txt_editRoomtenant.Text = tenantName;

            RoomPrice = rent;
            txt_editRoomprice.Text = rent.ToString();
           
        }

        private void btn_editRoomSave_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                roomAddingDAL add = new roomAddingDAL(connectionString);

                string action = "Edit";
                DateTime dateTime = DateTime.Now;

                string roomNumber = textBox1.Text;
                string tenantName = cb_TenantName.Text;
                int rent = Convert.ToInt32(txt_editRoomprice.Text);

                bool successEdit = add.EditRoom(roomNumber, tenantName, rent);
                bool logs = add.SaveLog(action, roomNumber, dateTime);

                if (successEdit)
                {
                    MessageBox.Show("Succesfully edit", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if(logs)
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Unexpected Encountered Error");
                }
            }
            catch (FormatException)
            {

                throw;
            }
        }

        public void LoadComboBox()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            tenantDAL tenat = new tenantDAL(connectionString);

            var tenantList = tenat.getTenant();
            cb_TenantName.DisplayMember = "full_name";
            cb_TenantName.ValueMember = "tenant_id";
            cb_TenantName.DataSource = tenantList;
        }

        private void btn_editRoomBack_Click(object sender, EventArgs e)
        {
            
            frm_room room = new frm_room();
            room.Show();
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_editRoomtenant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_editRoomprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
