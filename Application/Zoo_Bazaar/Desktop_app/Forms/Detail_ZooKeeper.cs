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
        User userLoggedIn;
        public Detail_ZooKeeper(User loggedInUser)
        {
            InitializeComponent();
            userLoggedIn = loggedInUser;
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
    }
}
