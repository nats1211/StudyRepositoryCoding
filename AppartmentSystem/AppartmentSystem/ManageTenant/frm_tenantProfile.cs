using AppartmentSystem.ManageRoom;
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

namespace AppartmentSystem
{
    public partial class frm_tenantProfile : Form
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

        public frm_tenantProfile()
        {
            InitializeComponent();

            panel_tenantInfo.BackColor = Color.FromArgb(125, Color.Black);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_tenantProfile_Load(object sender, EventArgs e)
        {
            panel_tenantInfo.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, panel_tenantInfo.Width, panel_tenantInfo.Height, 20, 20));

            btn_addManageTenant.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, btn_addManageTenant.Width, btn_addManageTenant.Height, 15, 15));

            btn_cancelManageTenant.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, btn_cancelManageTenant.Width, btn_cancelManageTenant.Height, 15, 15));
        }

        private void btn_addManageTenant_Click(object sender, EventArgs e)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            tenantDAL tenant = new tenantDAL(connectionString);

            try
            {
                string firstname = txt_tenantFirstName.Text;
                string lastname = txt_LastName.Text;
                string middlename = txt_MiddleName.Text;
                int age = Convert.ToInt32(txt_age.Text);
                long contact = Convert.ToInt64(txt_contactNo.Text);
                string email = txt_email.Text;

                bool success = tenant.addTenant(firstname, lastname, middlename, age, contact, email);

                if (success)
                {
                    txt_tenantFirstName.Clear();
                    txt_LastName.Clear();
                    txt_MiddleName.Clear();
                    txt_age.Clear();
                    txt_contactNo.Clear();
                    txt_email.Clear();
                    MessageBox.Show("Tenant has added", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException)
            {

                MessageBox.Show("Invalid Input/Missing Field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_backManageTenant_Click(object sender, EventArgs e)
        {
            Frm_Dashboard dashboard = new Frm_Dashboard();
            dashboard.Show();
            this.Close();
        }

        private void txt_tenantFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

            if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }

            if (char.IsNumber(e.KeyChar))
            {
                e.Handled= true;
            }
        }

        private void txt_LastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

            if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }

            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_MiddleName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

            if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }

            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_age_KeyPress(object sender, KeyPressEventArgs e)
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

            int maxCharAge = 3;

            if (txt_age.Text.Length >= maxCharAge && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_contactNo_KeyPress(object sender, KeyPressEventArgs e)
        {

            int maxCharAge = 9;

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

            if (txt_contactNo.Text.Length == maxCharAge && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txt_email_KeyPress(object sender, KeyPressEventArgs e)
        {

            int maxString = 15;

            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

            if(txt_email.TextLength >= maxString && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_cancelManageTenant_Click(object sender, EventArgs e)
        {
            Frm_Dashboard dashboard = new Frm_Dashboard();
            dashboard.Show();
            this.Close();
        }
    }
}
