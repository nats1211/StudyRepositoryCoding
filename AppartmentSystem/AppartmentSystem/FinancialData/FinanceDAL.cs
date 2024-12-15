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

        public DataTable getMaintenanceList()
        {
            DataTable table = new DataTable();

            string query = @"
            SELECT
            t.room_id AS 'Room Number',
            SUM(ISNULL(m.Amount, 0)) AS 'Maintenance Cost',
            r.room_price AS 'Room Price'
            FROM
            Expenses m
            LEFT JOIN
            tenant t ON m.room_id = t.room_id
            LEFT JOIN
            room r ON t.room_id = r.room_id
            GROUP BY
            t.room_id,          
            r.room_price       
            ORDER BY   
            t.room_id;";

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
