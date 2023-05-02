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
    public partial class Schedule_Maker : Form
    {
        //list abscence<>
        //list employee<>
        public Schedule_Maker()
        {
            InitializeComponent();
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
    }
}
