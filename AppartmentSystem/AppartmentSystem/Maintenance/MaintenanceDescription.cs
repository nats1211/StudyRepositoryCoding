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

namespace AppartmentSystem.Maintenance
{
    public partial class MaintenanceDescription : Form
    {
        public MaintenanceDescription()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            LeaseRepository lease = new LeaseRepository(connectionString);

            DataTable dt = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                
                string query = @"
                SELECT
                Description
                FROM
                Expenses";

                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            try
            {
                if (dt.Rows.Count > 0)
                {
                    string data = string.Join(Environment.NewLine, dt.AsEnumerable()
                        .Select(row => row["Description"].ToString()));

                    lbl_infoOutput.Text = data;
                }
                else
                {
                    lbl_infoOutput.Text = "No data available.";
                }
            }
            catch (Exception)
            {              

            }
        }

        private void btn_backDesc_Click(object sender, EventArgs e)
        {

        }
    }
}
