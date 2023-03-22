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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Desktop_app
{
    public partial class Zoo_Keeper : Form
    {
        //String stdDetails = "{0,-15}{1,-20}{2,-20}{3,-20}{4,-20}{5,-20}{6,-20}";
        private Zookeeper zookeeper;
        public Zoo_Keeper(User loggedInUser)
        {
            zookeeper = (Zookeeper)loggedInUser;
            zookeeper.MakeActive();
            InitializeComponent();
            this.Size = new Size(1521, 910);
            var item2 = new ListViewItem(new[] { "sa", "saasa", "safas" });
            lv_Animals.Items.Add(item2);
            foreach (Animal animal in zookeeper.Repository.GetAnimalList())
            {
                //lbx_animals.Items.Add((animal.Sick, animal.Name, animal.Type, animal.Species, animal.LocationId, animal.DietId, animal.BirthPlace));
            }



        }

        private void lv_Animals_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (lv_Animals.SelectedItems.Count > 0)
            {
                AnimalNameLabel.Text = lv_Animals.SelectedItems[0].SubItems[0].Text;
            }
            else
            {
                AnimalNameLabel.Text = "";
            }
            
        }

        private void btn_details_zookeeper_Click(object sender, EventArgs e)
        {
            this.Hide();
            Detail_ZooKeeper detail_ZooKeeper = new Detail_ZooKeeper(zookeeper);
            detail_ZooKeeper.ShowDialog();
            
        }

        private void btn_add_animal_HR_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Animal_Form add_Animal_Form = new Add_Animal_Form();
            add_Animal_Form.ShowDialog();
        }
    }
}
