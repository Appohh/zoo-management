
using LogicCL;


namespace Desktop_app
{
    public partial class ShiftInfo : Form
    {

        public ShiftInfo(string name, string location)
        {
            InitializeComponent();
            label1.Text = name;
            label2.Text = location;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
