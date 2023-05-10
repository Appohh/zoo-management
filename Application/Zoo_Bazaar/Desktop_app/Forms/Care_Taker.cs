using Desktop_app.Forms;
using LogicCL.AnimalMap;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Desktop_app
{
    public partial class Care_Taker : Form
    {
        //String stdDetails = "{0,-15}{1,-20}{2,-20}{3,-20}{4,-20}{5,-20}{6,-20}";
        private Zookeeper zookeeper;

        private int selectedAnimalId;

        public Care_Taker(User loggedInUser)
        {
            zookeeper = (Zookeeper)loggedInUser;
            zookeeper.MakeActive();
            InitializeComponent();
            this.Size = new Size(1521, 910);
            welcome_txt.Text = $"Welcome {loggedInUser.FirstName} {loggedInUser.LastName}";

            PopulateSpeciesCombobox();
            PopulateTypeCombobox();
        }

        private void refreshAnimalList()
        {
            lv_Animals.Items.Clear();
            FilterAnimal(nameTB.Text, speciesCB.Text, typesCB.Text);
            //foreach (Animal animal in zookeeper.Repository.GetAnimalList())
            //{
            //    var animalInfo = new ListViewItem(new[] { animal.Name, animal.Birthdate, animal.Type, animal.Species, animal.Location, animal.BirthPlace });
            //    animalInfo.Tag = animal.Id.ToString();
            //    lv_Animals.Items.Add(animalInfo);
            //}
        }

        public void FilterAnimal(string name, string species, string type)
        {
            //list
            var animalList = zookeeper.Repository.GetAnimalList();

            var filteredAnimals = animalList
              .OfType<Animal>()
              .Where(a =>
                  (string.IsNullOrEmpty(type) || type.ToLower() == "all" || a.Type.ToLower().Contains(type.ToLower())) &&
                  (string.IsNullOrEmpty(species) || species.ToLower() == "all" || a.Species.ToLower().Contains(species.ToLower())) &&
                  (string.IsNullOrEmpty(name) || a.Name.ToLower().Contains(name.ToLower())));

            foreach (Animal animal in filteredAnimals)
            {
                string dateFriendly = DateTime.Parse(animal.Birthdate).ToString("dd-MMMM-yyyy");
                ListViewItem animalinfo = new ListViewItem(new[] { animal.Name, dateFriendly, animal.Type, animal.Location, animal.Species });
                animalinfo.Tag = animal.Id.ToString();
                lv_Animals.Items.Add(animalinfo);
            }
        }

        //cb ----------------------------------------------------
        public void PopulateTypeCombobox()
        {
            List<Types> types = zookeeper.GetTypesList();
            Types allTypes = new Types { Id = -1, Name = "All" };
            types.Insert(0, allTypes);
            // Populate typesCB ComboBox
            typesCB.Items.Clear();
            typesCB.DataSource = null;
            typesCB.DataSource = types;
            typesCB.DisplayMember = "Name";
            typesCB.ValueMember = "Id";
        }

        public void PopulateSpeciesCombobox()
        {
            List<Species> species = zookeeper.GetSpeciesList();

            Species allSpecies = new Species { Id = -1, Name = "All" };
            species.Insert(0, allSpecies);
            // Populate speciesCB ComboBox
            speciesCB.Items.Clear();
            speciesCB.DataSource = null;
            speciesCB.DataSource = species;
            speciesCB.DisplayMember = "Name";
            speciesCB.ValueMember = "Id";
        }

        
        private void btn_search_Animal_Click(object sender, EventArgs e)
        {
            lv_Animals.Items.Clear();
            FilterAnimal(nameTB.Text, speciesCB.Text, typesCB.Text);
        }

        private void speciesCB_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            typesCB.DataSource = null;

            typesCB.Items.Clear();

            // Get the selected species ID from the Species combobox
            int selectedSpeciesId = ((Species)speciesCB.SelectedItem).Id;

            // Get the types for the selected species from the database
            List<Types> typesForSelectedSpecies = zookeeper.GetTypesForSpecies(selectedSpeciesId);

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

        private void lv_Animals_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (lv_Animals.SelectedItems.Count > 0)
            {
                List<Animal> animalList = zookeeper.Repository.GetAnimalList().OfType<Animal>().ToList();

                Animal selectedAnimal = animalList.Find(animal => animal.Id == Convert.ToInt32(lv_Animals.SelectedItems[0].Tag));

                //Animal
                selectedAnimalId = Convert.ToInt32(lv_Animals.SelectedItems[0].Tag);
                TB_Name.Text = selectedAnimal.Name;
                TB_BirthDate.Text = DateTime.Parse(selectedAnimal.Birthdate).ToString("dd/MM/yyyy");
                TB_Father.Text = selectedAnimal.FatherId;
                TB_Mother.Text = selectedAnimal.Mother;
                TB_BirthPlace.Text = selectedAnimal.BirthPlace;
                TB_Gender.Text = selectedAnimal.gender;
                //Category
                TB_Species.Text = selectedAnimal.Species;
                TB_Location.Text = selectedAnimal.Location;
                TB_Diet.Text = selectedAnimal.Diet;
                TB_Type.Text = selectedAnimal.Type;

                //Condition
                if (selectedAnimal.Sick == 0)
                {
                    CHB_Sick.Checked = false;
                }
                else if (selectedAnimal.Sick == 1)
                {
                    CHB_Sick.Checked = true;
                }

                TB_Notes.Text = selectedAnimal.Notes;
            }
        }

        private void btn_ViewDetails_Click_1(object sender, EventArgs e)
        {
            //editable variables
            int Sick = CHB_Sick.Checked ? 1 : 0;
            string Notes = TB_Notes.Text;

            //uneditable variables
            var name = TB_Name.Text;

            List<string> errors = new List<string>();

            // Validate input
            if (string.IsNullOrEmpty(Notes))
            {
                errors.Add("Please enter notes.");
            }

            // Check for errors
            if (errors.Count > 0)
            {
                MessageBox.Show(string.Join("\n", errors));
                return;
            }

            if (zookeeper.Repository.ChangeAnimalSickAndNote(selectedAnimalId, Sick, Notes))
            {
                MessageBox.Show($"Success, you have made an update for the animal {name}");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Oops something went wrong, please contact an administrator");
                this.DialogResult = DialogResult.Cancel;
            }
            refreshAnimalList();
        }
    }
}