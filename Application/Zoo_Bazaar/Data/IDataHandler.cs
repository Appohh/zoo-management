using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCL
{
    public interface IDataHandler
    {
        DataTable ReadData();

        int executeQuery(string query);    
    }
}
