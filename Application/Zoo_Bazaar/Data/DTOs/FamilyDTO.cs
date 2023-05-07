using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCL.DTOs
{
    public class FamilyDTO
    {

        public int MotherID { get; set; }
        public int FatherID { get; set; }
        public FamilyDTO(int motherID, int fatherID)
        {
            MotherID = motherID;
            FatherID = fatherID;
        }
        public FamilyDTO()
        {

        }

    }
}
