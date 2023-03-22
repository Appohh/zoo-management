using DataCL;
using DataCL.DTOs;
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

namespace Desktop_app.Forms
{
    public partial class Add_Employee_Form : Form
    {
        private HR _hr;
        public Add_Employee_Form(HR hr)
        {
            _hr = hr;   
            InitializeComponent();
            PopulateJobCombobox();
        }
        
        private void PopulateJobCombobox()
        {
            List<Job> jobs = _hr.GetJobList();
            cbJob.Items.Clear();
            cbJob.DataSource = null;
            cbJob.DataSource = jobs;
            cbJob.DisplayMember = "Name";
            cbJob.ValueMember = "Id";
        }
        private void btn_add_employee_Click(object sender, EventArgs e)
        {
            int selected = Int16.Parse(cbJob.SelectedValue.ToString());
            UserDTO dto = new UserDTO(0, NameBoxAddEmployee.Text, SurnameBoxAddEmployee.Text, UsernameBoxAddEmployee.Text, PasswordBoxAddEmployee.Text, 
                PhoneNumberBoxAddEmployee.Text, AdressBoxAddEmployee.Text, "Eindhoven", EmailBoxAddEmployee.Text, null,
                null, EmergencyContactNameBoxAddEmployee.Text, EmergencyContactBoxAddEmployee.Text, BirthDateBoxAddEmployee.Text, BSNBoxAddEmployee.Text, 0, 0, "", selected);
            _hr.RegisterNewEmployee(dto);
        }

        private void ContractBoxAddEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
