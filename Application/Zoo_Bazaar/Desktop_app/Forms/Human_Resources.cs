using DataCL.DTOs;
using Desktop_app.Forms;
using LogicCL;
using LogicCL.AnimalMap;
using LogicCL.Repository;
using LogicCL.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_app
{
    public partial class Human_Resources : Form
    {
        private HR hr;
        private Employee _employee;
        private int selectedEmployeeId;

        public Human_Resources(User loggedInUser)
        {
            hr = (HR)loggedInUser;
            hr.MakeActive();
            InitializeComponent();

            this.Size = new Size(1521, 910);

            welcome_txt.Text = $"Welcome {loggedInUser.FirstName} {loggedInUser.LastName}";
            PopulateContractCombobox();
            PopulateJobCombobox();
        }

        private void Refresh()
        {
            lv_Employees.Items.Clear();
            int selected = Int16.Parse(cbbSearchEmpJob.SelectedValue.ToString());
            foreach (Employee employee in hr.Repository.GetUserList().OfType<Employee>().ToList())
            {
                string contractStatusString = "";
                if (employee.Contractstatus == 0) { contractStatusString = "Inactive"; } else if (employee.Contractstatus == 1) { contractStatusString = "Parttime"; } else if (employee.Contractstatus == 2) { contractStatusString = "Fulltime"; }
                ListViewItem userInfo = new ListViewItem(new[] { employee.FirstName + " " + employee.LastName, employee.Jobname, employee.Phone, contractStatusString });
                userInfo.Tag = employee.Id.ToString();
                lv_Employees.Items.Add(userInfo);
            }
        }

        public void FilterHr(string name, string phone, string job, string status)
        {
            var employeeList = hr.Repository.GetUserList();
            var selectedJobName = ((Job)cbbSearchEmpJob.SelectedItem).Name;
            var filteredEmployees = employeeList
                .OfType<Employee>()
                .Where(e =>
                     (string.IsNullOrEmpty(name) || e.FirstName.ToLower().Contains(name.ToLower())) &&
                    (selectedJobName == "All" || e.Jobname.ToLower() == selectedJobName.ToLower()) &&
                    (string.IsNullOrEmpty(phone) || e.Phone.ToLower().Contains(phone.ToLower())) &&
                    (status == "All" || (status == "Inactive" && e.Contractstatus == 0) || (status == "Parttime" && e.Contractstatus == 1) || (status == "Fulltime" && e.Contractstatus == 2)));

            foreach (Employee employee in filteredEmployees)
            {
                string contractStatusString = "";
                if (employee.Contractstatus == 0) { contractStatusString = "Inactive"; } else if (employee.Contractstatus == 1) { contractStatusString = "Parttime"; } else if(employee.Contractstatus == 2) { contractStatusString = "Fulltime"; }
                ListViewItem userInfo = new ListViewItem(new[] { employee.FirstName, employee.Jobname, employee.Phone, contractStatusString });
                userInfo.Tag = employee.Id.ToString();
                lv_Employees.Items.Add(userInfo);
            }
        }
        public void FilterHrAbsence(string name, string job)
        {
            var employeeList = hr.Repository.GetUserList();
            var selectedJobName = ((Job)CB_Absence_Job.SelectedItem).Name;
            var filteredEmployees = employeeList
                .OfType<Employee>()
                .Where(e =>
                     (string.IsNullOrEmpty(name) || e.FirstName.ToLower().Contains(name.ToLower())) &&
                    (selectedJobName == "All" || e.Jobname.ToLower() == selectedJobName.ToLower()));

            foreach (Employee employee in filteredEmployees)
            {
                string contractStatusString = "";
                if (employee.Contractstatus == 0) { contractStatusString = "Inactive"; } else if (employee.Contractstatus == 1) { contractStatusString = "Parttime"; } else if (employee.Contractstatus == 2) { contractStatusString = "Fulltime"; }
                ListViewItem userInfo = new ListViewItem(new[] { employee.FirstName, employee.Jobname, employee.Phone, contractStatusString });
                userInfo.Tag = employee.Id.ToString();
                lv_Scheduling.Items.Add(userInfo);
            }
        }







        private void PopulateContractCombobox()
        {
            ContractBoxAddEmployee.DisplayMember = "Key";
            ContractBoxAddEmployee.ValueMember = "Value";
            ContractBoxAddEmployee.Items.Add(new KeyValuePair<string, int>("Inactive", 0));
            ContractBoxAddEmployee.Items.Add(new KeyValuePair<string, int>("Parttime", 1));
            ContractBoxAddEmployee.Items.Add(new KeyValuePair<string, int>("Fulltime", 2));


            CB_StatusSearch.DisplayMember = "Key";
            CB_StatusSearch.ValueMember = "Value";
            CB_StatusSearch.Items.Add(new KeyValuePair<string, int>("All", -1));

            CB_StatusSearch.Items.Add(new KeyValuePair<string, int>("Inactive", 0));
            CB_StatusSearch.Items.Add(new KeyValuePair<string, int>("Parttime", 1));
            CB_StatusSearch.Items.Add(new KeyValuePair<string, int>("Fulltime", 2));

            CB_StatusSearch.SelectedIndex = 0;
        }

        private void PopulateJobCombobox()
        {
            List<Job> jobs1 = hr.GetJobList();
            List<Job> jobs2 = new List<Job>(jobs1); // Create a separate list with the same data
            List<Job> jobs3 = new List<Job>(jobs1);
            List<Job> jobs4 = new List<Job>(jobs1);

            // Create the "All" Job object and insert it at the first index
            Job allJob = new Job(0, "All");
            jobs3.Insert(0, allJob);
            jobs4.Insert(0, allJob);

            cbJobAdd.Items.Clear();
            cbJobAdd.DataSource = null;
            cbJobAdd.DataSource = jobs1;
            cbJobAdd.DisplayMember = "Name";
            cbJobAdd.ValueMember = "Id";

            cbbSearchEmpJob.Items.Clear();
            cbbSearchEmpJob.DataSource = null;
            cbbSearchEmpJob.DataSource = jobs3;
            cbbSearchEmpJob.DisplayMember = "Name";
            cbbSearchEmpJob.ValueMember = "Id";

            JobCB.Items.Clear();
            JobCB.DataSource = null;
            JobCB.DataSource = jobs2;
            JobCB.DisplayMember = "Name";
            JobCB.ValueMember = "Id";

            CB_Absence_Job.Items.Clear();
            CB_Absence_Job.DataSource = null;
            CB_Absence_Job.DataSource = jobs4;
            CB_Absence_Job.DisplayMember = "Name";
            CB_Absence_Job.ValueMember = "Id";
        }

        private void ClearInputAddEmployee()
        {
            foreach (Control control in tabAddEmployee.Controls)
            {
                if (control is TextBox)
                {
                    (control as TextBox).Text = string.Empty;
                }
                if (control is DateTimePicker)
                {
                    (control as DateTimePicker).Value = DateTime.Now;
                }
            }
        }

        


        //Overview

        

        private void btn_search_Employee_Click(object sender, EventArgs e)
        {
            lv_Employees.Items.Clear();
            FilterHr(tbSearchEmpName.Text, tbSearchEmpPhone.Text, cbbSearchEmpJob.Text, CB_StatusSearch.Text);
        }

        private void updateBTHR_Click(object sender, EventArgs e)
        {
            //employee details
            string firstName = TB_Firstname.Text;
            string lastName = TB_Lastname.Text;

            string address = TB_Address.Text;
            string city = TB_City.Text;

            string emailAddress = TB_EmailAddress.Text;

            string birthDate = BirthDateBoxHR.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");

            string bsn = TB_BSN.Text;

            int job = Convert.ToInt32(JobCB.SelectedValue);

            int contract = Convert.ToInt32(CB_Contract.SelectedIndex);

            //contact details
            string phoneNumber = TB_Phone.Text;
            string contactName = TB_ContactName.Text;

            string emergency = TB_Emregency.Text;
            string emergencyContact = TB_Emergencycontact.Text;

            string spouse = TB_Spouse.Text;
            string spouseContact = TB_SpouseContact.Text;

            // Validate input data
            List<string> errors = new List<string>();

            if (string.IsNullOrWhiteSpace(firstName))
            {
                errors.Add("Please enter first name.");
            }

            if (string.IsNullOrWhiteSpace(lastName))
            {
                errors.Add("Please enter last name.");
            }

            if (string.IsNullOrWhiteSpace(address))
            {
                errors.Add("Please enter address.");
            }

            if (string.IsNullOrWhiteSpace(city))
            {
                errors.Add("Please enter city.");
            }

            if (string.IsNullOrWhiteSpace(emailAddress))
            {
                errors.Add("Please enter email address.");
            }
            else if (!emailAddress.Contains("@"))
            {
                errors.Add("Please enter a valid email address.");
            }

            if (string.IsNullOrWhiteSpace(bsn))
            {
                errors.Add("Please enter BSN.");
            }
            else if (!int.TryParse(bsn, out int bsnNumber) || bsnNumber <= 0)
            {
                errors.Add("Please enter a valid BSN number.");
            }

            if (!int.TryParse(phoneNumber, out int phone) || phone <= 0)
            {
                errors.Add("Please enter a valid phone number.");
            }

            if (job <= 0)
            {
                errors.Add("Please select a job.");
            }

            if (contract < 0)
            {
                errors.Add("Please select a contract.");
            }

            if (errors.Count > 0)
            {
                MessageBox.Show(string.Join("\n", errors), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Call the repository to update the employee details
            if (hr.Repository.changeEmployeeDetails(selectedEmployeeId, firstName, lastName, phoneNumber, address, city, emailAddress, spouse, spouseContact, emergency, emergencyContact, birthDate, bsn, contract, job))
            {
                MessageBox.Show($"You have Updated the Employee {firstName} {lastName}");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Oops something went wrong, please contact an administrator");
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void lv_Employees_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lv_Employees.SelectedItems.Count > 0)
            {
                List<Employee> employeeList = hr.Repository.GetUserList().OfType<Employee>().ToList();

                Employee selectedUser = employeeList.Find(employee => employee.Id == Convert.ToInt32(lv_Employees.SelectedItems[0].Tag));

                CB_Contract.Items.Clear();

                CB_Contract.DisplayMember = "Key";
                CB_Contract.ValueMember = "Value";
                CB_Contract.Items.Add(new KeyValuePair<string, int>("Inactive", 0));
                CB_Contract.Items.Add(new KeyValuePair<string, int>("Parttime", 1));
                CB_Contract.Items.Add(new KeyValuePair<string, int>("Fulltime", 2));

                CB_Contract.SelectedIndex = selectedUser.Contractstatus;

                //Employee Details
                selectedEmployeeId = Convert.ToInt32(lv_Employees.SelectedItems[0].Tag);
                TB_Username.Text = selectedUser.UserName;
                TB_Password.Text = selectedUser.Password;
                TB_BSN.Text = selectedUser.BSN;
                JobCB.Text = selectedUser.Jobname;

                //Details of employee
                TB_Firstname.Text = selectedUser.FirstName;
                TB_Lastname.Text = selectedUser.LastName;
                BirthDateBoxHR.Value = DateTime.Parse(selectedUser.BirthDate);
                TB_EmailAddress.Text = selectedUser.Email;
                TB_City.Text = selectedUser.City;
                TB_Address.Text = selectedUser.address;

                //Contact
                TB_Phone.Text = selectedUser.Phone;
                TB_Emergencycontact.Text = selectedUser.EmergencyName;
                TB_Emregency.Text = selectedUser.EmergencyPhone;
                TB_Spouse.Text = selectedUser.SpouseName;
                TB_SpouseContact.Text = selectedUser.SpousePhone;
            }
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }




        //AddEmployee

        private void btn_add_employee_Click_1(object sender, EventArgs e)
        {
            //variables
            var firstName = NameBoxAddEmployee.Text;
            var lastName = SurnameBoxAddEmployee.Text;

            var userName = UsernameBoxAddEmployee.Text;
            var password = PasswordBoxAddEmployee.Text;

            var phoneNumber = PhoneNumberBoxAddEmployee.Text;
            var address = AdressBoxAddEmployee.Text;
            var city = cityAddEmployeeTB.Text;
            var email = EmailBoxAddEmployee.Text;

            string? spouseName = SpouseBoxAddEmployee.Text;
            string? spouseNumber = SpouseContactBoxAddEmployee.Text;

            var emergencyName = EmergencyContactNameBoxAddEmployee.Text;
            var emergencyNumber = EmergencyContactBoxAddEmployee.Text;

            var birthdate = BirthDateBoxAddEmployee.Value;

            var bsn = BSNBoxAddEmployee.Text;

            var contractStatus = ContractBoxAddEmployee.SelectedIndex;

            var contractType = 0;

            var image = "";

            var role = Int16.Parse(cbJobAdd.SelectedValue.ToString());

            var jobName = "";

            List<string> errors = new List<string>();

            //error handling
            if (string.IsNullOrWhiteSpace(firstName))
            {
                errors.Add("First name cannot be empty.");
            }

            if (string.IsNullOrWhiteSpace(lastName))
            {
                errors.Add("Last name cannot be empty.");
            }

            if (string.IsNullOrWhiteSpace(userName))
            {
                errors.Add("Username cannot be empty.");
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                errors.Add("Password cannot be empty.");
            }

            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                errors.Add("Phone number cannot be empty.");
            }
            else if (!Regex.IsMatch(phoneNumber, @"^[0-9]+$"))
            {
                errors.Add("Phone number can only contain numbers.");
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                errors.Add("Email cannot be empty.");
            }
            else if (!Regex.IsMatch(email, @"^.+@.+\..+$"))
            {
                errors.Add("Email is not in a valid format.");
            }

            if (!string.IsNullOrEmpty(spouseName))
            {
                SpouseContactBoxAddEmployee.ReadOnly = false;
                SpouseContactBoxAddEmployee.BackColor = Color.White;
            }
            else
            {
                SpouseContactBoxAddEmployee.ReadOnly = true;
                SpouseContactBoxAddEmployee.BackColor = Color.Gray;
            }

            if (!string.IsNullOrEmpty(spouseNumber) && !Regex.IsMatch(spouseNumber, @"^[0-9]+$"))
            {
                errors.Add("Spouse contact number can only contain numbers.");
            }

            if (!string.IsNullOrWhiteSpace(emergencyNumber) && !Regex.IsMatch(emergencyNumber, @"^[0-9]+$"))
            {
                errors.Add("Emergency contact number can only contain numbers.");
            }

            if (string.IsNullOrWhiteSpace(bsn))
            {
                errors.Add("BSN cannot be empty.");
            }
            else if (!Regex.IsMatch(bsn, @"^[0-9]+$"))
            {
                errors.Add("BSN  number can only contain numbers.");
            }

            if (birthdate > DateTime.Now.AddYears(-18))
            {
                errors.Add("Employee must be at least 18 years old.");
            }

            if (errors.Count > 0)
            {
                MessageBox.Show(string.Join("\n", errors), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UserDTO dto = new UserDTO(id: 0, firstname: firstName, lastname: lastName, username: userName, password: password,
                phone: phoneNumber, address: address, city: city, email: email, spouseName: spouseName, spousePhone: spouseNumber,
                emergencyName: emergencyName, emergencyPhone: emergencyNumber, birthdate: birthdate.ToString("yyyy-MM-dd HH:mm:ss.fff"), bSN: bsn, contractStatus: contractStatus, contactType: contractType, imageUrl: image, role, jobname: jobName);

            if (hr.RegisterNewEmployee(dto))
            {
                MessageBox.Show($"You have succesfully added the employee {NameBoxAddEmployee.Text} {SurnameBoxAddEmployee.Text}");
                ClearInputAddEmployee();
            }
            else
            {
                MessageBox.Show("Unsuccessful");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void SpouseBoxAddEmployee_TextChanged_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SpouseBoxAddEmployee.Text))
            {
                SpouseContactBoxAddEmployee.ReadOnly = false;
                SpouseContactBoxAddEmployee.BackColor = Color.White;
            }
            else
            {
                SpouseContactBoxAddEmployee.ReadOnly = true;
                SpouseContactBoxAddEmployee.BackColor = Color.Gray;
            }
        }


        //Scheduling
        private void btn_absence_search_Click(object sender, EventArgs e)
        {
            lv_Scheduling.Items.Clear();
            FilterHrAbsence(TB_Absence_Name.Text, CB_Absence_Job.Text);
        }

        private void lv_Scheduling_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_Scheduling.SelectedItems.Count > 0)
            {
                List<Employee> employeeList = hr.Repository.GetUserList().OfType<Employee>().ToList();

                Employee selectedUser = employeeList.Find(employee => employee.Id == Convert.ToInt32(lv_Scheduling.SelectedItems[0].Tag));



                //Employee Details
                TB_Absence_FirstName.Text = selectedUser.FirstName;
                TB_Absence_LastName.Text = selectedUser.LastName;
                TB_Absence_PhoneNumber.Text = selectedUser.Phone;
                
                

            }
         }
    }
}