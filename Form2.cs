using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int i = 0;
        



        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(button1.Text))
            {
                button1.Text = XorO();
                i++;
                if (CheckWin())
                {
                    MessageBox.Show($"Spieler {button1.Text} hat gewonnen!");
                    btnRestart_Click(null, null);
                }
                else if (i == 9)
                {
                    MessageBox.Show("Unentschieden!");
                    btnRestart_Click(null, null);
                }
            }
            label1.Text = "Player: " + PlayerTurn();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(button2.Text))
            {
                button2.Text = XorO();
                i++;
                if (CheckWin())
                {
                    MessageBox.Show($"Spieler {button2.Text} hat gewonnen!");
                    btnRestart_Click(null, null);
                }
                else if (i == 9)
                {
                    MessageBox.Show("Unentschieden!");
                    btnRestart_Click(null, null);
                }
            }
            label1.Text = "Player: " + PlayerTurn();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(button3.Text))
            {
                button3.Text = XorO();
                i++;
                if (CheckWin())
                {
                    MessageBox.Show($"Spieler {button3.Text} hat gewonnen!");
                    btnRestart_Click(null, null);
                }
                else if (i == 9)
                {
                    MessageBox.Show("Unentschieden!");
                    btnRestart_Click(null, null);
                }
            }
            label1.Text = "Player: " + PlayerTurn();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(button4.Text))
            {
                button4.Text = XorO();
                i++;
                if (CheckWin())
                {
                    MessageBox.Show($"Spieler {button4.Text} hat gewonnen!");
                    btnRestart_Click(null, null);
                }
                else if (i == 9)
                {
                    MessageBox.Show("Unentschieden!");
                    btnRestart_Click(null, null);
                }
            }
            label1.Text = "Player: " + PlayerTurn();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(button5.Text))
            {
                button5.Text = XorO();
                i++;
                if (CheckWin())
                {
                    MessageBox.Show($"Spieler {button5.Text} hat gewonnen!");
                    btnRestart_Click(null, null);
                }
                else if (i == 9)
                {
                    MessageBox.Show("Unentschieden!");
                    btnRestart_Click(null, null);
                }
            }
            label1.Text = "Player: " + PlayerTurn();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(button6.Text))
            {
                button6.Text = XorO();
                i++;
                if (CheckWin())
                {
                    MessageBox.Show($"Spieler {button6.Text} hat gewonnen!");
                    btnRestart_Click(null, null);
                }
                else if (i == 9)
                {
                    MessageBox.Show("Unentschieden!");
                    btnRestart_Click(null, null);
                }
            }
            label1.Text = "Player: " + PlayerTurn();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(button7.Text))
            {
                button7.Text = XorO();
                i++;
                if (CheckWin())
                {
                    MessageBox.Show($"Spieler {button7.Text} hat gewonnen!");
                    btnRestart_Click(null, null);
                }
                else if (i == 9)
                {
                    MessageBox.Show("Unentschieden!");
                    btnRestart_Click(null, null);
                }
            }
            label1.Text = "Player: " + PlayerTurn();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(button8.Text))
            {
                button8.Text = XorO();
                i++;
                if (CheckWin())
                {
                    MessageBox.Show($"Spieler {button8.Text} hat gewonnen!");
                    btnRestart_Click(null, null);
                }
                else if (i == 9)
                {
                    MessageBox.Show("Unentschieden!");
                    btnRestart_Click(null, null);
                }
            }
            label1.Text = "Player: " + PlayerTurn();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(button9.Text))
            {
                button9.Text = XorO();
                i++;
                if (CheckWin())
                {
                    MessageBox.Show($"Spieler {button9.Text} hat gewonnen!");
                    btnRestart_Click(null, null);
                }
                else if (i == 9)
                {
                    MessageBox.Show("Unentschieden!");
                    btnRestart_Click(null, null);
                }
            }
            label1.Text = "Player: " + PlayerTurn();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            i = 0;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }
        private string XorO()
        {
            string xOrO;
            if (i % 2 == 0)
            {
                xOrO = "X";
            }
            else
            {
                xOrO = "O";
            }
            return xOrO;
        }
        private bool CheckWin()
        {
            // Horizontale Reihen
            if ((button1.Text == button2.Text && button2.Text == button3.Text && !string.IsNullOrEmpty(button1.Text)) ||
                (button4.Text == button5.Text && button5.Text == button6.Text && !string.IsNullOrEmpty(button4.Text)) ||
                (button7.Text == button8.Text && button8.Text == button9.Text && !string.IsNullOrEmpty(button7.Text)) ||
                // Vertikale Reihen
                (button1.Text == button4.Text && button4.Text == button7.Text && !string.IsNullOrEmpty(button1.Text)) ||
                (button2.Text == button5.Text && button5.Text == button8.Text && !string.IsNullOrEmpty(button2.Text)) ||
                (button3.Text == button6.Text && button6.Text == button9.Text && !string.IsNullOrEmpty(button3.Text)) ||
                // Diagonalen
                (button1.Text == button5.Text && button5.Text == button9.Text && !string.IsNullOrEmpty(button1.Text)) ||
                (button3.Text == button5.Text && button5.Text == button7.Text && !string.IsNullOrEmpty(button3.Text)))
            {
                return true;
            }
            return false;
        }

        private void btnBack_Click(object sender, EventArgs e)
            {
                this.Close();
            }
        

        private string PlayerTurn()
        {
            string player;

            if(i % 2== 0)
            {
                player = "X";
            }
            else
            {
                player = "O";
            }
            return player;
        }
        

        

    }
}
