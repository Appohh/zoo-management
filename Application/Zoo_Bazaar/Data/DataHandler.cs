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
            con = GetConnection();
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
                    command.CommandText = cmd;
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
            return executeQuery(query, null);
        }
        public int executeQuery(string query, SqlParameter[]? sqlParameters)
        {

            try
            {
                con.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = (SqlConnection)con;
                    command.CommandText = query;
                    if (sqlParameters != null)
                    {
                        command.Parameters.AddRange(sqlParameters);
                    }
                    return command.ExecuteNonQuery();
                }
            }
            catch
            {
                return 0;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }

            }
        }

        public int executeIdScalar(string query)
        {
            try
            {
                con.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = (SqlConnection)con;
                    command.CommandText = query;
                    int newId = (int)command.ExecuteScalar();

                    return newId;
                }
            }
            catch { return 0; }

            finally
            {
                con.Close();
            }
        }


		public DataTable ReadDataQuery(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = (SqlConnection)con;
                    command.CommandText = query;
                    var data = command.ExecuteReader();
                    dt.Load(data);
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
            return dt;
        }

    }

}
