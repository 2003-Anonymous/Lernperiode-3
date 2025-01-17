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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            btnRestart = new Button();
            btnBack = new Button();
            label1 = new Label();
            btn4x4 = new Button();
            btn5x5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(233, 102);
            button1.Name = "button1";
            button1.Size = new Size(70, 70);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += CheckButton;
            // 
            // button2
            // 
            button2.Location = new Point(323, 102);
            button2.Name = "button2";
            button2.Size = new Size(70, 70);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += CheckButton;
            // 
            // button3
            // 
            button3.Location = new Point(414, 102);
            button3.Name = "button3";
            button3.Size = new Size(70, 70);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += CheckButton;
            // 
            // button4
            // 
            button4.Location = new Point(233, 189);
            button4.Name = "button4";
            button4.Size = new Size(70, 70);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += CheckButton;
            // 
            // button5
            // 
            button5.Location = new Point(323, 189);
            button5.Name = "button5";
            button5.Size = new Size(70, 70);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += CheckButton;
            // 
            // button6
            // 
            button6.Location = new Point(414, 189);
            button6.Name = "button6";
            button6.Size = new Size(70, 70);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            button6.Click += CheckButton;
            // 
            // button7
            // 
            button7.Location = new Point(233, 281);
            button7.Name = "button7";
            button7.Size = new Size(70, 70);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = true;
            button7.Click += CheckButton;
            // 
            // button8
            // 
            button8.Location = new Point(323, 281);
            button8.Name = "button8";
            button8.Size = new Size(70, 70);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            button8.Click += CheckButton;
            // 
            // button9
            // 
            button9.Location = new Point(414, 281);
            button9.Name = "button9";
            button9.Size = new Size(70, 70);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = true;
            button9.Click += CheckButton;
            // 
            // btnRestart
            // 
            btnRestart.Location = new Point(590, 175);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(112, 34);
            btnRestart.TabIndex = 9;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(590, 215);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 34);
            btnBack.TabIndex = 10;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun-ExtG", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(291, 41);
            label1.Name = "label1";
            label1.Size = new Size(147, 28);
            label1.TabIndex = 11;
            label1.Text = "Player: X";
            // 
            // btn4x4
            // 
            btn4x4.Location = new Point(59, 141);
            btn4x4.Name = "btn4x4";
            btn4x4.Size = new Size(112, 34);
            btn4x4.TabIndex = 12;
            btn4x4.Text = "4 X 4";
            btn4x4.UseVisualStyleBackColor = true;
            btn4x4.Click += btn4x4_Click;
            // 
            // btn5x5
            // 
            btn5x5.Location = new Point(59, 207);
            btn5x5.Name = "btn5x5";
            btn5x5.Size = new Size(112, 34);
            btn5x5.TabIndex = 13;
            btn5x5.Text = "5 X 5";
            btn5x5.UseVisualStyleBackColor = true;
            btn5x5.Click += btn5x5_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn5x5);
            Controls.Add(btn4x4);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(btnRestart);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form2";
            Text = "TicTacToe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button btnRestart;
        private Button btnBack;
        private Label label1;
        private Button btn4x4;
        private Button btn5x5;
    }
}