
using LogicCL;

namespace Desktop_app
{
    public class CustomPanel : Panel
    {
        public Shift Shift { get; set; }

        public CustomPanel(Shift shift) : base()
        {
            Shift = shift;           
            BackColor = Color.Green;                      
        }
    }
}
