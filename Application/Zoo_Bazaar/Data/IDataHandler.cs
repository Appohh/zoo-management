using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCL
{
    public interface IDataHandler
    {
        void Update();

        int executeQuery(string query);    
    }
}
