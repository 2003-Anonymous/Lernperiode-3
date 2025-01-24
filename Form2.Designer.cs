namespace WinForms1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRestart = new Button();
            btnBack = new Button();
            label1 = new Label();
            btn4x4 = new Button();
            btn5x5 = new Button();
            btn3x3 = new Button();
            SuspendLayout();
            // 
            // btnRestart
            // 
            btnRestart.Location = new Point(23, 219);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(112, 34);
            btnRestart.TabIndex = 9;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Visible = false;
            btnRestart.Click += btnRestart_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(23, 259);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 34);
            btnBack.TabIndex = 10;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Visible = false;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun-ExtG", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(147, 28);
            label1.TabIndex = 11;
            label1.Text = "Player: X";
            label1.Visible = false;
            // 
            // btn4x4
            // 
            btn4x4.Location = new Point(297, 194);
            btn4x4.Name = "btn4x4";
            btn4x4.Size = new Size(166, 59);
            btn4x4.TabIndex = 12;
            btn4x4.Text = "4 X 4";
            btn4x4.UseVisualStyleBackColor = true;
            btn4x4.Click += btn4x4_Click;
            // 
            // btn5x5
            // 
            btn5x5.Location = new Point(297, 289);
            btn5x5.Name = "btn5x5";
            btn5x5.Size = new Size(166, 59);
            btn5x5.TabIndex = 13;
            btn5x5.Text = "5 X 5";
            btn5x5.UseVisualStyleBackColor = true;
            btn5x5.Click += btn5x5_Click;
            // 
            // btn3x3
            // 
            btn3x3.Location = new Point(297, 101);
            btn3x3.Name = "btn3x3";
            btn3x3.Size = new Size(166, 59);
            btn3x3.TabIndex = 14;
            btn3x3.Text = "3 X 3";
            btn3x3.UseVisualStyleBackColor = true;
            btn3x3.Click += btn3x3_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn3x3);
            Controls.Add(btn5x5);
            Controls.Add(btn4x4);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(btnRestart);
            Name = "Form2";
            Text = "TicTacToe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnRestart;
        private Button btnBack;
        private Label label1;
        private Button btn4x4;
        private Button btn5x5;
        private Button btn3x3;
    }
}