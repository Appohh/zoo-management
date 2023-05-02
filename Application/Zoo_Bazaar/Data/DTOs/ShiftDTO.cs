﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCL.DTOs
{
    public class ShiftDTO
    {
        public int Id { get; set; }

        public int EmpId { get; set; }

        public int Type { get; set; }

        public string Date { get; set; }

        public ShiftDTO()
        {

        }

        public ShiftDTO(int id, int empId, int type, string date)
        {
            Id = id;
            EmpId = empId;
            Type = type;
            Date = date;
        }
    }
}
