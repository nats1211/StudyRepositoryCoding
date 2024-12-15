using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppartmentSystem
{
    public class tenantDAL
    {

        private readonly string _connectionString;

        public tenantDAL(string connectionString)
        {
            _connectionString = connectionString;
        }

        public bool addTenant(string _firstname, string _lastname, string _middlename, int age,
            long contact, string email)
        {

            using(SqlConnection connection = new SqlConnection(_connectionString))
            {

                connection.Open();

                SqlTransaction tran = connection.BeginTransaction();

                try
                {

                    string query = @"
                    INSERT INTO tenant
                    (first_name,last_name,middle_name,age,Contact,email_address)
                    VALUES
                    (@first_name, @last_name, @middle_name, @age, @Contact, @email_address)";

                    using(SqlCommand command = new SqlCommand(query, connection, tran))
                    {
                        command.Parameters.AddWithValue("@first_name", _firstname);
                        command.Parameters.AddWithValue("@last_name", _lastname);
                        command.Parameters.AddWithValue("@middle_name", _middlename);
                        command.Parameters.Add("@age", SqlDbType.Int).Value = age;
                        command.Parameters.Add("@Contact", SqlDbType.Int).Value = contact;
                        command.Parameters.AddWithValue("@email_address", email);
                        command.ExecuteNonQuery();
                    }

                    tran.Commit();
                    return true;
                }
                catch (Exception)
                {
                    tran.Rollback();
                    return false;
                }
            }
        }

        public DataTable getTenant()
        {
            DataTable room = new DataTable();

            string query = @"
            SELECT 
            tenant_id, 
            CONCAT(last_name, ' ', first_name, ' ', middle_name) AS full_name
            FROM 
            tenant
            ORDER BY 
            full_name";

            using (SqlConnection connection = new SqlConnection(_connectionString))
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
    }
}
