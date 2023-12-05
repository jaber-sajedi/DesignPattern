using Facroty.Implementation;
using Rectangle = Facroty.Implementation.Rectangle;

namespace Facroty
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Circle c = ShapFacroty.CreatShape(ShapType.Circle) as Circle;
            c.Diameter = 20;
            MessageBox.Show(c.Draw());


            Rectangle r = ShapFacroty.CreatShape(ShapType.Rectangle) as Rectangle;
           r.Width = 20;
           r.Length = 30;
            MessageBox.Show(r.Draw());


        }
    }
}
