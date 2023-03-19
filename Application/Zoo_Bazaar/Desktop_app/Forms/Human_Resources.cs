using Logic;
using LogicCL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_app
{
    public partial class Human_Resources : Form
    {
        UserManagement userManagement = new UserManagement();
        //String stdDetails = "{0,-15}{1,-20}{2,-20}{3,-20}{4,-20}{5,-20}{6,-20}";
        public Human_Resources()//needs parameter later
        {

            InitializeComponent();
            this.Size = new Size(1521, 910);
            //lbx_test.Items.Add(String.Format(stdDetails, "Image", "FirstName", "LastName", "Email", "Job", "Phone", "Status"));
            List<Type> types = new List<Type>();
            types.Add(typeof(string));
            types.Add(typeof(int));
            foreach (var user in userManagement.getUserList(typeof(Employee)))
            {
                lbx_Employees.Items.Add((user.City, user.FirstName, user.Email, user.address, user.s));
            }

            //UserLoggedIn.GetList<Employee>();
        }
    }
}
