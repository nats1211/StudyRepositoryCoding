using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
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

        public bool AddRoom(string roomNum, double roomPrice, int capacity, int kitchen, int bedroom,
        int bathroom, DateTime leaseStart, DateTime leaseEndDate)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string roomQuery = @"
                    INSERT INTO room (room_id, room_price, capacity, kitchen, bedroom, bathroom)
                    VALUES (@room_id, @room_price, @capacity, @kitchen, @bedroom, @bathroom)";

                    using (SqlCommand command = new SqlCommand(roomQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@room_id", roomNum);
                        command.Parameters.AddWithValue("@room_price", roomPrice);
                        command.Parameters.AddWithValue("@capacity", capacity);
                        command.Parameters.AddWithValue("@kitchen", kitchen);
                        command.Parameters.AddWithValue("@bedroom", bedroom);
                        command.Parameters.AddWithValue("@bathroom", bathroom);
                        command.ExecuteNonQuery();
                    }

                    string insertQuery = @"
                        INSERT INTO LeaseDetails (room_id, LeaseStartDate, LeaseEndDate)
                        VALUES (@room_id, @LeaseStartDate, @LeaseEndDate)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@room_id", roomNum);
                        command.Parameters.AddWithValue("@LeaseStartDate", leaseStart);
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

        public bool EditRoom(string roomId,double room_price, DateTime leaseDate)
        {
            string roomQuery =   @"UPDATE room SET room_price = @room_price WHERE room_id = @room_id";


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
            room_id as 'House Number',
            room_price as 'Rent',
            capacity as 'Room Capacity',
            kitchen as 'Kitchen',
            bathroom as 'Bathroom'
            FROM room";

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
