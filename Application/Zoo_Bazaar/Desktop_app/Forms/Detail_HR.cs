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
    public partial class Detail_HR : Form
    {
        HR _hr;
        Employee _selectedEmployee;


        public Detail_HR(HR hr, Employee selectedEmployee)
        {
            _hr = hr;
            _selectedEmployee = selectedEmployee;

            InitializeComponent();
            PopulateEmployeeDetails();
        }


        private void Detail_HR_FormClosing(object sender, FormClosingEventArgs e)
        {
/*            User user;
            Human_Resources human = new Human_Resources(user);
*/            
        }

        private void PopulateEmployeeDetails()
        {
            NameBoxHR.Text = _selectedEmployee.FirstName;
            NameBoxHR.Text = _selectedEmployee.Jobname;
        }
    }
}
