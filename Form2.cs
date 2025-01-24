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
        int numberButtons;
        int gridSize = 3;

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
                else if (turnCounter == numberButtons)
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

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn && btn != btnRestart && btn != btnBack && btn != btn4x4 && btn != btn5x5 && btn != btn3x3)
                {
                    btn.Text = "";
                }
            }

            label1.Text = "Player: X";

        }
        private string XorO()
        {
            return (turnCounter % 2 == 0) ? "X" : "O";
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
            MoveButtons();
            DeleteButtons();
            btnRestart_Click(sender, e);
            btn3x3_Click(sender, e);
            numberButtons = 16;
            gridSize = 4;
            List<Point> positions = new List<Point>
            {
                new Point(505, 102),
                new Point(505, 189),
                new Point(505, 281),
                new Point(505, 363),
                new Point(414, 363),
                new Point(323, 363),
                new Point(233, 363)
            };

            for (int i = 0; i < positions.Count; i++)
            {
                Button btn = new Button();
                btn.Location = positions[i];
                btn.Size = new Size(70, 70);
                btn.Click += CheckButton;
                btn.Tag = "Field";
                this.Controls.Add(btn);
            }

            
        }

        private void btn5x5_Click(object sender, EventArgs e)
        {
            MoveButtons();
            DeleteButtons();
            btnRestart_Click(sender, e);            
            btn3x3_Click(sender, e);
            btn4x4_Click(sender, e);            
            numberButtons = 25;
            gridSize = 5;
            List<Point> positions2 = new List<Point>
            {
                new Point(596,102),
                new Point(596,189),
                new Point(596,281),
                new Point(596,363),               
                new Point(233,15),
                new Point(323,15),
                new Point(414,15),
                new Point(505,15),
                new Point(596,15)
            };

            for (int i = 0; i < positions2.Count; i++)
            {
                Button btn = new Button();
                btn.Location = positions2[i];
                btn.Size = new Size(70, 70);
                btn.Click += CheckButton;
                btn.Tag = "Field";
                this.Controls.Add(btn);
            }
            
        }

        private void btn3x3_Click(object sender, EventArgs e)
        {
            MoveButtons();
            DeleteButtons();
            numberButtons = 9;
            List<Point> positions3 = new List<Point>
            {
                new Point(233,102),
                new Point(323,102),
                new Point(414,102),
                new Point(233,189),
                new Point(323,189),
                new Point(414,189),
                new Point(233,281),
                new Point(323,281),
                new Point(414,281)

            };
            for (int i = 0; i < positions3.Count; i++)
            {
                Button btn = new Button();
                btn.Location = positions3[i];
                btn.Size = new Size(70, 70);
                btn.Click += CheckButton;
                btn.Tag = "Field";
                this.Controls.Add(btn);
            }
            
        }

        private void MoveButtons()
        {
            btn5x5.Location = new Point(23, 179);
            btn5x5.Size = new Size(112, 34);

            btn4x4.Location = new Point(23, 139);
            btn4x4.Size = new Size(112, 34);

            btn3x3.Location = new Point(23, 99);
            btn3x3.Size = new Size(112, 34);

            label1.Visible = true;

            btnRestart.Visible = true;

            btnBack.Visible = true;           
        }

        private void DeleteButtons()
        {
            List<Button> buttonsToDelete = new List<Button>();

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn && btn.Tag?.ToString() == "Field")
                {
                    buttonsToDelete.Add(btn);
                }
            }

            foreach (Button btn in buttonsToDelete)
            {
                this.Controls.Remove(btn);
                btn.Dispose();
            }
        }

        private bool CheckWin()
        {
            // Alle Buttons mit Tag "Field" sammeln
            List<Button> buttons = new List<Button>();
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn && btn.Tag?.ToString() == "Field")
                {
                    buttons.Add(btn);
                }
            }

            // Sicherstellen, dass wir genau die richtige Anzahl an Buttons haben
            int expectedButtons = gridSize * gridSize;
            if (buttons.Count != expectedButtons)
            {
                MessageBox.Show($"Fehler: Erwartet wurden {expectedButtons} Buttons, gefunden: {buttons.Count}");
                return false;
            }

            // Buttons nach Reihenfolge im Grid sortieren
            buttons = buttons.OrderBy(b => b.Location.Y).ThenBy(b => b.Location.X).ToList();

            // Spielfeld (2D-Array) befüllen
            Button[,] grid = new Button[gridSize, gridSize];
            for (int i = 0; i < buttons.Count; i++)
            {
                int row = i / gridSize;
                int col = i % gridSize;
                grid[row, col] = buttons[i];
            }

            // Gewinnprüfung: horizontale, vertikale und diagonale Linien prüfen
            for (int i = 0; i < gridSize; i++)
            {
                // Horizontale Prüfung
                if (IsWinningLine(grid[i, 0]?.Text, grid, i, 0, 0, 1))
                    return true;

                // Vertikale Prüfung
                if (IsWinningLine(grid[0, i]?.Text, grid, 0, i, 1, 0))
                    return true;
            }

            // Diagonale von oben links nach unten rechts prüfen
            if (IsWinningLine(grid[0, 0]?.Text, grid, 0, 0, 1, 1))
                return true;

            // Diagonale von oben rechts nach unten links prüfen
            if (IsWinningLine(grid[0, gridSize - 1]?.Text, grid, 0, gridSize - 1, 1, -1))
                return true;

            return false; // Kein Gewinner gefunden
        }
        private bool IsWinningLine(string startText, Button[,] grid, int row, int col, int rowStep, int colStep)
        {
            if (string.IsNullOrEmpty(startText))
                return false; // Leeres Feld bedeutet keine Gewinnlinie

            for (int i = 0; i < gridSize; i++)
            {
                // Schutz vor IndexOutOfRange: Prüfen, ob die Position gültig ist
                if (row < 0 || row >= gridSize || col < 0 || col >= gridSize)
                    return false;

                if (grid[row, col]?.Text != startText)
                    return false; // Unterschiedlicher Text -> Keine Gewinnlinie

                row += rowStep; // Nächste Position
                col += colStep;
            }

            return true; // Alle Felder in der Linie haben denselben Text
        }






    }
}
