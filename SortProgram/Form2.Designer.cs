namespace SortProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            textBox3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button4 = new Button();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            listBox1 = new ListBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Location = new Point(310, 120);
            button1.Name = "button1";
            button1.Size = new Size(146, 29);
            button1.TabIndex = 0;
            button1.Text = "Сгенерировать";
            button1.UseVisualStyleBackColor = false;
            button1.Click += SortButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 90);
            label1.Name = "label1";
            label1.Size = new Size(237, 20);
            label1.TabIndex = 1;
            label1.Text = "Введите колличество элементов:";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(310, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(452, 27);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 188);
            label2.Name = "label2";
            label2.Size = new Size(170, 20);
            label2.TabIndex = 3;
            label2.Text = "Наш исходный массив:";
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(310, 185);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(452, 27);
            textBox2.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGray;
            button2.Location = new Point(310, 218);
            button2.Name = "button2";
            button2.Size = new Size(182, 29);
            button2.TabIndex = 5;
            button2.Text = "Запустить сортировку";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button4_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(310, 316);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(452, 27);
            textBox3.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(109, 316);
            label3.Name = "label3";
            label3.Size = new Size(195, 20);
            label3.TabIndex = 8;
            label3.Text = "Отсортированный массив:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(251, 24);
            label4.Name = "label4";
            label4.Size = new Size(533, 37);
            label4.TabIndex = 9;
            label4.Text = "Сортировка Шейкерная с вставками";
            // 
            // button4
            // 
            button4.BackColor = Color.LightGray;
            button4.Location = new Point(12, 12);
            button4.Name = "button4";
            button4.Size = new Size(35, 29);
            button4.TabIndex = 23;
            button4.Text = "←";
            button4.UseVisualStyleBackColor = false;
            button4.Click += buttonBack1_Click;
            // 
            // label7
            // 
            label7.AutoEllipsis = true;
            label7.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(25, 647);
            label7.Name = "label7";
            label7.Size = new Size(663, 560);
            label7.TabIndex = 28;
            label7.Text = resources.GetString("label7.Text");
            label7.UseCompatibleTextRendering = true;
            label7.UseMnemonic = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(682, 647);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(346, 290);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSalmon;
            button3.CausesValidation = false;
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ControlDarkDark;
            button3.Location = new Point(18, 567);
            button3.Name = "button3";
            button3.Size = new Size(1022, 40);
            button3.TabIndex = 30;
            button3.Text = "Подробнее";
            button3.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(328, 379);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(388, 164);
            listBox1.TabIndex = 31;
            listBox1.Click += button4_Click;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(112, 379);
            label8.Name = "label8";
            label8.Size = new Size(192, 20);
            label8.TabIndex = 49;
            label8.Text = "Выполненные итеррации:";
            label8.UseWaitCursor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(1040, 633);
            Controls.Add(label8);
            Controls.Add(listBox1);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(button4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }




        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Button button2;
        private TextBox textBox3;
        private Label label3;
        private Label label4;
        private Button button4;
        private Label label7;
        private PictureBox pictureBox1;
        private Button button3;
        private ListBox listBox1;
        private Label label8;
    }
}