using DataCL.DTOs;
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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Desktop_app.Forms
{
	public partial class Schedule_Maker : Form
	{
		//list abscence<>
		//list employee<>
		private ScheduleMaker scheduleMaker;
		private List<Employee> available;
		private Employee selected;
		private WeekSchedule currentWeekSchedule;
		private List<Location> locations;
		private ScheduleFactory scheduleFactory;
		public List<Shift> CurrentWeekShifts { get; set; }
		public Schedule_Maker(User loggedInUser)
		{
			scheduleMaker = (ScheduleMaker)loggedInUser;
			scheduleMaker.MakeActive();
			InitializeComponent();
			PopulateComboboxes();
			currentWeekSchedule = new WeekSchedule(DateTime.Now);
			CurrentWeekShifts = new List<Shift>();
			scheduleFactory = new ScheduleFactory();

			weekNum.Text = currentWeekSchedule.Week.ToString();
			lblTimeRange.Text = $"{currentWeekSchedule.Monday.ToShortDateString()} - {currentWeekSchedule.Sunday.ToShortDateString()}";
			PanelSetup();
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




		private void PopulateComboboxes()
		{

			locations = scheduleMaker.Repository.GetLocations();
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


			List<Job> jobs = scheduleMaker.Repository.GetJobList();
			Job None = new Job(-1, "None");
			jobs.Insert(0, None);
			CB_GetShiftByJob.Items.Clear();
			CB_GetShiftByJob.DataSource = null;
			CB_GetShiftByJob.DataSource = jobs;
			CB_GetShiftByJob.DisplayMember = "Name";
			CB_GetShiftByJob.ValueMember = "Id";


		}

		private void PanelSetup()
		{
			List<Control> shiftPanels = new List<Control>();

			foreach (Control control in tabPageSchedule.Controls)
			{
				if (control is FlowLayoutPanel)
				{
					shiftPanels.Add(control);
				}
			}

			foreach (FlowLayoutPanel control in shiftPanels)
			{
				control.AutoScroll = true;
				control.WrapContents = true;
				control.HorizontalScroll.Visible = false;
			}

			satA.BackColor = Color.Gray;
			satD.BackColor = Color.Gray;
			satN.BackColor = Color.Gray;
			sunA.BackColor = Color.Gray;
			sunD.BackColor = Color.Gray;
			sunN.BackColor = Color.Gray;
		}

		private void ClearAllPanels()
		{
			List<Control> shiftPanels = new List<Control>();

			foreach (Control control in tabPageSchedule.Controls)
			{
				if (control is FlowLayoutPanel)
				{
					shiftPanels.Add(control);
				}
			}

			foreach (Control control in shiftPanels)
			{
				control.Controls.Clear();
			}
		}

		private void DrawShiftPanel(CustomPanel p)
		{
			switch (DateTime.Parse(p.Shift.Date).DayOfWeek)
			{
				case DayOfWeek.Sunday:
					if (p.Shift.Type == 0)
					{
						sunD.Controls.Add(p);
						sunD.Controls.SetChildIndex(p, 0);
						sunD.Invalidate();
						break;
					}
					if (p.Shift.Type == 1)
					{
						sunA.Controls.Add(p);
						sunA.Controls.SetChildIndex(p, 0);
						sunA.Invalidate();
						break;
					}
					sunN.Controls.Add(p);
					sunN.Controls.SetChildIndex(p, 0);
					sunN.Invalidate();
					break;
				case DayOfWeek.Saturday:
					if (p.Shift.Type == 0)
					{
						satD.Controls.Add(p);
						satD.Controls.SetChildIndex(p, 0);
						satD.Invalidate();
						break;
					}
					if (p.Shift.Type == 1)
					{
						satA.Controls.Add(p);
						satA.Controls.SetChildIndex(p, 0);
						satA.Invalidate();
						break;
					}
					satN.Controls.Add(p);
					satN.Controls.SetChildIndex(p, 0);
					satN.Invalidate();
					break;
				case DayOfWeek.Friday:
					if (p.Shift.Type == 0)
					{
						friD.Controls.Add(p);
						friD.Controls.SetChildIndex(p, 0);
						friD.Invalidate();
						break;
					}
					if (p.Shift.Type == 1)
					{
						friA.Controls.Add(p);
						friA.Controls.SetChildIndex(p, 0);
						friA.Invalidate();
						break;
					}
					friN.Controls.Add(p);
					friN.Controls.SetChildIndex(p, 0);
					friN.Invalidate();
					break;
				case DayOfWeek.Thursday:
					if (p.Shift.Type == 0)
					{
						thuD.Controls.Add(p);
						thuD.Controls.SetChildIndex(p, 0);
						thuD.Invalidate();
						break;
					}
					if (p.Shift.Type == 1)
					{
						thuA.Controls.Add(p);
						thuA.Controls.SetChildIndex(p, 0);
						thuA.Invalidate();
						break;
					}
					thuN.Controls.Add(p);
					thuN.Controls.SetChildIndex(p, 0);
					thuN.Invalidate();
					break;
				case DayOfWeek.Wednesday:
					if (p.Shift.Type == 0)
					{
						wedD.Controls.Add(p);
						wedD.Controls.SetChildIndex(p, 0);
						wedD.Invalidate();
						break;
					}
					if (p.Shift.Type == 1)
					{
						wedA.Controls.Add(p);
						wedA.Controls.SetChildIndex(p, 0);
						wedA.Invalidate();
						break;
					}
					wedN.Controls.Add(p);
					wedN.Controls.SetChildIndex(p, 0);
					wedN.Invalidate();
					break;
				case DayOfWeek.Tuesday:
					if (p.Shift.Type == 0)
					{
						tueD.Controls.Add(p);
						tueD.Controls.SetChildIndex(p, 0);
						tueD.Invalidate();
						break;
					}
					if (p.Shift.Type == 1)
					{
						tueA.Controls.Add(p);
						tueA.Controls.SetChildIndex(p, 0);
						tueA.Invalidate();
						break;
					}
					tueN.Controls.Add(p);
					tueN.Controls.SetChildIndex(p, 0);
					tueN.Invalidate();
					break;
				default:
					if (p.Shift.Type == 0)
					{
						monD.Controls.Add(p);
						monD.Controls.SetChildIndex(p, 0);
						monD.Invalidate();
						break;
					}
					if (p.Shift.Type == 1)
					{
						monA.Controls.Add(p);
						monA.Controls.SetChildIndex(p, 0);
						monA.Invalidate();
						break;
					}
					monN.Controls.Add(p);
					monN.Controls.SetChildIndex(p, 0);
					monN.Invalidate();
					break;
			}
		}

		private void datePicker_ValueChanged(object sender, EventArgs e)
		{
			DrawSchedule();

		}

		private void DrawSchedule()
		{
			currentWeekSchedule = new WeekSchedule(datePicker.Value);
			weekNum.Text = currentWeekSchedule.Week.ToString();
			lblTimeRange.Text = $"{currentWeekSchedule.Monday.ToShortDateString()} - {currentWeekSchedule.Sunday.ToShortDateString()}";
			ClearAllPanels();
			//get the date and get all the available employees
			DateTime date = datePicker.Value;

			available = scheduleMaker.Repository.GetAvailableByJob(date, CB_GetShiftByJob.Text);

			cbEmps.DataSource = null;
			cbEmps.DataSource = available;
			cbEmps.DisplayMember = "LastName";

			List<Shift> thisWeekShift = new List<Shift>();
			foreach (Shift shift in CurrentWeekShifts)
			{
				if (DateTime.Compare(DateTime.Parse(shift.Date).Date, currentWeekSchedule.Monday) >= 0 && DateTime.Compare(DateTime.Parse(shift.Date).Date, currentWeekSchedule.Sunday) <= 0)
				{
					thisWeekShift.Add(shift);
				}

			}

			foreach (Shift shift in thisWeekShift)
			{
				CustomPanel p = new CustomPanel(shift);
				Employee emp = (Employee)scheduleMaker.Repository.getUserById(shift.EmpId);
				p.Name = emp.FirstName + " " + emp.LastName;
				p.Size = new Size(monD.Width - 10, 50);
				p.Click += OnShiftPanelClick;
				p.Paint += (ss, ee) =>{ ee.Graphics.DrawString(p.Name, Font, Brushes.Black, 5, 5); };
				DrawShiftPanel(p);
			}
		}

		private void OnShiftPanelClick(object sender, EventArgs e)
		{
			CustomPanel p = sender as CustomPanel;
			string name = p.Name;
			string location = "";
			if (p.Shift.Location != null)
			{
				location = locations.Find(x => x.Id == p.Shift.Location).Name;
			}
			else
			{
				location = "No location Found";
			}
			ShiftInfo info = new ShiftInfo(name, location);
			switch (info.ShowDialog())
			{
				case DialogResult.OK:
					if (scheduleMaker.Repository.RemoveShift(p.Shift))
					{
						MessageBox.Show("Shift Removed");
						CurrentWeekShifts = scheduleMaker.Repository.GetShiftByJob(Convert.ToInt32(CB_GetShiftByJob.SelectedValue));
						DrawSchedule();
					}
					else
					{
						MessageBox.Show("Error");
					}
					break;
				default:
					break;
			}
		}

		private void btnAssignShift_Click(object sender, EventArgs e)
		{
			if (selected != null)
			{
				DateTime date = datePicker.Value;
				if (scheduleMaker.Repository.HoursWorkedThisDay(selected.Id, date) >= 8)
				{
					MessageBox.Show("Maximum shift amount reached");
				}
				else if (!scheduleMaker.Repository.ShiftExisted(selected.Id, date, cbbShiftType.SelectedIndex))
				{
					ShiftDTO shift = new ShiftDTO();
					shift.EmpId = selected.Id;
					shift.Date = date.ToString("yyyy-MM-dd");
					shift.Type = cbbShiftType.SelectedIndex;

					if (selected.Jobname.Contains("Caretaker"))
					{
						shift.Location = Int16.Parse(cbbShiftLocation.SelectedValue.ToString());
					}

					if (scheduleMaker.Repository.AddShift(shift))
					{

						MessageBox.Show("Ok");
						CurrentWeekShifts = scheduleMaker.Repository.GetShiftByJob(Convert.ToInt32(CB_GetShiftByJob.SelectedValue));
						DrawSchedule();
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

		private void groupBox2_Enter(object sender, EventArgs e)
		{

		}

		private void cbEmps_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbEmps.SelectedValue == null)
			{
				return;
			}
			selected = (Employee)cbEmps.SelectedValue;
			if (selected.Jobname.ToLower().Contains("caretaker"))
			{
				cbbShiftLocation.Enabled = true;
			}
			else
			{
				cbbShiftLocation.Enabled = false;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Application.Restart();
		}

		private void Btn_GetShiftByJob_Click(object sender, EventArgs e)
		{
			if (Convert.ToInt32(CB_GetShiftByJob.SelectedValue) != -1)
			{
				CurrentWeekShifts = scheduleMaker.Repository.GetShiftByJob(Convert.ToInt32(CB_GetShiftByJob.SelectedValue));
				DrawSchedule();
			}

		}

        private void button2_Click(object sender, EventArgs e)
        {
			scheduleFactory.GenerateSchedule(new WeekSchedule(datePicker.Value), CB_GetShiftByJob.SelectedItem as Job);

        }
		
		

		
    }
}
