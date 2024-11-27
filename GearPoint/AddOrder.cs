using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace GearPoint
{
    public partial class AddOrder : Form
    {
        string item_name;
        char gender;
        double quantity;
        string size;
        double price;
        double total;
        Cart cart;
        Main_Menu menu = new Main_Menu();

        public AddOrder(string item_name, char gender, double price)
        {
            this.item_name = item_name;
            this.gender = gender;
            this.price = price;
            InitializeComponent();
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\PC1\\Source\\Repos\\GearPoint\\GearPoint\\Database.mdf;Integrated Security=True");
        }



        private void AddOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Cart' table. You can move, or remove it, as needed.
            this.cartTableAdapter.Fill(this.databaseDataSet.Cart);
            string[] shirtSizes = { "XS", "S", "M", "L", "XL", "XXL", "XXXL" };

            for (int i = 0; i < shirtSizes.Length; i++)
            {
                SizesComboBox.Items.Add(shirtSizes[i]);
            }

            ItemNameLbl.Text = item_name.ToString();
            GenderLbl.Text = gender.ToString();

        }

        private void OrderImageBox_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void AddToCartBtn_Click(object sender, EventArgs e)
        {
            string Item = item_name;
            string Gender = gender.ToString();
            string Size = SizesComboBox.Text;
            string Quantity = quantity.ToString();
            string Total = total.ToString();

            cart = new Cart(Item, Gender, Size, Quantity, Total);
            MessageBox.Show("Item Added to cart");
            cart.Show();
            menu.Show();
            this.Close();
        }

        private void QuantityBox_ValueChanged(object sender, EventArgs e)
        {
            quantity = (double)QuantityBox.Value;
            total = quantity * price;

            PriceOutputLbl.Text = total.ToString("F2");
        }

        private void SizesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            quantity = (double)QuantityBox.Value;
            total = quantity * price;

            PriceOutputLbl.Text = total.ToString("F2");
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            //Bagoha ni charl
            menu.Show();
            this.Close();
        }

        private void cartBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cartBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
