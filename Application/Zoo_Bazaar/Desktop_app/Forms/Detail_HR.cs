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
        private HR _hr;
        private Employee _employee;

        public Detail_HR(HR hr, User selecteduser)
        {
            _hr = hr;
            _employee = selecteduser as Employee;

            // pbProfilePic.ImageLocation = "https://cdn.britannica.com/69/65969-050-8E4B0AB9/Orangutan.jpg";

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
            //Combobox
            ContractBoxHR.Items.Clear();

            ContractBoxHR.Items.Add(new { Text = "Active", Value = 1 });
            ContractBoxHR.Items.Add(new { Text = "Inactive", Value = 0 });

            //Employee Details
            UsernameBoxHR.Text = _employee.UserName;
            BSNBoxHR.Text = _employee.BSN;
            jobBoxHR.Text = _employee.Jobname;
            ContractBoxHR.Text = Convert.ToString(_employee.Contractstatus);

            //Details of employee
            NameBoxHR.Text = _employee.FirstName;
            LastnameBoxHR.Text = _employee.LastName;
            BirthDateBoxHR.Value = DateTime.Parse(_employee.BirthDate);
            EmailBoxHR.Text = _employee.Email;
            AdressBoxHR.Text = _employee.address;

            //Contact
            PhoneNumberBoxHR.Text = _employee.Phone;
            EmergencyContactNameBoxHR.Text = _employee.EmergencyName;
            EmergencyContactBoxHR.Text = _employee.EmergencyPhone;
            SpouseBoxHR.Text = _employee.SpouseName;
            SpouseContactBoxHR.Text = _employee.SpousePhone;
        }
    }
}