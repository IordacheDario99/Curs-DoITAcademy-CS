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
    public partial class Form1 : Form
    {
        public Shop _coffeshop;
        public ListViewItem selectedItem;

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            CustomDialog popup = new CustomDialog();
            DialogResult dia = popup.ShowDialog();
            /*returnedValueLabel.Text = "La multi ani!" + dia;*/
            

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _coffeshop = new Shop();
            //_coffeshop.Category.Add();

            Category coffee = new Category("Coffee", "Energy drink");
            Category fresh = new Category("Fresh Juice", "Freshly squized fruit juice");
            Category smoothie = new Category("Smoothie", "Fruit puree with milk or icecream");
            Category sweets = new Category("Sweets", "Something that goes along with the coffee");
            Category sandwiches = new Category("Sandwiches", "For the hungry ones");

            Products v60 = new Products("V60", "A pour over coffee that brings flavour to the next" +
                "level", 16, coffee);
            Products sandwich = new Products("Sanwich cu falafel", "Sandwitch vegetarian cu falafel" +
                "salata, rosii si ceapa caramelizata", 20, sandwiches);
            Products freshPorto = new Products("Fresh de portocale", "Portocale din India proaspat" +
                "stoarse", 15, fresh);

            _coffeshop.Category.Add(coffee);
            _coffeshop.Category.Add(fresh);
            _coffeshop.Category.Add(smoothie);
            _coffeshop.Category.Add(sweets);
            _coffeshop.Category.Add(sandwiches);

            _coffeshop.Products.Add(v60);
            _coffeshop.Products.Add(freshPorto);
            _coffeshop.Products.Add(sandwich);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {

            foreach (Category cat in _coffeshop.Category)
            {
                
                categoryListView.Items.Add(cat.Name);
            }
            /*returnedValueLabel.Text = categoryListView.Items.Count.ToString();*/
        }

        private void categoryListView_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            
        }

        private void categoryListView_Click(object sender, EventArgs e)
        {
            selectedItem = categoryListView.SelectedItems[0];

            foreach(Category cat in _coffeshop.Category)
            {
                if (selectedItem.Text == cat.Name)
                {
                    returnedValueLabel.Text = cat.Description;
                }
            }
        }

        private void categoryListView_DoubleClick(object sender, EventArgs e)
        {
            ProductsPage prodPageForm = new ProductsPage(selectedItem, _coffeshop);
            prodPageForm.Show();
            

        }
    }
}
