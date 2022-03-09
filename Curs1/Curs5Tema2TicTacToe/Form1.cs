using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs5Tema2TicTacToe
{
    public partial class TicTacToe : Form
    {
        bool isXTurn = true;
        List<Button> buttonsList = new List<Button>();
        public TicTacToe()
        {
            InitializeComponent();
            buttonsList.Add(button1);
            buttonsList.Add(button2);
            buttonsList.Add(button3);
            buttonsList.Add(button4);
            buttonsList.Add(button5);
            buttonsList.Add(button6);
            buttonsList.Add(button7);
            buttonsList.Add(button8);
            buttonsList.Add(button9);
            turnLabel.Text = "X's turn";

        }

        private void TicTacToe_Load(object sender, EventArgs e)
        {
            /*TODO: 
                1.Implement turn logic
                2.Populate button based on tunr logic (X/O)
                3.Add winning logic (rows, columns, diagonals)
             
             */
        }


        public void WinningScenarios()
        {
            //Rows
            if(button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "")
            {
                //we have a winner
                turnLabel.Text = $"The winner is {Winner()}";

            }
            else if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "")
            {
                //we have a winner
                turnLabel.Text = $"The winner is {Winner()}";

            }
            else if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "")
            {
                //we have a winner
                turnLabel.Text = $"The winner is {Winner()}";
            }

            //Columns
            if(button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "")
            {
                turnLabel.Text = $"The winner is {Winner()}";
            }
            else if(button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "")
            {
                turnLabel.Text = $"The winner is {Winner()}";
            }
            else if(button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "")
            {
                turnLabel.Text = $"The winner is {Winner()}";
            }

            //Diagonals
            if(button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "")
            {
                turnLabel.Text = $"The winner is {Winner()}";
            }
            else if(button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != "")
            {
                turnLabel.Text = $"The winner is {Winner()}";
            }
        }
        public string Winner()
        {
            if (isXTurn)
            {
                for(int i = 0; i <= buttonsList.Count - 1; i++)
                {
                    buttonsList[i].Enabled = false;
                }
                return "O";
            }
            else
            {
                for (int i = 0; i <= buttonsList.Count - 1; i++)
                {
                    buttonsList[i].Enabled = false;
                }
                return "X";
            }
        }

        public void Turn(Button button)
        {
            if (button.Text == "")
            {
                if (isXTurn)
                {
                    button.Text = "X";
                    isXTurn = false;
                    turnLabel.Text = "O's turn";
                }
                else
                {
                    button.Text = "O";
                    isXTurn = true;
                    turnLabel.Text = "X's turn";

                }
            }
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            Turn(button1);
            WinningScenarios();
        }


        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            Turn(button2);
            WinningScenarios();
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            Turn(button3);
            WinningScenarios();
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            Turn(button4);
            WinningScenarios();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Turn(button5);
            WinningScenarios();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Turn(button6);
            WinningScenarios();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Turn(button7);
            WinningScenarios();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Turn(button8);
            WinningScenarios();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Turn(button9);
            WinningScenarios();
        }

        
    }
}
