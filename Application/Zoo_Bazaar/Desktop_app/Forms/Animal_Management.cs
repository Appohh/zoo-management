using Logic;
using LogicCL.Users;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataCL.DTOs;
using LogicCL;

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
            PopulateLocationCombobox();
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

        private void lv_Animals_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_Animals.SelectedItems.Count > 0)
            {
                List<Animal> animalList = AnimalManagement.Repository.GetAnimalList().OfType<Animal>().ToList();

                Animal selectedAnimal = animalList.Find(animal => animal.Id == Convert.ToInt32(lv_Animals.SelectedItems[0].Tag));



                //Animal
                selectedAnimalId = Convert.ToInt32(lv_Animals.SelectedItems[0].Tag);
                TB_Name.Text = selectedAnimal.Name;
                CB_BirthDateBoxHR.Value = DateTime.Parse(selectedAnimal.Birthdate);
                TB_Father.Text = selectedAnimal.FatherId.ToString();
                TB_Mother.Text = selectedAnimal.Mother.ToString();
                TB_BirthPlace.Text = selectedAnimal.BirthPlace;

                //Category
                TB_Species.Text = selectedAnimal.Species;
                TB_Location.Text = selectedAnimal.Location;
                TB_Diet.Text = selectedAnimal.Diet;
                TB_Type.Text = selectedAnimal.Type;

                //Condition
                if (selectedAnimal.Sick == 0) { CHB_Sick.Checked = false; } else { CHB_Sick.Checked = true; }



            }
        }

        private void btn_ViewDetails_Click(object sender, EventArgs e)
        {
            string name = TB_Name.Text;
            string location = TB_Location.Text;
            string birthdate = CB_BirthDateBoxHR.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string type = TB_Type.Text;
            string species = TB_Species.Text;
            string diet = TB_Diet.Text;

            int motherId = Convert.ToInt32(TB_Mother.Text);
            int fatherId = Convert.ToInt32(TB_Father.Text);
            string birthplace = TB_BirthPlace.Text;


            //Condition
            int sick = CHB_Sick.Checked ? 1 : 0;
            string deathdate = CB_DeathDateBox.Value.ToString("yyyy-MM-dd HH:mm:ss.ffff");

            if (AnimalManagement.Repository.ChangeAnimalSickAndNote(selectedAnimalId, sick))
            {
                MessageBox.Show("Success");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Oops something went wrong, please contact an administrator");
                this.DialogResult = DialogResult.Cancel;
            }

            if (AnimalManagement.Repository.updateAnimalDetails(selectedAnimalId, name, birthdate, birthplace, fatherId, motherId, location, diet, species, type, sick, deathdate))
            {
                MessageBox.Show("Success");
                this.DialogResult = DialogResult.OK;
            }
        }

        private void Btn_AddAnimal_Click(object sender, EventArgs e)
        {
            int sick = CHB_Sick.Checked ? 1 : 0;
            if (AnimalManagement.Repository.ChangeAnimalSickAndNote(selectedAnimalId, sick))
            {
                MessageBox.Show("Success");
                this.DialogResult = DialogResult.OK;
            }

            AnimalDTO dto = new AnimalDTO(
            0,
            TB_NameAdd.Text,
            DT_BirthDateAdd.Value.ToString("yyyy-MM-dd HH:mm:ss.fff"),
            TB_BirthPlace.Text,
            Convert.ToInt32(CB_FatherAdd.Text),
            Convert.ToInt32(CB_MotherAdd.Text),
            CB_LocationAdd.Text,
            CB_DietAdd.Text,
            CB_SpeciesBoxAdd.Text,
            CB_TypeBoxAdd.Text,
            sick,
            null,
            DT_DeathAdd.Value.ToString("yyyy-MM-dd HH:mm:ss.fff"),
            null
            ); ;
            //int id, string name, string dob, string birthPlace, int? fatherId, int? motherId, string location, string diet, string species, string? type, int sick, string? notes, string? deathdate, string imageUrl
            if (AnimalManagement.RegisterNewAnimal(dto))
            {
                MessageBox.Show("Successful");
            }
            else
            {
                MessageBox.Show("Unsuccessful");
            }
        }

        private void PopulateLocationCombobox()
        {
            List<Animal> location = AnimalManagement.Repository.GetAnimalList().OfType<Animal>().ToList(); ;
            CB_LocationAdd.Items.Clear();
            CB_LocationAdd.DataSource = null;
            CB_LocationAdd.DataSource = location;
            CB_LocationAdd.DisplayMember = "location";
            CB_LocationAdd.ValueMember = "";
        }
    }
}
