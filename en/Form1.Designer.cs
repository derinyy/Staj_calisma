namespace en
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
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(32, 29);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(469, 99);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(67, 146);
            button1.Name = "button1";
            button1.Size = new Size(195, 37);
            button1.TabIndex = 1;
            button1.Text = "A";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(278, 146);
            button2.Name = "button2";
            button2.Size = new Size(195, 37);
            button2.TabIndex = 2;
            button2.Text = "B";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(67, 200);
            button3.Name = "button3";
            button3.Size = new Size(195, 37);
            button3.TabIndex = 3;
            button3.Text = "C";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(278, 200);
            button4.Name = "button4";
            button4.Size = new Size(195, 37);
            button4.TabIndex = 4;
            button4.Text = "D";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(170, 256);
            button5.Name = "button5";
            button5.Size = new Size(187, 35);
            button5.TabIndex = 5;
            button5.Text = "Sonraki";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(582, 69);
            label1.Name = "label1";
            label1.Size = new Size(64, 17);
            label1.TabIndex = 6;
            label1.Text = "Soru No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(582, 101);
            label2.Name = "label2";
            label2.Size = new Size(52, 17);
            label2.TabIndex = 7;
            label2.Text = "Dogru:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(582, 131);
            label3.Name = "label3";
            label3.Size = new Size(49, 17);
            label3.TabIndex = 8;
            label3.Text = "Yanlış:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(652, 69);
            label4.Name = "label4";
            label4.Size = new Size(16, 17);
            label4.TabIndex = 9;
            label4.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(685, 101);
            label5.Name = "label5";
            label5.Size = new Size(16, 17);
            label5.TabIndex = 10;
            label5.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(685, 131);
            label6.Name = "label6";
            label6.Size = new Size(16, 17);
            label6.TabIndex = 11;
            label6.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(477, 265);
            label7.Name = "label7";
            label7.Size = new Size(46, 17);
            label7.TabIndex = 12;
            label7.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(477, 292);
            label8.Name = "label8";
            label8.Size = new Size(46, 17);
            label8.TabIndex = 13;
            label8.Text = "label8";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(777, 360);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}