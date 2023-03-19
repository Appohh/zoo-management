﻿using Logic;
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
        //String stdDetails = "{0,-15}{1,-20}{2,-20}{3,-20}{4,-20}{5,-20}{6,-20}";
        public Zoo_Keeper()
        {
            AnimalManagement animalManagement = new AnimalManagement();
            InitializeComponent();
            this.Size = new Size(1521, 910);
            lbx_animals.Items.Add(("Image", "Name", "Species", "Location", "Health", "History"));
            lbx_animals.Items.Add(("anus", "ridho", "skunk", "bin", "worst", "bad"));
            foreach (var animal in animalManagement.getAnimalList())
            {
                lbx_animals.Items.Add((animal.Sickness, animal.Name, animal.Type, animal.Species, animal.LocationId, animal.DietId, animal.Birthdate));
            }



        }
    }
}
