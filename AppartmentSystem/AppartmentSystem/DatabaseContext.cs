using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppartmentSystem
{
    public class DatabaseContext
    {
        private readonly string _dbConnectionString;

        public DatabaseContext(string dbConnectionString)
        {
            if (string.IsNullOrEmpty(dbConnectionString))
                throw new ArgumentException("Connection string cannot be null or empty.", nameof(dbConnectionString));

            _dbConnectionString = dbConnectionString;
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_dbConnectionString);
        }
    }
}
