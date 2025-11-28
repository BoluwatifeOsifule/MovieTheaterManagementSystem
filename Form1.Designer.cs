namespace MovieTheaterManagementSystem_Improved
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            listBox1 = new ListBox();
            button1 = new Button();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            comboBox1 = new ComboBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Title";
            textBox1.Size = new Size(150, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 45);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Genre";
            textBox2.Size = new Size(150, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 78);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Duration (min)";
            textBox3.Size = new Size(150, 27);
            textBox3.TabIndex = 2;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 111);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(430, 164);
            listBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(307, 12);
            button1.Name = "button1";
            button1.Size = new Size(135, 29);
            button1.TabIndex = 4;
            button1.Text = "Add Movie";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 342);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Showtime";
            textBox4.Size = new Size(150, 27);
            textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(12, 375);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Customer Name";
            textBox5.Size = new Size(150, 27);
            textBox5.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 408);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(289, 28);
            comboBox1.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(307, 281);
            button2.Name = "button2";
            button2.Size = new Size(135, 29);
            button2.TabIndex = 8;
            button2.Text = "Add Showtime";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(307, 407);
            button3.Name = "button3";
            button3.Size = new Size(135, 29);
            button3.TabIndex = 9;
            button3.Text = "Book";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(307, 441);
            button4.Name = "button4";
            button4.Size = new Size(135, 29);
            button4.TabIndex = 10;
            button4.Text = "Save All";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "A1", "A2", "A3", "A4", "A5", "B1", "B2", "B3", "B4", "B5" });
            comboBox2.Location = new Point(12, 442);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(289, 28);
            comboBox2.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 485);
            Controls.Add(comboBox2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Movie Theater Management System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ListBox listBox1;
        private Button button1;
        private TextBox textBox4;
        private TextBox textBox5;
        private ComboBox comboBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ComboBox comboBox2;
    }
}
