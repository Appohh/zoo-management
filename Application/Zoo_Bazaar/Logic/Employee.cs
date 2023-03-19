﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public abstract class Employee : User
    {
        public string? SpouseName { get; set; }
        public string? SpousePhone { get; set; }
        public string EmergencyName { get; set; }
        public string EmergencyPhone { get; set;}
        public string BSN { get; set; }
        public int Contractstatus { get; set; } //needs custom set for name with if's

        protected Employee(string? spouseName, string? spousePhone, string emergencyName, string emergencyPhone, string bSN, int contractstatus)
        {
            SpouseName = spouseName;
            SpousePhone = spousePhone;
            EmergencyName = emergencyName;
            EmergencyPhone = emergencyPhone;
            BSN = bSN;
            Contractstatus = contractstatus;
        }
    }
}
