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
using System.Xml.Linq;

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
            PopulateDietCombobox();
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


        public void FilterAnimal(string name, string species, string type)
        {
            var animalList = AnimalManagement.Repository.GetAnimalList();

            var filteredAnimals = animalList
                .OfType<Animal>()
                .Where(a =>
                    (string.IsNullOrEmpty(type) || type.ToLower() == "all" || a.Type.ToLower().Contains(type.ToLower())) &&
                    (string.IsNullOrEmpty(species) || species.ToLower() == "all" || a.Species.ToLower().Contains(species.ToLower())) &&
                    (string.IsNullOrEmpty(name) || a.Name.ToLower().Contains(name.ToLower())));

            foreach (Animal animal in filteredAnimals)
            {
                ListViewItem userInfo = new ListViewItem(new[] { animal.Name, animal.Type, animal.Species, animal.Location });
                userInfo.Tag = animal.Id.ToString();
                lv_Animals.Items.Add(userInfo);
            }
        }

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
            List<Species> species1 = AnimalManagement.GetSpeciesList();
            List<Species> species2 = new List<Species>(species1); // Create a separate list with the same data

            // Add "All" option for species search
            Species allSpecies = new Species { Id = -1, Name = "All" };
            species2.Insert(0, allSpecies);

            // Populate CB_Species1 ComboBox
            CB_Species1.Items.Clear();
            CB_Species1.DataSource = null;
            CB_Species1.DataSource = species1;
            CB_Species1.DisplayMember = "Name";
            CB_Species1.ValueMember = "Id";

            // Populate speciesCB ComboBox
            speciesCB.Items.Clear();
            speciesCB.DataSource = null;
            speciesCB.DataSource = species2;
            speciesCB.DisplayMember = "Name";
            speciesCB.ValueMember = "Id";
        }

        private void PopulateTypesCombobox()
        {
            {
                List<Types> types1 = AnimalManagement.GetTypesList();
                List<Types> types2 = new List<Types>(types1); // Create a separate list with the same data
                List<Types> types3 = new List<Types>(types1); // Create a separate list with the same data

                // Add "All" option for types search
                Types allTypes = new Types { Id = -1, Name = "All" };
                types3.Insert(0, allTypes);

                // Populate CB_TypeBoxAdd ComboBox
                CB_TypeBoxAdd.Items.Clear();
                CB_TypeBoxAdd.DataSource = null;
                CB_TypeBoxAdd.DataSource = types1;
                CB_TypeBoxAdd.DisplayMember = "Name";
                CB_TypeBoxAdd.ValueMember = "Id";

                // Populate CB_Type1 ComboBox
                CB_Type1.Items.Clear();
                CB_Type1.DataSource = null;
                CB_Type1.DataSource = types2;
                CB_Type1.DisplayMember = "Name";
                CB_Type1.ValueMember = "Id";

                // Populate typesCB ComboBox
                typesCB.Items.Clear();
                typesCB.DataSource = null;
                typesCB.DataSource = types3;
                typesCB.DisplayMember = "Name";
                typesCB.ValueMember = "Id";
            }
        }

        private void PopulateDietCombobox()
        {
            List<Diet> diets = AnimalManagement.GetDietList();
            CB_DietAdd.DataSource = null;
            CB_DietAdd.DataSource = diets;
            CB_DietAdd.DisplayMember = "Name";
            CB_DietAdd.ValueMember = "Id";

            CB_Diet1.Items.Clear();
            CB_Diet1.DataSource = diets;
            CB_Diet1.DisplayMember = "Name";
            CB_Diet1.ValueMember = "Id";
        }


        private void CB_SpeciesBoxAdd_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            CB_TypeBoxAdd.Items.Clear();

            // Get the selected species ID from the Species combobox
            int selectedSpeciesId = ((Species)CB_SpeciesBoxAdd.SelectedItem).Id;

            // Get the types for the selected species from the database
            List<Types> typesForSelectedSpecies = AnimalManagement.GetTypesForSpecies(selectedSpeciesId);

            // Add the types to the Types combobox
            foreach (Types type in typesForSelectedSpecies)
            {
                CB_TypeBoxAdd.Items.Add(type);
            }
            if (CB_TypeBoxAdd.Items.Count != 0)
            {
                //CB_Type1.SelectedValie = animal.type;

                CB_TypeBoxAdd.SelectedIndex = 0;
            }
            else { CB_TypeBoxAdd.SelectedIndex = -1; CB_TypeBoxAdd.Text = ""; }
        }


        private void btn_search_Animal_Click_1(object sender, EventArgs e)
        {
            // name = good
            //species and type = not working properly, getting wrong result
            lv_Animals.Items.Clear();
            FilterAnimal(nameTB.Text, speciesCB.Text, typesCB.Text);
        }

        private void BTN_updateAnimal_Click(object sender, EventArgs e)
        {
            string name = TB_name1.Text;
            int location = Convert.ToInt32(CB_Location1.SelectedValue);
            string birthdate = DT_Birthdate.Value.ToString("yyyy-MM-dd");
            var selectedType = (dynamic)CB_Type1.SelectedItem;
            int type = selectedType.Id;
            int diet = Convert.ToInt32(CB_Diet1.SelectedValue);

            int motherId = Convert.ToInt32(CB_Mother1.SelectedIndex);
            int fatherId = Convert.ToInt32(CB_Father1.SelectedIndex);
            string birthplace = TB_BirthPlace1.Text;

            //Condition
            int sick = checkBox1.Checked ? 1 : 0;

            if (AnimalManagement.Repository.ChangeAnimalSickAndNote(selectedAnimalId, sick))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Oops something went wrong, please contact an administrator");
                this.DialogResult = DialogResult.Cancel;
            }

            if (AnimalManagement.Repository.updateAnimalDetails(selectedAnimalId, name, birthdate, birthplace, fatherId, motherId, location, diet, type, sick, "NULL"))
            {
                MessageBox.Show("Success");
                this.DialogResult = DialogResult.OK;
            }
        }

        private void speciesCB_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            typesCB.DataSource = null;

            typesCB.Items.Clear();

            // Get the selected species ID from the Species combobox
            int selectedSpeciesId = ((Species)speciesCB.SelectedItem).Id;

            // Get the types for the selected species from the database
            List<Types> typesForSelectedSpecies = AnimalManagement.GetTypesForSpecies(selectedSpeciesId);

            if (sender == speciesCB)
            {
                Types allTypes = new Types { Id = -1, Name = "All" };
                typesForSelectedSpecies.Insert(0, allTypes);
            }

            // Add the types to the Types combobox
            foreach (Types type in typesForSelectedSpecies)
            {
                typesCB.Items.Add(type);
            }
            if (typesCB.Items.Count != 0)
            {
                //CB_Type1.SelectedValie = animal.type;

                typesCB.SelectedIndex = 0;
            }
            else { typesCB.SelectedIndex = -1; typesCB.Text = ""; }
        }

        private void CB_Species1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_Type1.DataSource = null;
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
                //CB_Type1.SelectedValie = animal.type;

                CB_Type1.SelectedIndex = 0;
            }
            else { CB_Type1.SelectedIndex = -1; CB_Type1.Text = ""; }
        }

        private void Btn_AddAnimal_Click(object sender, EventArgs e)
        {
            var selectedType = (dynamic)CB_TypeBoxAdd.SelectedItem;
            int type = selectedType.Id;

            AnimalDTO dto = new AnimalDTO(
            0,
            TB_NameAdd.Text,
            DT_BirthDateAdd.Value.ToString("yyyy-MM-dd"),
            TB_BirthPlaceAdd.Text,
            null,
            null,
            CB_LocationAdd.SelectedValue.ToString(),
            CB_DietAdd.SelectedValue.ToString(),
            CB_SpeciesBoxAdd.SelectedValue.ToString(),
            type.ToString(),
            0,
            null,
            null,
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
                if (selectedAnimal.Sick == 0) { checkBox1.Checked = false; } else { checkBox1.Checked = true; }
            }
        }

        private void Btn_LogOut_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}



//typeCB.Items.Clear();

////error
//int selectedSpeciesId = ((Species)speciesCB.SelectedItem).Id;

//List<Types> typesForSelectedSpecies = AnimalManagement.GetTypesForSpecies(selectedSpeciesId);

//foreach (Types type in typesForSelectedSpecies)
//{
//    typeCB.Items.Add(type);
//}
//if (typeCB.Items.Count != 0)
//{
//    typeCB.SelectedIndex = 0;
//}
//else
//{
//    typeCB.SelectedIndex = -1; ;
//    typeCB.Text = "";
//}