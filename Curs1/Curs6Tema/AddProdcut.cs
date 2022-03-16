using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs6Tema
{
    public partial class AddProdcut : Form
    {
        private Shop _shop;
        public AddProdcut(Shop shop)
        {
            this._shop = shop;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Category cat = new Category(categoryComboBox.Text, "");
            Products prod = new Products(nameTextBox.Text, descriptionTextBox.Text,
                float.Parse(priceTextBox3.Text), cat);
            _shop.Products.Add(prod);
            this.Close();
        }

        private void AddProdcut_Shown(object sender, EventArgs e)
        {
            categoryComboBox.DisplayMember = "Coffee";
            categoryComboBox.Items.Add("Coffee");
            categoryComboBox.Items.Add("Fresh Juice");
            categoryComboBox.Items.Add("Smoothie");
            categoryComboBox.Items.Add("Sweets");
            categoryComboBox.Items.Add("Sandwiches");

        }
    }
}
