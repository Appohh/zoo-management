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
            lv_Employees.Items.Add($"{"gsga"}, {"gsga"}, {"gsga"}, {"gsga"}, {"gsga"} ");
            var item2 = new ListViewItem(new[] { "sa", "saasa", "safas" });
            lv_Employees.Items.Add(item2);

            this.Size = new Size(1521, 910);
            //lbx_test.Items.Add(String.Format(stdDetails, "Image", "FirstName", "LastName", "Email", "Job", "Phone", "Status"));

            foreach (var user in hr.Repository.GetUserList(typeof(Zookeeper)))
            {
                //lbx_Employees.Items.Add((user.City, user.FirstName, user.Email, user.address));
            }

            //UserLoggedIn.GetList<Employee>();
        }

        private void lb_more_details_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_animal_HR_Click(object sender, EventArgs e)
        {
           
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
    }
}
