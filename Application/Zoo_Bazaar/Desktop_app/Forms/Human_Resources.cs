using DataCL.DTOs;
using Desktop_app.Forms;
using LogicCL;
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

        public Human_Resources(User loggedInUser)//needs parameter later
        {
            hr = (HR)loggedInUser;
            hr.MakeActive();
            InitializeComponent();

            this.Size = new Size(1521, 910);
            //lbx_test.Items.Add(String.Format(stdDetails, "Image", "FirstName", "LastName", "Email", "Job", "Phone", "Status"));

            welcome_txt.Text = $"Welcome {loggedInUser.FirstName} {loggedInUser.LastName}";
            PopulateJobCombobox();
            PopulateJobSearchCombobox();
            //UserLoggedIn.GetList<Employee>();
            //test
        }

        private void Refresh()
        {
            lv_Employees.Items.Clear();
            int selected = Int16.Parse(cbbSearchEmpJob.SelectedValue.ToString());
            foreach (Employee employee in hr.Repository.GetUserList().OfType<Employee>().ToList())
            {
                string dateFriendly = DateTime.Parse(employee.BirthDate).ToString("dd-MMMM-yyyy");
                ListViewItem userInfo = new ListViewItem(new[] { employee.FirstName + " " + employee.LastName, employee.City, dateFriendly, employee.Phone, employee.Jobname, employee.SpouseName });
                userInfo.Tag = employee.Id.ToString();
                lv_Employees.Items.Add(userInfo);
            }
        }

        public void FilterHr(string name, string phone, string job)
        {
            lv_Employees.Items.Clear();

            foreach (Employee employee in hr.Repository.GetUserList().OfType<Employee>().Where(e => e.Jobname.ToLower().Equals(job.ToLower()) && (e.FirstName + " " + e.LastName).ToLower().Contains(name.ToLower()) && e.Phone.ToLower().Contains(phone.ToLower())).ToList())
            {
                string dateFriendly = DateTime.Parse(employee.BirthDate).ToString("dd-MMMM-yyyy");
                ListViewItem userInfo = new ListViewItem(new[] { employee.FirstName + " " + employee.LastName, employee.City, dateFriendly, employee.Phone, employee.Jobname, employee.SpouseName });
                userInfo.Tag = employee.Id.ToString();
                lv_Employees.Items.Add(userInfo);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var add_Employee_Form = new Add_Employee_Form(hr);
            add_Employee_Form.ShowDialog();
            if (add_Employee_Form.DialogResult == DialogResult.OK)
            {
                add_Employee_Form.Dispose();
            }
            else if (add_Employee_Form.DialogResult == DialogResult.Cancel)
            {
                MessageBox.Show("Operation Canceled");
                add_Employee_Form.Dispose();
            }
            this.Show();
        }

        private void btn_ViewDetails_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            List<Employee> employeeList = hr.Repository.GetUserList().OfType<Employee>().ToList();

            User selectedUser = employeeList.Find(employee => employee.Id == Convert.ToInt32(lv_Employees.SelectedItems[0].Tag));

            Detail_HR detail_HR = new Detail_HR(hr, selectedUser);
            detail_HR.ShowDialog();
            if (detail_HR.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Yes");
                detail_HR.Dispose();
            }
            else if (detail_HR.DialogResult == DialogResult.Cancel)
            {
                detail_HR.Dispose();
            }
            this.Show();
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
            FilterHr(tbSearchEmpName.Text, tbSearchEmpPhone.Text, cbbSearchEmpJob.Text);
        }

        private void updateBTHR_Click_1(object sender, EventArgs e)
        {
            {
                //selected index - please check oskar
                //int selectedIndex = lv_Employees.SelectedIndices.Count;// unsure

                //acc details
                string userName = TB_Username.Text;
                string password = TB_Password.Text;

                //employee details
                string firstName = TB_Firstname.Text;
                string lastName = TB_Lastname.Text;

                string address = TB_Address.Text;
                string city = TB_City.Text;

                string emailAddress = TB_EmailAddress.Text;

                string birthDate = BirthDateBoxHR.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");

                string bsn = TB_BSN.Text;

                string job = TB_Job.Text;

                int contract = Convert.ToInt32(CB_Contract.SelectedValue);

                //contact details
                string phoneNumber = TB_Phone.Text;
                string contactName = TB_ContactName.Text;

                string emergency = TB_Emregency.Text;
                string emergencyContact = TB_Emergencycontact.Text;

                string spouse = TB_Spouse.Text;
                string spouseContact = TB_SpouseContact.Text;

                if (hr.Repository.changeEmployeeDetails(selectedEmployeeId, firstName, lastName, phoneNumber, address, city, emailAddress, spouse, spouseContact, emergency, emergencyContact, birthDate, bsn, contract))
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
                TB_Job.Text = selectedUser.Jobname;
                //CB_Contract.Text = Convert.ToString(selectedUser.Contractstatus);

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
            int selected = Int16.Parse(cbJob.SelectedValue.ToString());
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

        private void PopulateJobCombobox()
        {
            List<Job> jobs = hr.GetJobList();
            cbJob.Items.Clear();
            cbJob.DataSource = null;
            cbJob.DataSource = jobs;
            cbJob.DisplayMember = "Name";
            cbJob.ValueMember = "Id";
            ContractBoxAddEmployee.DisplayMember = "Key";
            ContractBoxAddEmployee.ValueMember = "Value";
            ContractBoxAddEmployee.Items.Add(new KeyValuePair<string, int>("Inactive", 0));
            ContractBoxAddEmployee.Items.Add(new KeyValuePair<string, int>("Active", 1));
        }

        private void PopulateJobSearchCombobox()
        {
            List<Job> jobs = hr.GetJobList();
            cbbSearchEmpJob.Items.Clear();
            cbbSearchEmpJob.DataSource = null;
            cbbSearchEmpJob.DataSource = jobs;
            cbbSearchEmpJob.DisplayMember = "Name";
            cbbSearchEmpJob.ValueMember = "Id";
        }

        private void ClearInputAddEmployee()
        {
            foreach(Control control in tabAddEmployee.Controls)
            {
                if (control is TextBox)
                {
                    (control as TextBox).Text = string.Empty;
                }
                if(control is DateTimePicker)
                {
                    (control as DateTimePicker).Value = DateTime.Now;
                }

            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}