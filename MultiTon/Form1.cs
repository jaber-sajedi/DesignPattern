namespace MultiTon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Shape shape1 = Shape.GetInstance("Shape1", "Blue", "Circle");
            MessageBox.Show(shape1.Draw());

            Shape shape2 = Shape.GetInstance("Shape2", "Red", "Square");
            MessageBox.Show(shape2.Draw()); shape2.Draw();

            Shape shape3 = Shape.GetInstance("Shape3", "Green", "Triangle");
            MessageBox.Show(shape2.Draw());




        }
    }
}
