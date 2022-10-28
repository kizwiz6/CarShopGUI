using CarClassLibrary;

namespace CarShopGUI
{
    public partial class Form1 : Form
    {
        // Global variables for the form:
        Store myStore = new Store(); // creates an object called myStore

        // Binding sources are objects that associate the classes (like store) to the control.
        BindingSource carInventoryBindingSource = new BindingSource();
        BindingSource cartBindingSource = new BindingSource();



        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_create_car_Click(object sender, EventArgs e)
        {
            // Create a new car:
            Car c = new Car(txt_make.Text, txt_model.Text, decimal.Parse(txt_price.Text));

            // Display the details of the new car to the screen (temporarily)
            // MessageBox.Show(c.ToString());

            myStore.CarList.Add(c);

            // Display car list to the list inventory box.
            // Tells the binding source that the car has been added.
            // Set to false as we're not modifying the structure just saying it's a new item
            carInventoryBindingSource.ResetBindings(false);

        }

        private void btn_addtocart_Click(object sender, EventArgs e)
        {
            // Get the selected item from the inventory
            // ALthought cars are stored in the list, we need to explicitly use a cast to tell it will be a car.
            // Else, if a Cast was used incorrectly and used a truck or a different object it would crash the program.
            Car selectedCar = (Car)lst_inventory.SelectedItem;

            // Add that item to the cart
            myStore.ShoppingList.Add(selectedCar);

            // Update the list box control.
            cartBindingSource.ResetBindings(false);

        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {

        }

        private void lst_inventory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // BindingSource variable
            carInventoryBindingSource.DataSource = myStore.CarList;
            cartBindingSource.DataSource = myStore.ShoppingList;

            // will be binded to:
            lst_inventory.DataSource = carInventoryBindingSource;
            lst_inventory.DisplayMember = ToString();

            lst_cart.DataSource = cartBindingSource;
            lst_cart.DisplayMember = ToString();
        }
    }
}