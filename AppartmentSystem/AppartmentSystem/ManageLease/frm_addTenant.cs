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

namespace AppartmentSystem.ManageLease
{
    public partial class frm_addTenant : Form
    {
        public frm_addTenant()
        {
            InitializeComponent();
            LoadComboBox();
        }

        private void lbl_editroomheader_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_editRoomCancel_Click(object sender, EventArgs e)
        {
            var sure = MessageBox.Show("Are you sure you want to cancel?", ""
                , MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (DialogResult.OK == sure)
            {

                Lease lease = new Lease();
                lease.Show();
                this.Close();
            }
            else if (DialogResult.Cancel == sure)
            {

                return;
            }
        }

        private void btn_editRoomSave_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            LeaseRepository lease = new LeaseRepository(connectionString);

            string houseNumber = text.Text;
            string tenantName = cb_TenantName.Text;
            DateTime movedIn = DateTime.Now;
            DateTime moved_out = movedIn.AddMonths(1);

            bool success = lease.AddTenant(tenantName, houseNumber, movedIn, moved_out);

            if (success)
            {
                MessageBox.Show("Tenant has added!");
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

            cb_TenantName.DropDownStyle = ComboBoxStyle.DropDownList;

            var roomList = tenat.getRoom();
            textBox1.DisplayMember = "House Number";
            textBox1.ValueMember = "room_id";
            textBox1.DataSource = roomList;

            textBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void txt_editRoomprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_editRoomprice_Click(object sender, EventArgs e)
        {

        }

        private void lbl_editRoomtenant_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_editRoomroom_Click(object sender, EventArgs e)
        {

        }

        private void btn_editRoomBack_Click(object sender, EventArgs e)
        {

        }

        private void lbl_editRoomsubheader_Click(object sender, EventArgs e)
        {

        }

        private void cb_TenantName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frm_addTenant_Load(object sender, EventArgs e)
        {

        }
    }
}
