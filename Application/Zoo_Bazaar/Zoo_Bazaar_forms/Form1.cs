using System;
using System.Drawing;
using System.Windows.Forms;

namespace Zoo_Bazaar_forms
{
	public partial class Form1 : Form
	{
		String stdDetails = "{0, -15}{1, -20}{2, -20}{3, -20}{4, -20}{5, -20}{6, -20}";
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.Size = new Size(1180, 650);
			lbx_test.Items.Add(String.Format(stdDetails, "Profile","FirstName","LastName","Email","Job","Phone","Status"));

		}
	}
}
