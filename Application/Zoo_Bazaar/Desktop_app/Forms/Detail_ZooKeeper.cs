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

namespace Desktop_app.Forms
{
    public partial class Detail_ZooKeeper : Form
    {
        Zookeeper _zookeeper;
        Animal _animal;

        public Detail_ZooKeeper(Zookeeper loggedInUser, Animal anmial)
        {
            _zookeeper = loggedInUser;
            _animal = anmial;
            InitializeComponent();
            PopulateAnimalInfo();
            
        }

        private void Detail_ZooKeeper_Load(object sender, EventArgs e)
        {

        }

        private void Detail_ZooKeeper_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            MessageBox.Show("No changes have been saved.");
        }

        private void PopulateAnimalInfo()
        {
            NameBoxZooKeeper.Text = _animal.Name;
            LocationBoxZooKeeper.Text = _animal.Location;
            NoteBoxZooKeeper.Text = _animal.Notes;
            if(_animal.Sick == 0) { CheckboxSick.Checked = false; } else { CheckboxSick.Checked = true; }
        }

        private void btn_update_animal_Click(object sender, EventArgs e)
        {
            int sick = CheckboxSick.Checked ? 1 : 0;
            if(_zookeeper.Repository.ChangeAnimalSickAndNote(_animal.Id, sick, NoteBoxZooKeeper.Text))
            {
                this.DialogResult = DialogResult.OK;
                _zookeeper.Repository.GetAnimalList();
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Can not save changes");
            }
            
        }
    }
}

