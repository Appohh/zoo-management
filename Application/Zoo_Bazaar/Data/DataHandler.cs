using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCL
{
    public class DataHandler : BaseDAL, IDataHandler
    {
        private IDbConnection con;
        protected virtual string cmd { get; }

        public DataHandler()
        {
            this.con = base.GetConnection();
        }

        public DataTable ReadData() //read
        {
            DataTable result = new DataTable();
            try
            {
                con.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = (SqlConnection)con;
                    //get command
                    command.CommandText = this.cmd;
                    //get data
                    var data = command.ExecuteReader();
                    //fill datatable with querried data
                    result.Load(data);
                }
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public int executeQuery(string query)
        {
            using (var connection = con)
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = (SqlConnection)connection;
                    command.CommandText = query;
                    return command.ExecuteNonQuery();
                }
            }
        }

    }

}
