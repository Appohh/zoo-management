using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCL
{
    public abstract class BaseDAL
    {
        private string _connectionString = "";

        protected IDbConnection GetConnection()
        {
            IDbConnection connection = new SqlConnection(_connectionString);
            return connection;
        }
        public BaseDAL()
        {

        }


    }
}
