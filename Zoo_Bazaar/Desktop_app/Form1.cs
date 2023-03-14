namespace Desktop_app;
using Logic;
using System.Windows.Forms;

public partial class Form1 : Form
{
    String stdDetails = "{0,-15}{1,-20}{2,-20}{3,-20}{4,-20}{5,-20}{6,-20}";
    public Form1()
    {
        InitializeComponent();
        this.Size = new Size(1521, 910);
        lbx_test.Items.Add(String.Format(stdDetails, "Image", "FirstName", "LastName", "Email", "Job", "Phone", "Status"));
        lbx_test2.Items.Add(String.Format(stdDetails, "Image", "Animal", "Habitat", "Age","sex","", "Status"));
    }
}