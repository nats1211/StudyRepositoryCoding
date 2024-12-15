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
    public partial class frm_EditRoomLog : Form
    {
        public frm_EditRoomLog()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            var dataAccess = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            DataTable dt = new DataTable();

            string query = @"
            SELECT
            log_id AS 'ID',
            action AS 'Action',
            room_id AS 'Room Number',
            timestamp AS 'Date'
            FROM
            logs";

            using (SqlConnection connection = new SqlConnection(dataAccess))
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
                            dg_editroomLog.DataSource = dataTable;
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
            }
        }

        private void btn_editLogback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
