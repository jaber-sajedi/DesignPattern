using AbstractFacroty_ButtonExample.Factory;
using AbstractFacroty_ButtonExample.implementation;
using AbstractFacroty_ButtonExample.@interface;

namespace AbstractFacroty_ButtonExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IGuiFactory IGF = AbstracFactory.CreateFactory(ButtonType.win);
            IButton button = IGF.createButton();
            MessageBox.Show(button.GetName());


           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OSXFactory OSXF = (OSXFactory)AbstracFactory.CreateFactory(ButtonType.OSX);
            OSXButton oSXBtn = (OSXButton)OSXF.createButton();
            MessageBox.Show(oSXBtn.GetName());
        }
    }
}
