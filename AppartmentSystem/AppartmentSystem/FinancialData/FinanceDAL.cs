using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppartmentSystem
{
    public class FinanceDAL
    {
        private readonly string connectionString;

        public FinanceDAL(string _connectionString)
        {
            connectionString = _connectionString;
        }

        public bool paidLeaseMaintenance(string roomId)
        {
            using(var connection = new SqlConnection(connectionString))
            {

                connection.Open();

                string query = @"DELETE FROM Expenses WHERE room_id = @room_id";

                using(var command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@room_id", roomId);
                    int rowsAffected = command.ExecuteNonQuery();

                    if(rowsAffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public DataTable getMaintenanceList()
        {
            DataTable table = new DataTable();

            string query = @"
            SELECT
            r.room_id AS 'Room Number',
            r.tenant_name AS 'Name',
            SUM(ISNULL(m.Amount, 0)) AS 'Maintenance Cost',
            r.room_price AS 'Room Price'
            FROM
            room r
            LEFT JOIN
            tenant t ON t.room_id = r.room_id
            LEFT JOIN
            Expenses m ON m.room_id = r.room_id
            GROUP BY
            r.room_id,
            r.tenant_name,
            r.room_price       
            ORDER BY   
            r.room_id;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                }
            }

            return table;
        }
    }
}
