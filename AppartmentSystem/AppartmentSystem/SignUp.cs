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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppartmentSystem
{
    public partial class Frm_SignUp : Form
    {

        public Frm_SignUp()
        {
            InitializeComponent();           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_back_signup_Click(object sender, EventArgs e)
        {
            // Show the FrmLogin form again
            FrmLogin loginForm = new FrmLogin();
            loginForm.Show();

            // Close the current form
            this.Close();
        }

        private void btn_CreateAcc_Click(object sender, EventArgs e)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            DatabaseContext conn = new DatabaseContext(connectionString);

            string usernmame = txt_Username.Text;
            string password = txt_Password.Text;
            string confirmpass = txt_ConfirmPass.Text;
            string first_name = txt_FirstName.Text;
            string last_name = txt_LastName.Text;

            if(password == confirmpass)
            {
                using (SqlConnection connection = conn.GetConnection())
                {
                    try
                    {
                        connection.Open();

                        string querry = "INSERT INTO adminstration_table (username, password, first_name, last_name) VALUES (@username, @password, @first_name, @last_name)";

                        using (SqlCommand cmd = new SqlCommand(querry, connection))
                        {
                            cmd.Parameters.AddWithValue("@username", usernmame);
                            cmd.Parameters.AddWithValue("@password", password);
                            cmd.Parameters.AddWithValue("@first_name", first_name);
                            cmd.Parameters.AddWithValue("@last_name", last_name);

                            int rowAffected = cmd.ExecuteNonQuery();

                            if (rowAffected > 0)
                            {
                                MessageBox.Show("User added successfully!");
                            }
                            else
                            {
                                MessageBox.Show("Failed to add user");
                            }
                        }

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Check your input password!");
                txt_Password.Clear();
                txt_ConfirmPass.Clear();
            }
        }
    }
}
