
using LogicCL;


namespace Desktop_app
{
    public partial class ShiftInfo : Form
    {
        private Shift _shift;   
        public ShiftInfo(Shift shift)
        {
            InitializeComponent();
            _shift = shift;
        }



        private void ShiftInfo_Load(object sender, EventArgs e)
        {
            label1.Text = _shift.EmpId.ToString();
            label2.Text = _shift.Type.ToString();
            
        }
    }
}
