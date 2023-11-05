namespace SortProgram
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label4 = new Label();
            label3 = new Label();
            button3 = new Button();
            textBoxSorted = new TextBox();
            button2 = new Button();
            textBoxOriginal = new TextBox();
            label2 = new Label();
            textBoxNumberOfElements = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button4 = new Button();
            textBoxMaxValue = new TextBox();
            textBoxMinValue = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            listBox1 = new ListBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(305, 30);
            label4.Name = "label4";
            label4.Size = new Size(339, 37);
            label4.TabIndex = 10;
            label4.Text = "Турнирная сортировка";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(109, 392);
            label3.Name = "label3";
            label3.Size = new Size(195, 20);
            label3.TabIndex = 19;
            label3.Text = "Отсортированный массив:";
            // 
            // button3
            // 
            button3.BackColor = Color.LightSalmon;
            button3.CausesValidation = false;
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ControlDarkDark;
            button3.Location = new Point(14, 976);
            button3.Name = "button3";
            button3.Size = new Size(961, 40);
            button3.TabIndex = 18;
            button3.Text = "Подробнее";
            button3.UseVisualStyleBackColor = false;
            button3.Click += buttonSort_Click;
            // 
            // textBoxSorted
            // 
            textBoxSorted.Location = new Point(317, 389);
            textBoxSorted.Name = "textBoxSorted";
            textBoxSorted.Size = new Size(452, 27);
            textBoxSorted.TabIndex = 17;
            textBoxSorted.Click += buttonSort_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGray;
            button2.Location = new Point(317, 314);
            button2.Name = "button2";
            button2.Size = new Size(182, 29);
            button2.TabIndex = 16;
            button2.Text = "Запустить сортировку";
            button2.UseVisualStyleBackColor = false;
            button2.Click += buttonSort_Click;
            // 
            // textBoxOriginal
            // 
            textBoxOriginal.Location = new Point(317, 281);
            textBoxOriginal.Name = "textBoxOriginal";
            textBoxOriginal.Size = new Size(452, 27);
            textBoxOriginal.TabIndex = 15;
            textBoxOriginal.Click += buttonGenerateAndSort_Click;
            textBoxOriginal.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 284);
            label2.Name = "label2";
            label2.Size = new Size(170, 20);
            label2.TabIndex = 14;
            label2.Text = "Наш исходный массив:";
            // 
            // textBoxNumberOfElements
            // 
            textBoxNumberOfElements.Location = new Point(317, 104);
            textBoxNumberOfElements.Name = "textBoxNumberOfElements";
            textBoxNumberOfElements.Size = new Size(452, 27);
            textBoxNumberOfElements.TabIndex = 13;
            textBoxNumberOfElements.Click += buttonGenerateAndSort_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 107);
            label1.Name = "label1";
            label1.Size = new Size(237, 20);
            label1.TabIndex = 12;
            label1.Text = "Введите колличество элементов:";
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Location = new Point(623, 201);
            button1.Name = "button1";
            button1.Size = new Size(146, 29);
            button1.TabIndex = 11;
            button1.Text = "Сгенерировать";
            button1.UseVisualStyleBackColor = false;
            button1.Click += buttonGenerateAndSort_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LightGray;
            button4.Location = new Point(12, 12);
            button4.Name = "button4";
            button4.Size = new Size(35, 29);
            button4.TabIndex = 22;
            button4.Text = "←";
            button4.UseVisualStyleBackColor = false;
            button4.Click += buttonBack_Click;
            // 
            // textBoxMaxValue
            // 
            textBoxMaxValue.Location = new Point(623, 157);
            textBoxMaxValue.Name = "textBoxMaxValue";
            textBoxMaxValue.Size = new Size(146, 27);
            textBoxMaxValue.TabIndex = 23;
            textBoxMaxValue.Click += buttonGenerateAndSort_Click;
            // 
            // textBoxMinValue
            // 
            textBoxMinValue.Location = new Point(317, 157);
            textBoxMinValue.Name = "textBoxMinValue";
            textBoxMinValue.Size = new Size(116, 27);
            textBoxMinValue.TabIndex = 24;
            textBoxMinValue.Click += buttonGenerateAndSort_Click;
            textBoxMinValue.TextChanged += textBox2_TextChanged_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(130, 160);
            label5.Name = "label5";
            label5.Size = new Size(174, 20);
            label5.TabIndex = 25;
            label5.Text = "Введите мин. значение:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(439, 157);
            label6.Name = "label6";
            label6.Size = new Size(178, 20);
            label6.TabIndex = 26;
            label6.Text = "Введите макс. значение:";
            // 
            // label8
            // 
            label8.AutoEllipsis = true;
            label8.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(14, 1053);
            label8.Name = "label8";
            label8.Size = new Size(537, 597);
            label8.TabIndex = 28;
            label8.Text = resources.GetString("label8.Text");
            label8.UseCompatibleTextRendering = true;
            label8.UseMnemonic = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(541, 1053);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(451, 289);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(14, 672);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(487, 262);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(537, 672);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(437, 262);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 31;
            pictureBox3.TabStop = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(317, 460);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(388, 164);
            listBox1.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(112, 460);
            label7.Name = "label7";
            label7.Size = new Size(192, 20);
            label7.TabIndex = 49;
            label7.Text = "Выполненные итеррации:";
            label7.UseWaitCursor = true;
            // 
            // Form3
            // 
            AutoScroll = true;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(996, 707);
            Controls.Add(label7);
            Controls.Add(listBox1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBoxMinValue);
            Controls.Add(textBoxMaxValue);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(textBoxSorted);
            Controls.Add(button2);
            Controls.Add(textBoxOriginal);
            Controls.Add(label2);
            Controls.Add(textBoxNumberOfElements);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(label4);
            Name = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label4;
        private Label label3;
        private Button button3;
        private TextBox textBoxSorted;
        private Button button2;
        private TextBox textBoxOriginal;
        private Label label2;
        private TextBox textBoxNumberOfElements;
        private Label label1;
        private Button button1;
        private Button button4;
        private TextBox textBoxMaxValue;
        private TextBox textBoxMinValue;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
        private Label label8;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private ListBox listBox1;
        private Label label7;
    }
    #endregion
}