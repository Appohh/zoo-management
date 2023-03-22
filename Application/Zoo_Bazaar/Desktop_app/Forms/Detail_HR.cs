using Logic;
using LogicCL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_app
{
    public partial class Detail_HR : Form
    {
        HR _hr;
        Employee _employee;


        public Detail_HR(HR hr, User selecteduser)
        {
            _hr = hr;
            _employee = selecteduser as Employee;




            pbProfilePic.ImageLocation = "https://cdn.britannica.com/69/65969-050-8E4B0AB9/Orangutan.jpg";


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
            NameBoxHR.Text = _employee.FirstName;
            AdressBoxHR.Text = _employee.address;
        }
    }
}
