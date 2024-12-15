using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace AppartmentSystem
{
    public class LeaseRepository
    {
        private readonly string _connectionString;

        public LeaseRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        //Renewal ng tenant
        public bool RenewLease(long leaseNumber, string tenantName, DateTime LeaseEndDate)
        {
            using (var connection = new SqlConnection(_connectionString))
            {

                connection.Open();

                string query = @"
                UPDATE LeaseDetails
                SET 
                Status = 'Renewed',
                LeaseStartDate = LeaseEndDate,
                LeaseEndDate = DATEADD(MONTH, 1, LeaseEndDate)
                WHERE lease_id = (SELECT lease_id FROM LeaseDetails WHERE lease_id = @leaseNumber)";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@leaseNumber", leaseNumber);
                    command.Parameters.AddWithValue("@leaseEndDate", LeaseEndDate);
                    command.ExecuteNonQuery();
             
                }

                string historyQuery = @"
                INSERT INTO history (tenant_name, action_date, process)
                VALUES (@tenantName, @actionDate, 'Renewed')";

                using (var historyCommand = new SqlCommand(historyQuery, connection))
                {
                    historyCommand.Parameters.AddWithValue("@tenantName", tenantName);
                    historyCommand.Parameters.AddWithValue("@actionDate", DateTime.Now);
                    historyCommand.ExecuteNonQuery();
                }
            }

            return true;
        }

        public bool LeftInHistory(string tenantName)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string historyQuery = @"
                INSERT INTO history (tenant_name, action_date, process)
                VALUES (@tenantName, @actionDate, 'Left')";

                using (var historyCommand = new SqlCommand(historyQuery, connection))
                {
                    historyCommand.Parameters.AddWithValue("@tenantName", tenantName);
                    historyCommand.Parameters.AddWithValue("@actionDate", DateTime.Now);
                    historyCommand.ExecuteNonQuery();
                }
            }
            return true;
        }

        public bool MoveOutTenant(long leaseNumber, string roomNumber)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {

                        string tenantQuery = @"
                        UPDATE tenant
                        SET
                        room_id = NULL
                        WHERE room_id = @roomId";

                        using (var tenantCommand = new SqlCommand(tenantQuery, connection, transaction))
                        {
                            tenantCommand.Parameters.AddWithValue("@roomId", roomNumber);
                            tenantCommand.ExecuteNonQuery();
                        }


                        string deleteRoomQuery = @"
                        DELETE FROM room
                        WHERE room_id = @roomId";

                        using (var roomCommand = new SqlCommand(deleteRoomQuery, connection, transaction))
                        {
                            roomCommand.Parameters.AddWithValue("@roomId", roomNumber);
                            roomCommand.ExecuteNonQuery();
                        }

                        string deleteLeaseQuery = @"
                        DELETE FROM LeaseDetails
                        WHERE lease_id = @leaseNumber";

                        using (var leaseCommand = new SqlCommand(deleteLeaseQuery, connection, transaction))
                        {
                            leaseCommand.Parameters.AddWithValue("@leaseNumber", leaseNumber);
                            leaseCommand.ExecuteNonQuery();
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

        public bool AddToHistory(long leaseId, string tenantName, string _process, DateTime tenantLeft)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                try
                {

                    string query = @"
                    INSERT INTO history 
                    (lease_id, tenant_name, action_date, process)
                    VALUES
                    (@lease_id, @tenantName, @actionDate, @process)";

                    using (SqlCommand command = new SqlCommand(query, sqlConnection))
                    {
                        command.Parameters.AddWithValue("@lease_id", leaseId);
                        command.Parameters.AddWithValue("@tenantName", tenantName);
                        command.Parameters.AddWithValue("@actionDate", tenantLeft);
                        command.Parameters.AddWithValue("@process", _process);
                        command.ExecuteNonQuery();

                        return true;
                    }
                }
                catch (SqlException)
                {

                    return false;
                }
                
            }
        }


        public bool editRoom(string roomId, DateTime leaseStart, DateTime leaseEnd)
        {
            string query = @"
            UPDATE lease
            set lease_start = @lease_start, lease_end = @lease_end WHERE 
            room_id = @room_id";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@room_id", roomId);
                        command.Parameters.AddWithValue("@lease_start", leaseStart);
                        command.Parameters.AddWithValue("@lease_end", leaseEnd);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("No record found with the given Room Number.");
                            return false;
                        }
                    }
                }
                catch (SqlException)
                {
                    return false;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public DataTable GetTenantRoomId()
        {
            DataTable dataTable = new DataTable();

            string query = @"
            SELECT
            lease_id as 'ID',
            room_id as 'Room Number',
            tenant_name as 'Name',
            LeaseStartDate  as 'Lease Start',
            LeaseEndDate as 'Lease End',
            Status
            FROM
            LeaseDetails";

            using (SqlConnection connection = new SqlConnection(_connectionString))
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
    }
}


/*

 */