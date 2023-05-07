using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicCL.AnimalMap
{
    public class Family
    {
        public int MotherID { get; set; }
        public int FatherID { get; set; }
        public Family(int motherID, int fatherID)
        {
            MotherID = motherID;
            FatherID = fatherID;
        }
        public Family()
        {

        }
    }
}
