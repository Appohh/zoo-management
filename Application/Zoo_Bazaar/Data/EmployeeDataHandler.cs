using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCL
{
    public class EmployeeDataHandler : BaseDAL//, IDataHandler
    {
        private IDbConnection con;

        public EmployeeDataHandler()
        {
            this.con = base.GetConnection();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void executeQuery()
        {
            con.Open();
            throw new NotImplementedException();
        }
    }
}