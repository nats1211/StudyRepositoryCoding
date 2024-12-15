using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppartmentSystem.ManageRoom
{
    public partial class frm_Archive : Form
    {
        public frm_Archive()
        {
            InitializeComponent();
            GetTenantRoomId();
        }

        private void Archive_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;

            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        public void GetTenantRoomId()
        {

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            string query = @"
            SELECT 
            history_id AS 'History ID',
            tenant_name AS 'Name',
            action_date AS 'Date',
            process AS 'Process'
            FROM history";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();

                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
            }

        }

        private void btn_archiveBack_Click(object sender, EventArgs e)
        {

            ManageLease lease = new ManageLease();
            lease.Show();
            this.Close();            
        }

        private void frm_Archive_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridView1.ClearSelection();
        }
    }
}
