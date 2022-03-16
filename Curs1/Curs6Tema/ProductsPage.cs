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
    public partial class ProductsPage : Form
    {
        private Shop _shop;
        private ListViewItem _categoryItem;
        private ListViewItem _selectedProduct;
        public ProductsPage(ListViewItem categoryItem, Shop shop)
        {
            InitializeComponent();
            this._shop = shop;
            this._categoryItem = categoryItem;
        }


        private void ProductsPage_Load(object sender, EventArgs e)
        {
            categoryLabel.Text = _categoryItem.Text;
        }

        private void ProductsPage_Shown(object sender, EventArgs e)
        {
            //TODO: Add refresh button in toolstrip
            DisplayListItems();
        }

        private void productsList_Click(object sender, EventArgs e)
        {
            _selectedProduct = productsList.SelectedItems[0];
            foreach(Products prod in _shop.Products)
            {
                if(prod.ProductName == _selectedProduct.Text)
                {
                    prodDescriprionTextBox.Text = prod.ProductName + " "
                        + prod.ProductDescription + " "
                        + prod.ProductPrice + " RON";
                }
            }

        }

        public void DisplayListItems()
        {
           
            foreach (Products prod in _shop.Products)
            {
                if (prod.ProductCategory.Name == _categoryItem.Text)
                {
                    productsList.Items.Add(prod.ProductName);
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            productsList.Clear();
            DisplayListItems();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            AddProdcut addProdcut = new AddProdcut(_shop);
            addProdcut.Show();

        }
    }
}
