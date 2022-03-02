using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs5WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butonPrincipal_Click(object sender, EventArgs e)
        {
            string nume = nameTextBox.Text;

            if(nume == "")
            {
                nameValidationLabel.Text = "Completeaza numele";
            } 
            else
            {
                nameValidationLabel.Text = "";
                string mesaj = "";
                if (countryComboBox.SelectedIndex == 0)
                {
                    mesaj = "Bine ai venit ";


                    if (elevRadioBox.Checked)
                    {
                       

                        mesaj += "elevule ";
                    } 
                    else if(studentRadioBox.Checked)
                    {
                        mesaj += "studentule ";
                    } 
                    else
                    {
                        mesaj += "angajatule ";
                    }

                    if(smokerCheckBox.Checked)
                    {
                        mesaj += "fumator ";
                    }

                    mesaj += nume;

                    MessageBox.Show(mesaj);
                } 
                else
                {
                    MessageBox.Show("Welcome " + nume);
                }
            }

            
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Felicitari - dublu click");
        }

        private void elevRadioBox_CheckedChanged(object sender, EventArgs e)
        {
            if(elevRadioBox.Checked)
            {
                smokerCheckBox.Checked = false;
                smokerCheckBox.Enabled = false;
            } else
            {
                smokerCheckBox.Enabled = true;
            }
        }
    }
}
