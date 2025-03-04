namespace modul3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            output = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            button_equal = new Button();
            button_add = new Button();
            SuspendLayout();
            // 
            // output
            // 
            output.BackColor = Color.Silver;
            output.Location = new Point(267, 50);
            output.Name = "output";
            output.Size = new Size(249, 29);
            output.TabIndex = 0;
            output.Text = "Output";
            output.TextAlign = ContentAlignment.MiddleCenter;
            output.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(267, 94);
            button1.Name = "button1";
            button1.Size = new Size(50, 50);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(323, 94);
            button2.Name = "button2";
            button2.Size = new Size(50, 50);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(379, 94);
            button3.Name = "button3";
            button3.Size = new Size(50, 50);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(267, 150);
            button4.Name = "button4";
            button4.Size = new Size(50, 50);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(323, 150);
            button5.Name = "button5";
            button5.Size = new Size(50, 50);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(379, 150);
            button6.Name = "button6";
            button6.Size = new Size(50, 50);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(267, 206);
            button7.Name = "button7";
            button7.Size = new Size(50, 50);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(323, 206);
            button8.Name = "button8";
            button8.Size = new Size(50, 50);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(379, 206);
            button9.Name = "button9";
            button9.Size = new Size(50, 50);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            // 
            // button0
            // 
            button0.Location = new Point(323, 262);
            button0.Name = "button0";
            button0.Size = new Size(50, 50);
            button0.TabIndex = 10;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            // 
            // button_equal
            // 
            button_equal.Location = new Point(466, 150);
            button_equal.Name = "button_equal";
            button_equal.Size = new Size(50, 50);
            button_equal.TabIndex = 11;
            button_equal.Text = "=";
            button_equal.UseVisualStyleBackColor = true;
            // 
            // button_add
            // 
            button_add.Location = new Point(466, 94);
            button_add.Name = "button_add";
            button_add.Size = new Size(50, 50);
            button_add.TabIndex = 12;
            button_add.Text = "+";
            button_add.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_add);
            Controls.Add(button_equal);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(output);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label output;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button button_equal;
        private Button button_add;
    }
}
