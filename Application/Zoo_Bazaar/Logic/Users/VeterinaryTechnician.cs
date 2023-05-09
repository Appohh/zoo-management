﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicCL.Repository;

namespace LogicCL.Users
{
    public class VeterinaryTechnician : Employee
    {
        public AnimalRepository Repository { get; private set; }

        public VeterinaryTechnician(string? spouseName, string? spousePhone, string emergencyName, string emergencyPhone, string bSN, int contractstatus, string image, int id, string firstName, string lastname, string userName, string password, string email, string phone, string birthDate, string address, string city, string jobname) : base(spouseName, spousePhone, emergencyName, emergencyPhone, bSN, contractstatus, image, id, firstName, lastname, userName, password, email, phone, birthDate, address, city, jobname)
        {
            Repository = new AnimalRepository();
        }
        public void MakeActive()
        {
            Repository = new AnimalRepository();
        }
    }
}