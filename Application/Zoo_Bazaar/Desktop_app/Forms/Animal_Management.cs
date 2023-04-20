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
using LogicCL.AnimalMap;

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
            PopulateSpeciesCombobox();
            PopulateTypesCombobox();
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

        private void Btn_AddAnimal_Click(object sender, EventArgs e)
        {
            int sick = CHB_Sick.Checked ? 1 : 0;
            if (AnimalManagement.Repository.ChangeAnimalSickAndNote(selectedAnimalId, sick))
            {
                MessageBox.Show("Success");
                this.DialogResult = DialogResult.OK;
            }
        }

        //    AnimalDTO dto = new AnimalDTO(
        //    0,
        //    TB_NameAdd.Text,
        //    DT_BirthDateAdd.Value.ToString("yyyy-MM-dd HH:mm:ss.fff"),
        //    TB_BirthPlace.Text,
        //    Convert.ToInt32(CB_FatherAdd.Text),
        //    Convert.ToInt32(CB_MotherAdd.Text),
        //    CB_LocationAdd.Text,
        //    CB_DietAdd.Text,
        //    CB_SpeciesBoxAdd.Text,
        //    CB_TypeBoxAdd.Text,
        //    sick,
        //    null,
        //    DT_DeathAdd.Value.ToString("yyyy-MM-dd HH:mm:ss.fff"),
        //    null
        //    ); ;
        //    //int id, string name, string dob, string birthPlace, int? fatherId, int? motherId, string location, string diet, string species, string? type, int sick, string? notes, string? deathdate, string imageUrl
        //    if (AnimalManagement.RegisterNewAnimal(dto))
        //    {
        //        MessageBox.Show("Successful");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Unsuccessful");
        //    }
        //}

        private void PopulateLocationCombobox()
        {
            List<Location> location = AnimalManagement.GetLocationList();
            //Populate add Location Comboboxes


            CB_LocationAdd.Items.Clear();
            CB_LocationAdd.DataSource = null;
            CB_LocationAdd.DataSource = location;
            CB_LocationAdd.DisplayMember = "Name";
            CB_LocationAdd.ValueMember = "Id";
            //Populate update Location Comboboxes
            CB_Location1.Items.Clear();
            CB_Location1.DataSource = null;
            CB_Location1.DataSource = location;
            CB_Location1.DisplayMember = "Name";
            CB_Location1.ValueMember = "Id";
        }

        private void PopulateSpeciesCombobox()
        {
            List<Species> species = AnimalManagement.GetSpeciesList();
            //Populate add Location Comboboxes
            CB_SpeciesBoxAdd.Items.Clear();
            CB_SpeciesBoxAdd.DataSource = null;
            CB_SpeciesBoxAdd.DataSource = species;
            CB_SpeciesBoxAdd.DisplayMember = "Name";
            CB_SpeciesBoxAdd.ValueMember = "Id";
            //Populate update Location Comboboxes
            CB_Species1.Items.Clear();
            CB_Species1.DataSource = null;
            CB_Species1.DataSource = species;
            CB_Species1.DisplayMember = "Name";
            CB_Species1.ValueMember = "Id";
        }

        private void PopulateTypesCombobox()
        {
            List<Types> types = AnimalManagement.GetTypesList();
            //Populate add Location Comboboxes
            CB_TypeBoxAdd.Items.Clear();
            CB_TypeBoxAdd.DataSource = null;
            CB_TypeBoxAdd.DataSource = types;
            CB_TypeBoxAdd.DisplayMember = "Name";
            CB_TypeBoxAdd.ValueMember = "Id";
            
            //Populate update Location Comboboxes
            CB_Type1.Items.Clear();
            //CB_Type1.DataSource = null;
            //CB_Type1.DataSource = types;
            CB_Type1.DisplayMember = "Name";
            CB_Type1.ValueMember = "Id";
        }

        private void BTN_updateAnimal_Click(object sender, EventArgs e)
        {
            string name = TB_name1.Text;
            int location = Convert.ToInt32(CB_Location1.SelectedValue);
            string birthdate = DT_Birthdate.Value.ToString("yyyy-MM-dd");
            int type = CB_Type1.SelectedIndex;
            int species = CB_Species1.SelectedIndex;
            int diet = CB_Diet1.SelectedIndex;

            int motherId = Convert.ToInt32(CB_Mother1.SelectedIndex);
            int fatherId = Convert.ToInt32(CB_Father1.SelectedIndex.ToString());
            string birthplace = TB_BirthPlace.Text;


            //Condition
            int sick = CHB_Sick.Checked ? 1 : 0;
            string deathdate = CB_DeathDateBox.Value.ToString("yyyy-MM-dd HH:mm:ss.ffff");

            if (AnimalManagement.Repository.ChangeAnimalSickAndNote(selectedAnimalId, sick))
            {
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

        private void btn_search_Animal_Click_1(object sender, EventArgs e)
        {
            FilterAnimal(TB_SearchAnimal.Text);
        }

        private void lv_Animals_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lv_Animals.SelectedItems.Count > 0)
            {
                List<Animal> animalList = AnimalManagement.Repository.GetAnimalList().OfType<Animal>().ToList();

                Animal selectedAnimal = animalList.Find(animal => animal.Id == Convert.ToInt32(lv_Animals.SelectedItems[0].Tag));



                //Animal
                selectedAnimalId = Convert.ToInt32(lv_Animals.SelectedItems[0].Tag);
                TB_name1.Text = selectedAnimal.Name;
                DT_Birthdate.Value = DateTime.Parse(selectedAnimal.Birthdate);
                CB_Father1.Text = selectedAnimal.FatherId.ToString();
                CB_Mother1.Text = selectedAnimal.Mother.ToString();
                TB_BirthPlace1.Text = selectedAnimal.BirthPlace;

                //Category
                CB_Species1.Text = selectedAnimal.Species;
                CB_Location1.Text = selectedAnimal.Location;
                CB_Diet1.Text = selectedAnimal.Diet;
                CB_Type1.Text = selectedAnimal.Type;

                //Condition
                if (selectedAnimal.Sick == 0) { CHB_Sick.Checked = false; } else { CHB_Sick.Checked = true; }



            }
        }

        private void CB_Species1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get animal object

            

            CB_Type1.Items.Clear();


            // Get the selected species ID from the Species combobox
            int selectedSpeciesId = ((Species)CB_Species1.SelectedItem).Id;

            // Get the types for the selected species from the database
            List<Types> typesForSelectedSpecies = AnimalManagement.GetTypesForSpecies(selectedSpeciesId);

            // Add the types to the Types combobox
            foreach (Types type in typesForSelectedSpecies)
            {
                CB_Type1.Items.Add(type);
            }
            if (CB_Type1.Items.Count != 0)
            {
                //                CB_Type1.SelectedValie = animal.type;

                CB_Type1.SelectedIndex = 0;
            }else { CB_Type1.SelectedIndex = -1; CB_Type1.Text = ""; }
        }

        private void CB_Type1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
