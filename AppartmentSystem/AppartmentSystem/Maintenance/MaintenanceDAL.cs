using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppartmentSystem
{
    public class MaintenanceDAL
    {
        private readonly string _ConnectionString;

        public MaintenanceDAL(string connectionString)
        {
            _ConnectionString = connectionString;
        }

        public bool addMaintenanceBill(string roomId, double amount, string expenseType, 
            string description, DateTime expenseDate)
        {
            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();

                try
                {

                    string addQuery = @"
                    DECLARE @ExpenseDate DATE;
                    SET @ExpenseDate = @Expense_param;

                    INSERT INTO Expenses(room_id, ExpenseDate, ExpenseType, Amount, Description)
                    VALUES (@roomId, @ExpenseDate, @ExpenseType, @Amount, @Description)";

                    using (SqlCommand command = new SqlCommand(addQuery, connection, transaction))
                    {

                        command.Parameters.AddWithValue("@roomId", roomId);
                        command.Parameters.AddWithValue("@Expense_param", expenseDate);
                        command.Parameters.AddWithValue("@ExpenseType", expenseType);
                        command.Parameters.AddWithValue("@Amount", amount);
                        command.Parameters.AddWithValue("@Description", description);
                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }
                catch (Exception)
                {
                    return false; 
                }
            }
        }

        public DataTable getMaintenanceList()
        {
            DataTable table = new DataTable();

            string query = @"
            SELECT 
                ExpenseID AS 'ID',
                room_id AS 'Room Number',
                ExpenseType AS 'Expense Type',
                Amount
            FROM Expenses";

            using (SqlConnection connection = new SqlConnection(_ConnectionString))
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

        public DataTable getRoomList()
        {
            DataTable room = new DataTable();

            string query = @"
            SELECT 
            room_id 
            FROM room";

            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(room);
                    }
                }
            }
            return room;
        }

        public string GetDescription(int leaseId)
        {
            string description = string.Empty;

            string query = @"
            SELECT
            Description 
            FROM Expenses
            WHERE ExpenseID = @ExpenseID";

            try
            {
                using (SqlConnection connection = new SqlConnection(_ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ExpenseID", leaseId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                description = reader["Description"]?.ToString() ?? string.Empty;
                            }
                        }
                    }
                }
            }
            catch (Exception )
            {   

            }

            return description;
        }
    }
}
