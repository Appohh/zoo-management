using DataCL.DTOs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCL
{
    public class UserDataHandler : BaseDAL, IDataHandler
    {
        private IDbConnection con;
        protected virtual string cmd { get; }

        public UserDataHandler()
        {
            this.con = base.GetConnection();
        }

        public DataTable ReadData() //read
        {
            DataTable result = new DataTable();
            using (var connection = con)
            {
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = (SqlConnection)connection;
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
                    connection.Close();
                }
                
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
