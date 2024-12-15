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

namespace AppartmentSystem.Maintenance
{
    public partial class frm_addMaintenance : Form
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

        public frm_addMaintenance()
        {
            InitializeComponent();
            dp_addMaintenance.MinDate = DateTime.Now;
            LoadRoomComboBox();
        }

        private void frm_addMaintenance_Load(object sender, EventArgs e)
        {
            btn_addmaintenanceSave.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, btn_addmaintenanceSave.Width, btn_addmaintenanceSave.Height, 15, 15));
            btn_addMaintenanceInfo.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, btn_addMaintenanceInfo.Width, btn_addMaintenanceInfo.Height, 15, 15));
        }

        private void btn_addmaintenanceSave_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                MaintenanceDAL maintenance = new MaintenanceDAL(connectionString);

                string expenseType = cb_addExpenseType.Text;
                double amount = Convert.ToDouble(txt_addAmount.Text);
                DateTime dateCreated = DateTime.Now;
                DateTime dateEnd = dp_addMaintenance.Value.Date;
                string description = txt_addDescription.Text;
                string roomNumber = cb_roomaddMaintenance.Text;

                DialogResult result = MessageBox.Show("Are you sure you want to save this maintenance?",
               "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool success = maintenance.addMaintenanceBill(roomNumber, amount, expenseType, description, dateCreated);

                    if (success)
                    {

                        MessageBox.Show("Maintenance order added successfully!");
                    }
                }
                else
                {
                    MessageBox.Show("Error has occured. Data has not been saved");
                    return;
                }
            }
            catch (Exception)
            {

            }
        }

        private void LoadRoomComboBox()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            MaintenanceDAL maintenance = new MaintenanceDAL(connectionString);

            var roomList = maintenance.getRoomList();
            cb_roomaddMaintenance.DisplayMember = "room_id";
            cb_roomaddMaintenance.ValueMember = "room_id";
            cb_roomaddMaintenance.DataSource = roomList;

            cb_addExpenseType.Items.Add("Maintenance");
            cb_addExpenseType.Items.Add("Utilities");
            cb_addExpenseType.Items.Add("Admin");
        }

        private void btn_addmaintenanceback_Click(object sender, EventArgs e)
        {
            Frm_Maintenance maintnenance = new Frm_Maintenance();
            maintnenance.Show();
            this.Close();
        }

    }
}
