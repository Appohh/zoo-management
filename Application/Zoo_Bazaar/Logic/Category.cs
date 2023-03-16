using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Category
    {
        private int _catid;
        private string _catName;

        public Category(int catid, string catName)
        {
            _catid = catid;
            _catName = catName;
        }
    }
}
