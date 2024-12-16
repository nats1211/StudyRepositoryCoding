using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using AppartmentSystem;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace AppartmentSystem
{
    public partial class FrmLogin : Form
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

        public FrmLogin()
        {
            InitializeComponent();
            panel_login.BackColor = Color.FromArgb(125, Color.Black);
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            Frm_SignUp signUpForm = new Frm_SignUp();
            signUpForm.Show();
            this.Hide();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;

            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

            panel_login.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel_login.Width,
            panel_login.Height, 20, 20));

            btn_Login.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_Login.Width,
            btn_Login.Height, 15, 15));

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            DatabaseContext dbContext = new DatabaseContext(connectionString);

            string username, user_password;

            username = txt_Username.Text;
            user_password = txt_Password.Text;

            using (SqlConnection connection = dbContext.GetConnection())
            {
                try
                {
                    connection.Open();

                    string querry = "SELECT COUNT(*) FROM management WHERE username = @username AND _password = @password";
                    SqlCommand command = new SqlCommand(querry, connection);

                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", user_password);

                    int result = Convert.ToInt32(command.ExecuteScalar());

                    if (result > 0)
                    {

                        Frm_Dashboard frm_Dashboard = new Frm_Dashboard();
                        frm_Dashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username/Password");
                    }
                }
                catch (SqlException)
                {
                }
                catch (Exception)
                {
                }
                finally
                {
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }

        }

        private void cb_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_showPassword.Checked)
            {
                txt_Password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_Password.UseSystemPasswordChar = true;
            }
        }

        private void txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btn_Login_Click(sender, e);
            }
        }
    }
}
