using AbstractFacroty.Implementation;
using AbstractFacroty.Interface;

namespace AbstractFacroty
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SamsungFactory s = Abstract_Facroty.CreaeFacroty(TypePhone.Samsung) as SamsungFactory;
            ISmart smart = s.GetSmart();
            MessageBox.Show(smart.GetName());
        }
    }
}
