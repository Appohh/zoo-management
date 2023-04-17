using DataCL;
using DataCL.DTOs;
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
            ContractBoxAddEmployee.DisplayMember = "Key";
            ContractBoxAddEmployee.ValueMember = "Value";
            ContractBoxAddEmployee.Items.Add(new KeyValuePair<string, int>("Inactive", 0));
            ContractBoxAddEmployee.Items.Add(new KeyValuePair<string, int>("Active", 1));
        }

        private void ContractBoxAddEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btn_add_employee_Click(object sender, EventArgs e)
        {
            
        }
    }
}