using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicCL.Users
{
    public class Salary
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }

        public int SalaryValue { get; set; }

        public Salary()
        { }

        public Salary(int id, int employeeId, int salaryValue)
        {
            Id = id;
            EmployeeId = employeeId;
            SalaryValue = salaryValue;
        }
    }
}