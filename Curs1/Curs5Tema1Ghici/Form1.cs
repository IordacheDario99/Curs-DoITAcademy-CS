using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Curs5Tema1Ghici
{
    public partial class Ghici : Form
    {
        int var_rand;
        Timer timer = new Timer();
        int var_atempts = 0;
        int difficulty = 1;
        int var_guess = 0;

        public Ghici()
        {
            //TODO: add difficulty buttons easy 6/10, med 3/10, hard 1/10;
            InitializeComponent();
            var_rand = new Random().Next(1, 10);
            timer1.Start();

        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            var_atempts++;
            //TODO: Add input validation
            try
            {
                var_guess = Convert.ToInt32(input.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message);
            }
            SetDifficulty(difficulty, var_guess, var_atempts);
        }

        private void SetDifficulty(int difficulty, int guess, int attempts)
        {
            this.difficulty = difficulty;
            int atteptsLeft;
            switch (difficulty)
            {
                case 1:
                    statusLabel.Text = "Easy";
                    statusLabel.ForeColor = Color.YellowGreen;
                    atteptsLeft = 6;

                    if (guess == var_rand && attempts <= atteptsLeft)
                    {
                        statusLabel.Text = $"Congrats! You nailed it from {var_atempts} attempts! ";
                        statusLabel.Text.ToUpper();
                        statusLabel.ForeColor = Color.Green;
                    }
                    else if (attempts > 0)
                    {
                        statusLabel.Text = "Unlucky!!";
                        statusLabel.ForeColor = Color.Red;

                    }

                    break;
                case 2:
                    statusLabel.Text = "Medium";
                    statusLabel.ForeColor = Color.Gold;
                    atteptsLeft = 3;
                    if (guess == var_rand && attempts <= atteptsLeft)
                    {
                        statusLabel.Text = $"Congrats! You nailed it from {var_atempts} attempts! ";
                        statusLabel.Text.ToUpper();
                        statusLabel.ForeColor = Color.Green;
                    }
                    else if (attempts > 0)
                    {
                        statusLabel.Text = "Unlucky!!";
                        statusLabel.ForeColor = Color.Red;

                    }
                    break;
                case 3:
                    atteptsLeft = 1;
                    statusLabel.Text = "Hard";
                    statusLabel.ForeColor = Color.Salmon;

                    if (guess == var_rand && attempts <= atteptsLeft)
                    {
                        statusLabel.Text = $"Congrats! You nailed it from {var_atempts} attempts! ";
                        statusLabel.Text.ToUpper();
                        statusLabel.ForeColor = Color.Green;
                    }
                    else if (attempts > 0)
                    {
                        statusLabel.Text = "Unlucky!!";
                        statusLabel.ForeColor = Color.Red;

                    }
                    break;
            }
        }

        private void timerProgressBar_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timerProgressBar.Value < 100)
            {
                timerProgressBar.Value += 1;
            }
            else
            {
                var_rand = new Random().Next(0, 10);
                timerProgressBar.Value = 0;
            }
        }

        private void easyButton_Click(object sender, EventArgs e)
        {
            var_atempts = 0;
            SetDifficulty(1, 0, var_atempts);
        
        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            var_atempts = 0;
            SetDifficulty(2, 0, 0);
         
        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            var_atempts = 0;
            SetDifficulty(3, 0, 0);
         
        }
    }
}
