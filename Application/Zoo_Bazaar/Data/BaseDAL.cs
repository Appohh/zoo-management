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
        private string _connectionString = "Server=mssqlstud.fhict.local;Database=dbi507161;User Id=dbi507161;Password=zoobazaar123;";

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
