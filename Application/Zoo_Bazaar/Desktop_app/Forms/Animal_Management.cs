using Logic;
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
	public partial class Animal_Management : Form
	{
		private AnimalManagement AnimalManagement;
        private int selectedAnimalId;
        public Animal_Management(User loggedInUser)
		{
            AnimalManagement = (AnimalManagement)loggedInUser;
            AnimalManagement.MakeActive();
            InitializeComponent();
            this.Size = new Size(1521, 910);
        }

        private void refreshAnimalList()
        {
            lv_Animals.Items.Clear();
            foreach (Animal animal in AnimalManagement.Repository.GetAnimalList())
            {
                var animalInfo = new ListViewItem(new[] { animal.Name, animal.Type, animal.Species, animal.Location });
                animalInfo.Tag = animal.Id.ToString();
                lv_Animals.Items.Add(animalInfo);
            }
        }

        public void FilterAnimal(string search)
        {
            lv_Animals.Items.Clear();
            foreach (Animal animal in AnimalManagement.Repository.GetAnimalList().OfType<Animal>().Where(animal => !animal.Species.ToLower().Contains(search) && (animal.Name).ToLower().Contains(search.ToLower()) || animal.Type.ToLower().Contains(search.ToLower())).ToList())
            {
                string dateFriendly = DateTime.Parse(animal.Birthdate).ToString("dd-MMMM-yyyy");
                ListViewItem animalInfo = new ListViewItem(new[] { animal.Name, animal.Birthdate, animal.Type, animal.Species, animal.Location });
                animalInfo.Tag = animal.Id.ToString();
                lv_Animals.Items.Add(animalInfo);
            }
        }

        private void btn_search_Animal_Click(object sender, EventArgs e)
        {
            FilterAnimal(TB_SearchAnimal.Text);
        }
    }
}
