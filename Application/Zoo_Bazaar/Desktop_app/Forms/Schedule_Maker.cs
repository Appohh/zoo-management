using DataCL.DTOs;
using LogicCL;
using LogicCL.AnimalMap;
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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Desktop_app.Forms
{
    public partial class Schedule_Maker : Form
    {
        //list abscence<>
        //list employee<>
        private ScheduleMaker scheduleMaker;
        List<Employee> available;
        Employee selected;
        public Schedule_Maker(User loggedInUser)
        {
            scheduleMaker = (ScheduleMaker)loggedInUser;
            scheduleMaker.MakeActive();
            InitializeComponent();
            PopulateComboboxes();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            //ADD
            
            //(lists of data should be up to date everytime)

            //foreach employee
            //check if employee is absent this date

            //get employee contract type to see if he is not working, or how many hours this employee can work this week (fulltime, parttime)
            //check how many hours employee works this week.

            //check if employee already works on SELECTED shift
            //check if employee already works 2 shifts THIS day


            //IF employee is zookeeper Location-combobox = visible AND Required!


            //add employee to list of available employees
        }

        private void btnViewAvailable_Click(object sender, EventArgs e)
        {
            lv_Employees.Items.Clear();

            DateTime date = dtPickerEmp.Value;

            available = scheduleMaker.Repository.GetAvailble(date);

            foreach (Employee employee in available)
            {
                string contractStatusString = employee.Contractstatus == 0 ? "inactive" : "active";
                ListViewItem userInfo = new ListViewItem(new[] { employee.FirstName, employee.Jobname, employee.Phone, contractStatusString });
                userInfo.Tag = employee.Id.ToString();
                lv_Employees.Items.Add(userInfo);
            }
        }

        private void btnLoadShiftData_Click(object sender, EventArgs e)
        {
            selected = available.Find(e => e.Id == Convert.ToInt32(lv_Employees.SelectedItems[0].Tag));
            lbSelectedEmp.Text = $"Employee: {selected.FirstName + selected.LastName}";
            List<Shift> shifts = scheduleMaker.Repository.GetShiftsByEmpId(selected.Id);           
            shiftDGV.DataSource = shifts;
            shiftDGV.Invalidate();
            if (selected.Jobname.ToLower().Contains("caretaker"))
            {
                cbbShiftLocation.Enabled= true;
            }
            else
            {
                cbbShiftLocation.Enabled = false;
            }
        }

        private void btnAddShift_Click(object sender, EventArgs e)
        {
            if (selected != null)
            {
                DateTime date = dtPickerShift.Value;
                int id = Convert.ToInt32(lv_Employees.SelectedItems[0].Tag);
                if (scheduleMaker.Repository.HoursWorkedThisDay(id, date) >= 8)
                {
                    MessageBox.Show("Maximum shift amount reached");
                }
                else if (!scheduleMaker.Repository.ShiftExisted(id, date, cbbShiftType.SelectedIndex))
                {
                    ShiftDTO shift = new ShiftDTO();
                    shift.EmpId = id;
                    shift.Date = date.ToString("yyyy-MM-dd");
                    shift.Type = cbbShiftType.SelectedIndex;

                    if (cbbShiftLocation.Enabled = true)
                    {
                        shift.Location = Int16.Parse(cbbShiftLocation.SelectedValue.ToString());
                    }

                    if (scheduleMaker.Repository.AddShift(shift))
                    {
                        MessageBox.Show("Ok");
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
                else
                {
                    MessageBox.Show("Shift Already Existed");
                }
                
            }
            else
            {
                MessageBox.Show("Please select an employee");
            }
        }

        private void PopulateComboboxes()
        {
           
            List<Location> locations = scheduleMaker.Repository.GetLocations();
            cbbShiftLocation.Items.Clear();
            cbbShiftLocation.DataSource = null;
            cbbShiftLocation.DataSource = locations;
            cbbShiftLocation.DisplayMember = "Name";
            cbbShiftLocation.ValueMember = "Id";

            cbbShiftType.DisplayMember = "Key";
            cbbShiftType.ValueMember = "Value";
            cbbShiftType.Items.Add(new KeyValuePair<string, int>("Day", 0));
            cbbShiftType.Items.Add(new KeyValuePair<string, int>("Afternoon", 1));
            cbbShiftType.Items.Add(new KeyValuePair<string, int>("Night", 2));
            cbbShiftType.SelectedIndex = 0;
        }
    }
}
