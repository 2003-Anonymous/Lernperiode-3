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

        int turnCounter = 0;


        private void CheckButton(object sender, EventArgs e)
        {
            Button myButton = (Button)sender;

            if (string.IsNullOrEmpty(myButton.Text))
            {
                myButton.Text = XorO();
                turnCounter++;
                if (CheckWin())
                {
                    MessageBox.Show($"Spieler {myButton.Text} hat gewonnen!");
                    btnRestart_Click(null, null);
                }
                else if (turnCounter == 9)
                {
                    MessageBox.Show("Unentschieden!");
                    btnRestart_Click(null, null);
                }
            }
            label1.Text = "Player: " + PlayerTurn();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            turnCounter = 0;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            label1.Text = "Player: X";
        }
        private string XorO()
        {
            return (turnCounter % 2 == 0) ? "X" : "O";
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
            return (turnCounter % 2 == 0) ? "X" : "O";
        }

        private void btn4x4_Click(object sender, EventArgs e)
        {
            Button btn4 = new Button();
            btn4.Location = new Point(40);
        }

        private void btn5x5_Click(object sender, EventArgs e)
        {

        }
    }
}
