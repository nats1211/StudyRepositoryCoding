using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppartmentSystem.ManageRoom
{
    public class roomAddingDAL
    {
        private readonly string connectionString;

        public roomAddingDAL(string connString)
        {
              connectionString = connString;
             // WHERE CONCAT(last_name, ' ', first_name, ' ', middle_name) = @full_name;
        }

        public bool AddTenant(string fullName, string roomNum, DateTime moved_IN, DateTime leaseEndDate)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string tenantUpdateQuery = @"
                UPDATE tenant
                SET room_id = @room_id,
                move_in = @move_in
                WHERE CONCAT(last_name, ' ', first_name, ' ', ISNULL(middle_name, '')) = @full_name;";

                string insertQuery = @"
                INSERT INTO LeaseDetails (room_id, tenant_name, LeaseStartDate, LeaseEndDate)
                VALUES (@room_id, @full_name, @LeaseStartDate, @LeaseEndDate);";

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand command = new SqlCommand(tenantUpdateQuery, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@room_id", roomNum);
                            command.Parameters.AddWithValue("@move_in", moved_IN);
                            command.Parameters.AddWithValue("@full_name", fullName);
                            command.ExecuteNonQuery();
                        }

                        using (SqlCommand command = new SqlCommand(insertQuery, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@room_id", roomNum);
                            command.Parameters.AddWithValue("@full_name", fullName);
                            command.Parameters.AddWithValue("@LeaseStartDate", moved_IN);
                            command.Parameters.AddWithValue("@LeaseEndDate", leaseEndDate);
                            command.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch (SqlException)
                    {
                        transaction.Rollback();
                        return false;
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }

        public bool AddRoom( string roomNum, double roomPrice)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string roomQuery = @"
                    INSERT INTO room (room_id, room_price)
                    VALUES (@room_id, @room_price)";

                    using (SqlCommand command = new SqlCommand(roomQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@room_id", roomNum);
                        command.Parameters.AddWithValue("@room_price", roomPrice);
                        command.ExecuteNonQuery();
                    }                                  
                    transaction.Commit();
                    return true;
                }
                catch (SqlException ex)
                {
                    transaction.Rollback();
                    return false;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }

        public bool DeleteRoom(string roomId)
        {
            string query = "DELETE FROM room WHERE room_id = @room_id";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@room_id", roomId);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public bool EditRoom(string roomId, string tenantName, double room_price)
        {
            string roomQuery = "UPDATE room SET room_price = @room_price WHERE room_id = @room_id";
            

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    using(SqlCommand roomCommand = new SqlCommand(roomQuery, connection, transaction))
                    {
                        roomCommand.Parameters.AddWithValue("@room_id",roomId);
                        roomCommand.Parameters.AddWithValue("@room_price", room_price);
                        roomCommand.ExecuteNonQuery();
                    }

                    

                    transaction.Commit();
                    return true;
                }
                catch (SqlException)
                {
                    transaction.Rollback();
                    return false;
                }
            }

        }

        public DataTable GetRoomTable()
        {
            DataTable dataTable = new DataTable();

            string query = @"
            SELECT
            r.room_id as 'Room Number',
            CONCAT(t.first_name, ' ', ISNULL(t.middle_name, ''), ' ', t.last_name) AS FullName,
            r.room_price as 'Rent',
            t.move_in as 'Move in'
            FROM room r
            LEFT JOIN tenant t ON r.room_id = t.room_id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

        public bool SaveLog(string action, string roomId, DateTime saveTime)
        {

            string query = @"
            INSERT INTO
            logs
            (action, room_id, timestamp)
            VALUES
            (@action, @roomId, @timeStamp)";

            
            using(SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@action", action);
                    command.Parameters.AddWithValue("@roomId", roomId);
                    command.Parameters.AddWithValue("@timeStamp", saveTime);

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool EditLog(string roomId, int roomPrice, string tenantName)
        {
            string tenantQuery = @"
            UPDATE tenant
            SET tenant_name = @tenantName
            WHERE room_id = @roomId";

            string roomQuery = @"
            UPDATE room
            SET room_price = @roomPrice
            WHERE room_id = @roomId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand tenantCommand = new SqlCommand(tenantQuery, conn, transaction))
                        {
                            tenantCommand.Parameters.AddWithValue("@roomId", roomId);
                            tenantCommand.Parameters.AddWithValue("@tenantName", tenantName);
                            tenantCommand.ExecuteNonQuery();
                        }

                        using (SqlCommand roomCommand = new SqlCommand(roomQuery, conn, transaction))
                        {
                            roomCommand.Parameters.AddWithValue("@roomId", roomId);
                            roomCommand.Parameters.AddWithValue("@roomPrice", roomPrice);
                            roomCommand.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }

        public DataTable GetEditLogs()
        {
            DataTable editLogs = new DataTable();

            string query = @"
            SELECT *
            FROM logs";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(editLogs);
                    }
                }
            }

            return editLogs;
        }

        private void AddDataToLeaseDetails(DataGridView dataGridView)
        {
            // Define the connection string
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            // SQL query to insert data into LeaseDetails table
            string insertQuery = @"
            INSERT INTO LeaseDetails (room_id,tenant_name, LeaseStartDate, LeaseEndDate)
            VALUES (@room_id, @tenant_name, @LeaseStartDate, @LeaseEndDate)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        foreach (DataGridViewRow row in dataGridView.Rows)
                        {
                            if (row.IsNewRow) continue;

                            using (SqlCommand command = new SqlCommand(insertQuery, connection, transaction))
                            {
                                // Replace these column names with the actual ones from your DataGridView
                                command.Parameters.AddWithValue("@room_id", row.Cells["Room Number"].Value);
                                command.Parameters.AddWithValue("@tenant_id", row.Cells["FullName"].Value);
                                command.Parameters.AddWithValue("@LeaseStartDate", row.Cells["LeaseStartDate"].Value ?? DBNull.Value);
                                command.Parameters.AddWithValue("@LeaseEndDate", row.Cells["LeaseEndDate"].Value ?? DBNull.Value);

                                command.ExecuteNonQuery();
                            }
                        }

                        // Commit the transaction after all rows are processed
                        transaction.Commit();
                        MessageBox.Show("Data added successfully to LeaseDetails table.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        // Rollback in case of any error
                        transaction.Rollback();
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    }
}
