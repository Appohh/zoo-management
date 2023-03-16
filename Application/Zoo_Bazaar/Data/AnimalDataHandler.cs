using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCL
{
    public class AnimalDataHandler : BaseDAL, IDataHandler
    {
        private IDbConnection con;
        public void Connect()
        {
            con = base.GetConnection();
            con.Open();
        }

        public void Disconnect()
        {
            con.Close();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void executeQuery()
        {
            throw new NotImplementedException();
        }
    }
}
