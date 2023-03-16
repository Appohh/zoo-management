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
    public partial class Zoo_Keeper : Form
    {
        String stdDetails = "{0,-15}{1,-20}{2,-20}{3,-20}{4,-20}{5,-20}{6,-20}";
        public Zoo_Keeper()
        {
            InitializeComponent();
            this.Size = new Size(1521, 910);
            lbx_animals.Items.Add(String.Format(stdDetails, "Image", "Name", "Species", "Location", "Health", "History"));
        }
    }
}
