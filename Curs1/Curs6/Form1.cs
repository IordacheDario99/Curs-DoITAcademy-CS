using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CategorieDialog popup = new CategorieDialog();
            //popup.Show(); //you can acces the parent form even if you dind't closed the shown dialog
            popup.ShowDialog() // you cannot acces th eparent form until you close the child form (warning sound)
        }
    }
}
