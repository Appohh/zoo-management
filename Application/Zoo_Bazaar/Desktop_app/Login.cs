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
    using DataCL;
    
    public partial class Login : Form
    {

        AnimalDataHandler db = new AnimalDataHandler();
        public Login()
        {
            InitializeComponent();
        }

        private void btnTestConn_Click(object sender, EventArgs e)
        {
            db.Connect();
        }
    }
}
