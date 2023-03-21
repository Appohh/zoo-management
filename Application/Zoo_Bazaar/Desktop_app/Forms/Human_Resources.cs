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
        private HR hr;
        
        public Human_Resources(User loggedInUser)//needs parameter later
        {
            hr = (HR) loggedInUser;
            hr.MakeActive();
            InitializeComponent();
            lv_Employees.Items.Add($"{"gsga"}, {"gsga"}, {"gsga"}, {"gsga"}, {"gsga"} ");
            this.Size = new Size(1521, 910);
            //lbx_test.Items.Add(String.Format(stdDetails, "Image", "FirstName", "LastName", "Email", "Job", "Phone", "Status"));

            foreach (var user in hr.Repository.GetUserList(typeof(Zookeeper)))
            {
                //lbx_Employees.Items.Add((user.City, user.FirstName, user.Email, user.address));
            }

            //UserLoggedIn.GetList<Employee>();
        }

        private void btn_add_employee_HR_Click(object sender, EventArgs e)
        {

        }

        private void lb_more_details_Click(object sender, EventArgs e)
        {

        }
    }
}
