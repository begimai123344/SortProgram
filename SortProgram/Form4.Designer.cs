namespace SortProgram
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            label6 = new Label();
            label5 = new Label();
            textBoxMinValue = new TextBox();
            textBoxMaxValue = new TextBox();
            button4 = new Button();
            label3 = new Label();
            textBoxSortedArray = new TextBox();
            button2 = new Button();
            textBoxGeneratedArray = new TextBox();
            label2 = new Label();
            textBoxNumberOfElements = new TextBox();
            label1 = new Label();
            button1 = new Button();
            label4 = new Label();
            button5 = new Button();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            pictureBox2 = new PictureBox();
            listBox1 = new ListBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(396, 173);
            label6.Name = "label6";
            label6.Size = new Size(178, 20);
            label6.TabIndex = 41;
            label6.Text = "Введите макс. значение:";
            label6.UseWaitCursor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(87, 176);
            label5.Name = "label5";
            label5.Size = new Size(174, 20);
            label5.TabIndex = 40;
            label5.Text = "Введите мин. значение:";
            label5.UseWaitCursor = true;
            // 
            // textBoxMinValue
            // 
            textBoxMinValue.Location = new Point(274, 173);
            textBoxMinValue.Name = "textBoxMinValue";
            textBoxMinValue.Size = new Size(116, 27);
            textBoxMinValue.TabIndex = 39;
            textBoxMinValue.UseWaitCursor = true;
            // 
            // textBoxMaxValue
            // 
            textBoxMaxValue.Location = new Point(580, 173);
            textBoxMaxValue.Name = "textBoxMaxValue";
            textBoxMaxValue.Size = new Size(146, 27);
            textBoxMaxValue.TabIndex = 38;
            textBoxMaxValue.UseWaitCursor = true;
            // 
            // button4
            // 
            button4.BackColor = Color.LightGray;
            button4.Location = new Point(31, 29);
            button4.Name = "button4";
            button4.Size = new Size(35, 29);
            button4.TabIndex = 37;
            button4.Text = "←";
            button4.UseVisualStyleBackColor = false;
            button4.UseWaitCursor = true;
            button4.Click += buttonBack_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 408);
            label3.Name = "label3";
            label3.Size = new Size(195, 20);
            label3.TabIndex = 36;
            label3.Text = "Отсортированный массив:";
            label3.UseWaitCursor = true;
            // 
            // textBoxSortedArray
            // 
            textBoxSortedArray.Location = new Point(274, 408);
            textBoxSortedArray.Name = "textBoxSortedArray";
            textBoxSortedArray.Size = new Size(452, 27);
            textBoxSortedArray.TabIndex = 34;
            textBoxSortedArray.UseWaitCursor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGray;
            button2.Location = new Point(274, 330);
            button2.Name = "button2";
            button2.Size = new Size(182, 29);
            button2.TabIndex = 33;
            button2.Text = "Запустить сортировку";
            button2.UseVisualStyleBackColor = false;
            button2.UseWaitCursor = true;
            button2.Click += buttonStep_Click;
            // 
            // textBoxGeneratedArray
            // 
            textBoxGeneratedArray.Location = new Point(274, 297);
            textBoxGeneratedArray.Name = "textBoxGeneratedArray";
            textBoxGeneratedArray.Size = new Size(452, 27);
            textBoxGeneratedArray.TabIndex = 32;
            textBoxGeneratedArray.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 300);
            label2.Name = "label2";
            label2.Size = new Size(170, 20);
            label2.TabIndex = 31;
            label2.Text = "Наш исходный массив:";
            label2.UseWaitCursor = true;
            // 
            // textBoxNumberOfElements
            // 
            textBoxNumberOfElements.Location = new Point(274, 120);
            textBoxNumberOfElements.Name = "textBoxNumberOfElements";
            textBoxNumberOfElements.Size = new Size(452, 27);
            textBoxNumberOfElements.TabIndex = 30;
            textBoxNumberOfElements.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 123);
            label1.Name = "label1";
            label1.Size = new Size(237, 20);
            label1.TabIndex = 29;
            label1.Text = "Введите колличество элементов:";
            label1.UseWaitCursor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Location = new Point(580, 225);
            button1.Name = "button1";
            button1.Size = new Size(146, 29);
            button1.TabIndex = 28;
            button1.Text = "Сгенерировать";
            button1.UseVisualStyleBackColor = false;
            button1.UseWaitCursor = true;
            button1.Click += buttonGenerate_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(274, 42);
            label4.Name = "label4";
            label4.Size = new Size(357, 37);
            label4.TabIndex = 27;
            label4.Text = "Нитевидная сортировка";
            label4.UseWaitCursor = true;
            // 
            // button5
            // 
            button5.BackColor = Color.LightSalmon;
            button5.CausesValidation = false;
            button5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ControlDarkDark;
            button5.Location = new Point(2, 961);
            button5.Name = "button5";
            button5.Size = new Size(986, 40);
            button5.TabIndex = 43;
            button5.Text = "Подробнее";
            button5.UseVisualStyleBackColor = false;
            button5.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(196, 681);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(530, 238);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(2, 1027);
            label7.Name = "label7";
            label7.Size = new Size(617, 499);
            label7.TabIndex = 45;
            label7.Text = resources.GetString("label7.Text");
            label7.UseWaitCursor = true;
            label7.Click += label7_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(608, 1027);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(485, 295);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 46;
            pictureBox2.TabStop = false;
            pictureBox2.UseWaitCursor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(274, 467);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(388, 164);
            listBox1.TabIndex = 47;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(69, 467);
            label8.Name = "label8";
            label8.Size = new Size(192, 20);
            label8.TabIndex = 48;
            label8.Text = "Выполненные итеррации:";
            label8.UseWaitCursor = true;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.LightSalmon;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1011, 675);
            Controls.Add(label8);
            Controls.Add(listBox1);
            Controls.Add(pictureBox2);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(button5);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBoxMinValue);
            Controls.Add(textBoxMaxValue);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(textBoxSortedArray);
            Controls.Add(button2);
            Controls.Add(textBoxGeneratedArray);
            Controls.Add(label2);
            Controls.Add(textBoxNumberOfElements);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(label4);
            Name = "Form4";
            RightToLeftLayout = true;
            Text = "Form4";
            UseWaitCursor = true;
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private TextBox textBoxMinValue;
        private TextBox textBoxMaxValue;
        private Button button4;
        private Label label3;
        private TextBox textBoxSortedArray;
        private Button button2;
        private TextBox textBoxGeneratedArray;
        private Label label2;
        private TextBox textBoxNumberOfElements;
        private Label label1;
        private Button button1;
        private Label label4;
        private Button button5;
        private PictureBox pictureBox1;
        private Label label7;
        private PictureBox pictureBox2;
        private ListBox listBox1;
        private Label label8;
    }
}