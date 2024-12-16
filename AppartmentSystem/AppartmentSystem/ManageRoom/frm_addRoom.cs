using AppartmentSystem.ManageRoom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppartmentSystem.FinancialData
{
    public partial class frm_addRoom : Form
    {
        public frm_addRoom()
        {
            InitializeComponent();
            DropDownSettings();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_addRoomSave_Click(object sender, EventArgs e)
        {

            
            
        }

        public void DropDownSettings()
        {
            //capacity
            cb_paxAddroom.Items.Add("1");
            cb_paxAddroom.Items.Add("2");
            cb_paxAddroom.Items.Add("3");
            cb_paxAddroom.DropDownStyle = ComboBoxStyle.DropDownList;

            //kithcen
            cb_kitchenAddroom.Items.Add("1");
            cb_kitchenAddroom.Items.Add("2");
            cb_kitchenAddroom.Items.Add("3");
            cb_kitchenAddroom.DropDownStyle = ComboBoxStyle.DropDownList;
            //bedroom
            cb_bedroomAddroom.Items.Add("1");
            cb_bedroomAddroom.Items.Add("2");
            cb_bedroomAddroom.Items.Add("3");
            cb_bedroomAddroom.DropDownStyle = ComboBoxStyle.DropDownList;
            //bathroom
            cb_bathroomAddroom.Items.Add("1");
            cb_bathroomAddroom.Items.Add("2");
            cb_bathroomAddroom.Items.Add("3");
            cb_bathroomAddroom.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btn_addRoomCancel_Click(object sender, EventArgs e)
        {
            var sure = MessageBox.Show("Are you sure you want to cancel?", ""
                , MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (DialogResult.OK == sure)
            {

                frm_room room = new frm_room();
                room.Show();
                this.Close();
            }
            else if (DialogResult.Cancel == sure)
            {

                return;
            }
        }

        private void btn_addRoomSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                roomAddingDAL add = new roomAddingDAL(connectionString);

                string houseNumber = txt_roomAddroom.Text;
                double rent = Convert.ToDouble(txt_priceAddroom.Text);
                int capacity = Convert.ToInt32(cb_paxAddroom.Text);
                int kitchen = Convert.ToInt32(cb_kitchenAddroom.Text);
                int bedroom = Convert.ToInt32(cb_bedroomAddroom.Text);
                int bathroom = Convert.ToInt32(cb_bathroomAddroom.Text);

                bool addRoom = add.AddRoom(houseNumber, rent, capacity, kitchen, bedroom, bathroom);

                if (addRoom)
                {
                    MessageBox.Show("House added successfully", "", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Check Details you input! Duplicate House Number", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
            }
            catch (FormatException ex)
            {

                MessageBox.Show("Check Details you input! Missing Field", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
            }
        }
    }
}
