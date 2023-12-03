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
            MyClass connection1 = MyClass.GetInstance();
            MyClass connection2 = MyClass.GetInstance();

            connection1.serverName = "myserver";
            connection1.databaseName = "test";
            connection1.userName = "sa";
            connection1.password = "1112";

           MessageBox.Show(connection1.Connecting_string());
           MessageBox.Show(connection2.Connecting_string());

        }
    }
}
