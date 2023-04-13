using Desktop_app.Forms;
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
            hr = (HR)loggedInUser;
            hr.MakeActive();
            InitializeComponent();

            this.Size = new Size(1521, 910);
            //lbx_test.Items.Add(String.Format(stdDetails, "Image", "FirstName", "LastName", "Email", "Job", "Phone", "Status"));

            welcome_txt.Text = $"Welcome {loggedInUser.FirstName} {loggedInUser.LastName}";

            //UserLoggedIn.GetList<Employee>();
            //test
        }

        private void Refresh()
        {
            lv_Employees.Items.Clear();
            foreach (Employee employee in hr.Repository.GetUserList().OfType<Employee>().ToList())
            {
                string dateFriendly = DateTime.Parse(employee.BirthDate).ToString("dd-MMMM-yyyy");
                ListViewItem userInfo = new ListViewItem(new[] { employee.FirstName + " " + employee.LastName, employee.City, dateFriendly, employee.Phone, employee.Jobname, employee.SpouseName });
                userInfo.Tag = employee.Id.ToString();
                lv_Employees.Items.Add(userInfo);
            }
        }

        public void FilterHr(string search)
        {
            lv_Employees.Items.Clear();
            foreach (Employee employee in hr.Repository.GetUserList().OfType<Employee>().Where(e => !e.Jobname.ToLower().Contains(search) && (e.FirstName + " " + e.LastName).ToLower().Contains(search.ToLower()) || e.Email.ToLower().Contains(search.ToLower())).ToList())
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

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void artanPanel4_Paint(object sender, PaintEventArgs e)
        {
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

        private void lbEmployeeName_Click(object sender, EventArgs e)
        {
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

        private void txt_Welcome_Click(object sender, EventArgs e)
        {
        }

        private void Tab_Welcome_Click(object sender, EventArgs e)
        {
            //test
        }

        private void btn_search_Employee_Click(object sender, EventArgs e)
        {
            FilterHr(txt_search.Text);
        }

        private void lbl_firstname_Click(object sender, EventArgs e)
        {
        }

        private void updateBTHR_Click(object sender, EventArgs e)
        {
            //selected index - please check oskar
            int selectedIndex = lv_Employees.SelectedIndices.Count;// unsure

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

            int contract = TB_Contact.TabIndex;// unsure

            //contact details
            string phoneNumber = TB_Phone.Text;
            string contactName = TB_ContactName.Text;

            string emergency = TB_Emregency.Text;
            string emergencyContact = TB_Emergencycontact.Text;

            string spouse = TB_Spouse.Text;
            string spouseContact = TB_SpouseContact.Text;

            if (hr.Repository.changeEmployeeDetails(selectedIndex, firstName, lastName, phoneNumber, address, city, emailAddress, spouse, spouseContact, emergency, emergencyContact, birthDate, bsn, contract))
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

        private void label31_Click(object sender, EventArgs e)
        {
        }
    }
}