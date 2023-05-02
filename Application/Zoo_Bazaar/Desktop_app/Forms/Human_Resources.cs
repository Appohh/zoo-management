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
                string contractStatusString = employee.Contractstatus == 0 ? "inactive" : "active";
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
                    (status == "All" || (status == "Inactive" && e.Contractstatus == 0) || (status == "Active" && e.Contractstatus == 1)));



            foreach (Employee employee in filteredEmployees)
            {
                string contractStatusString = employee.Contractstatus == 0 ? "inactive" : "active";
                ListViewItem userInfo = new ListViewItem(new[] { employee.FirstName, employee.Jobname, employee.Phone, contractStatusString });
                userInfo.Tag = employee.Id.ToString();
                lv_Employees.Items.Add(userInfo);
            }
        }

        private void lv_Employees_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lv_Employees.SelectedItems.Count > 0)
            {
                lbEmployeeName.Text = lv_Employees.SelectedItems[0].SubItems[0].Text;
            }
            else
            {
                lbEmployeeName.Text = "";
            }
        }

        private void btn_search_Employee_Click_1(object sender, EventArgs e)
        {
            lv_Employees.Items.Clear();
            FilterHr(tbSearchEmpName.Text, tbSearchEmpPhone.Text, cbbSearchEmpJob.Text, CB_StatusSearch.Text);
        }

        private void updateBTHR_Click_1(object sender, EventArgs e)
        {
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

                if (hr.Repository.changeEmployeeDetails(selectedEmployeeId, firstName, lastName, phoneNumber, address, city, emailAddress, spouse, spouseContact, emergency, emergencyContact, birthDate, bsn, contract, job))
                {
                    MessageBox.Show("Success");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Oops something went wrong, please contact an administrator");
                    this.DialogResult = DialogResult.Cancel;
                }
            }
        }

        private void lv_Employees_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lv_Employees.SelectedItems.Count > 0)
            {
                List<Employee> employeeList = hr.Repository.GetUserList().OfType<Employee>().ToList();

                Employee selectedUser = employeeList.Find(employee => employee.Id == Convert.ToInt32(lv_Employees.SelectedItems[0].Tag));

                CB_Contract.Items.Clear();

                CB_Contract.DisplayMember = "Key";
                CB_Contract.ValueMember = "Value";
                CB_Contract.Items.Add(new KeyValuePair<string, int>("Inactive", 0));
                CB_Contract.Items.Add(new KeyValuePair<string, int>("Active", 1));
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

        private void btn_add_employee_Click(object sender, EventArgs e)
        {
            int selected = Int16.Parse(cbJobAdd.SelectedValue.ToString());
            UserDTO dto = new UserDTO(0, NameBoxAddEmployee.Text, SurnameBoxAddEmployee.Text, UsernameBoxAddEmployee.Text, PasswordBoxAddEmployee.Text,
                PhoneNumberBoxAddEmployee.Text, AdressBoxAddEmployee.Text, AdressBoxAddEmployee.Text, EmailBoxAddEmployee.Text, SpouseBoxAddEmployee.Text,
                SpouseContactBoxAddEmployee.Text, EmergencyContactNameBoxAddEmployee.Text, EmergencyContactBoxAddEmployee.Text, BirthDateBoxAddEmployee.Value.ToString("yyyy-MM-dd HH:mm:ss.fff"), BSNBoxAddEmployee.Text, ContractBoxAddEmployee.SelectedIndex, 0, "", selected, "");
            if (hr.RegisterNewEmployee(dto))
            {
                MessageBox.Show("Successful");
                ClearInputAddEmployee();
            }
            else
            {
                MessageBox.Show("Unsuccessful");
            }
        }

        private void PopulateContractCombobox()
        {
            ContractBoxAddEmployee.DisplayMember = "Key";
            ContractBoxAddEmployee.ValueMember = "Value";
            ContractBoxAddEmployee.Items.Add(new KeyValuePair<string, int>("Inactive", 0));
            ContractBoxAddEmployee.Items.Add(new KeyValuePair<string, int>("Active", 1));

            CB_StatusSearch.DisplayMember = "Key";
            CB_StatusSearch.ValueMember = "Value";
            CB_StatusSearch.Items.Add(new KeyValuePair<string, int>("All", -1));

            CB_StatusSearch.Items.Add(new KeyValuePair<string, int>("Inactive", 0));
            CB_StatusSearch.Items.Add(new KeyValuePair<string, int>("Active", 1));
            CB_StatusSearch.SelectedIndex = 0;
        }

        private void PopulateJobCombobox()
        {


            List<Job> jobs1 = hr.GetJobList();
            List<Job> jobs2 = new List<Job>(jobs1); // Create a separate list with the same data
            List<Job> jobs3 = new List<Job>(jobs1);

            // Create the "All" Job object and insert it at the first index
            Job allJob = new Job(0, "All");
            jobs3.Insert(0, allJob);

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

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Tab_Overview_Click(object sender, EventArgs e)
        {

        }
    }
}