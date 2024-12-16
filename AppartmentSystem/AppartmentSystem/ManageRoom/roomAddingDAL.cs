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

        public bool AddRoom( string roomNum, double roomPrice, string tenantName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string roomQuery = @"
                    INSERT INTO room (room_id, room_price, tenant_name)
                    VALUES (@room_id, @room_price, @tenant_name)";

                    using (SqlCommand command = new SqlCommand(roomQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@room_id", roomNum);
                        command.Parameters.AddWithValue("@room_price", roomPrice);
                        command.Parameters.AddWithValue("@tenant_name", tenantName);
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
            string leaseDelete = "DELETE FROM LeaseDetails WHERE room_id = @room_id";
            string deleteExpenses = "DELETE FROM LeaseDetails WHERE room_id = @room_id";
            string tenantQuery = @"  UPDATE tenant SET room_id = NULL WHERE room_id = @roomId";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                 
                    using (var tenantCommand = new SqlCommand(tenantQuery, connection))
                    {
                        tenantCommand.Parameters.AddWithValue("@roomId", roomId);
                        tenantCommand.ExecuteNonQuery();
                    }

                    using (SqlCommand Expensecommand = new SqlCommand(deleteExpenses, connection))
                    {
                        Expensecommand.Parameters.AddWithValue("@room_id", roomId);
                        Expensecommand.ExecuteNonQuery();
                    }

                    using (SqlCommand leasecommand = new SqlCommand(leaseDelete, connection))
                    {
                        leasecommand.Parameters.AddWithValue("@room_id", roomId);
                        leasecommand.ExecuteNonQuery();
                    }

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@room_id", roomId);
                        command.ExecuteNonQuery();
                    }
                }

                return true;

            }
            catch (SqlException)
            {
                return false;
            }
        }

        public bool EditRoom(string roomId, string tenantName, double room_price, DateTime leaseDate)
        {
            string roomQuery =   @"UPDATE room SET room_price = @room_price, tenant_name = @tenant_name WHERE room_id = @room_id";
            string tenantQuery = @"UPDATE tenant 
                                 SET room_id = @room_id, move_in = @move_in 
                                 WHERE CONCAT(last_name, ' ', first_name, ' ', ISNULL(middle_name, '')) = @full_name";

            string leaseQuery = @"
            UPDATE LeaseDetails
            SET tenant_name = @tenant_name
            WHERE room_id = @room_id";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                
                    using(SqlCommand Expensecommand = new SqlCommand(leaseQuery, connection, transaction))
                    {
                        Expensecommand.Parameters.AddWithValue("@room_id", roomId);
                        Expensecommand.Parameters.AddWithValue("@tenant_name", tenantName);
                        Expensecommand.ExecuteNonQuery();
                    }

                    using(SqlCommand roomCommand = new SqlCommand(roomQuery, connection, transaction))
                    {
                        roomCommand.Parameters.AddWithValue("@room_id",roomId);
                        roomCommand.Parameters.AddWithValue("@room_price", room_price);
                        roomCommand.Parameters.AddWithValue("@tenant_name", tenantName);
                        roomCommand.ExecuteNonQuery();
                    }

                    using (SqlCommand tenantCommand = new SqlCommand(tenantQuery, connection, transaction))
                    {
                        tenantCommand.Parameters.AddWithValue("@room_id", roomId);
                        tenantCommand.Parameters.AddWithValue("@full_name", tenantName);
                        tenantCommand.Parameters.AddWithValue("@move_in", leaseDate);
                        tenantCommand.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }
                catch (SqlException sql)
                {
                    MessageBox.Show(sql.Message);
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
            r.tenant_name as 'Name',
            r.room_price as 'Rent'
            FROM room r";

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

    }
}
