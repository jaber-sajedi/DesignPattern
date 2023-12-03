namespace SingleTon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyClass name = MyClass.GetInstance();
            MyClass name2 = MyClass.GetInstance();

            name.Name = "jaber";
            MessageBox.Show(name2.Name);


        }
    }
}
