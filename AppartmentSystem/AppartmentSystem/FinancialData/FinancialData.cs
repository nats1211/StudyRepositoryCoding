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
    public partial class frm_financialData : Form
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

        public frm_financialData()
        {
            InitializeComponent();
            LoadData();
        }

        private void btn_fdUpdate_Click(object sender, EventArgs e)
        {

        }

        private void frm_financialData_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;

            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

            btn_fdAdd.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, btn_fdAdd.Width, btn_fdAdd.Height, 15, 15));
            btn_fdDelete.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, btn_fdDelete.Width, btn_fdDelete.Height, 15, 15));
            btn_fdPaid.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, btn_fdPaid.Width, btn_fdPaid.Height, 15, 15));

        }

        private void txt_fdroomNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_fdAdd_Click(object sender, EventArgs e)
        {

        }

        private void btn_fdEdit_Click(object sender, EventArgs e)
        {

        }

        private void btn_fdPaid_Click(object sender, EventArgs e)
        {

        }

        public void LoadData()
        {
                var data_access = new FinanceDAL(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

                DataTable table = data_access.getMaintenanceList();

                if (table.Rows.Count > 0)
                {
                    dataGridView1.DataSource = table;
                }
                else
                {
                    dataGridView1.DataSource = null;
                MessageBox.Show("Error");
                }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_fdBack_Click(object sender, EventArgs e)
        {
            Frm_Dashboard dashboard = new Frm_Dashboard();
            dashboard.Show();
            this.Close();
        }
    }
}
