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
        }

        private void PopulateAnimalInfo()
        {
            NameBoxZooKeeper.Text = _animal.Name;
            LocationBoxZooKeeper.Text = _animal.Location;
        }
    }
}
