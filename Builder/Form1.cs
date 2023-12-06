namespace Builder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VehicleBuilder builder = new CarBuilder();
            Shop shop = new Shop();
            shop.ConStruct(new CarBuilder());

            Vehicle ve = builder.GetVehicle();

            MessageBox.Show(ve.VType.ToString());
        }
    }
}
