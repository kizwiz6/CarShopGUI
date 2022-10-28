using CarClassLibrary;

namespace CarShopGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_create_car_Click(object sender, EventArgs e)
        {
            Car c = new Car(txt_make.Text, txt_model.Text, decimal.Parse(txt_price.Text));
            MessageBox.Show(c.ToString());
        }

        private void btn_addtocart_Click(object sender, EventArgs e)
        {

        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {

        }

        private void lst_inventory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}