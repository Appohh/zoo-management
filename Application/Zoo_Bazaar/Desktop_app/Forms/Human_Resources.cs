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
            hr = (HR) loggedInUser;
            hr.MakeActive();
            InitializeComponent();

            this.Size = new Size(1521, 910);
            //lbx_test.Items.Add(String.Format(stdDetails, "Image", "FirstName", "LastName", "Email", "Job", "Phone", "Status"));
            foreach (Employee employee in hr.Repository.GetUserList().OfType<Employee>().ToList())
            {
                ListViewItem userInfo = new ListViewItem(new[] {employee.FirstName + " " + employee.LastName, employee.City, employee.BirthDate, employee.Phone, employee.Jobname, employee.SpouseName });
                userInfo.Tag = employee.Id.ToString();
                lv_Employees.Items.Add(userInfo);
            }

            //UserLoggedIn.GetList<Employee>();
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

        private void lv_Employees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_Employees.SelectedItems.Count > 0)
            {
                EmployeeNameLabel.Text = lv_Employees.SelectedItems[0].SubItems[0].Text;
            }
            else
            {
                EmployeeNameLabel.Text = "";
            }
        }

        private void btn_ViewDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            Employee? selectedUser;
            List<Employee> employeeList = new List<Employee>();
            employeeList.AddRange((IEnumerable<Employee>)hr.Repository.GetUserList(typeof(Employee)));
            selectedUser = employeeList.Find(employee => employee.Id == Convert.ToInt32(lv_Employees.SelectedItems[0].Tag)) ;
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

        private void btn_all_employees_Click(object sender, EventArgs e)
        {
            this.Hide();
            All_Employees_Form all_Employees_Form = new All_Employees_Form();
            all_Employees_Form.ShowDialog();
            if (all_Employees_Form.DialogResult == DialogResult.OK)
            {
                all_Employees_Form.Dispose();
            }
            else if (all_Employees_Form.DialogResult == DialogResult.Cancel)
            {
                all_Employees_Form.Dispose();
            }
            this.Show();

        }
    }
}
