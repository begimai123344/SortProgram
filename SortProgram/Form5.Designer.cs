namespace SortProgram
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            label3 = new Label();
            textBoxThreadedSort = new TextBox();
            RunSortButton = new Button();
            textBoxTournamentSort = new TextBox();
            label2 = new Label();
            textBoxCocktailSort = new TextBox();
            label1 = new Label();
            GenerateArrayButton = new Button();
            textBoxNumberOfElements = new TextBox();
            textBoxGeneratedArray = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBoxCocktailSortTime = new TextBox();
            textBoxThreadedSortTime = new TextBox();
            textBoxTournamentSortTime = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(379, 298);
            label3.Name = "label3";
            label3.Size = new Size(239, 25);
            label3.TabIndex = 17;
            label3.Text = "Отсортированный массив:";
            label3.Click += label3_Click;
            // 
            // textBoxThreadedSort
            // 
            textBoxThreadedSort.Location = new Point(319, 451);
            textBoxThreadedSort.Name = "textBoxThreadedSort";
            textBoxThreadedSort.Size = new Size(367, 27);
            textBoxThreadedSort.TabIndex = 15;
            textBoxThreadedSort.Click += buttonRunSort_Click;
            // 
            // RunSortButton
            // 
            RunSortButton.BackColor = Color.LightGray;
            RunSortButton.Location = new Point(319, 240);
            RunSortButton.Name = "RunSortButton";
            RunSortButton.Size = new Size(182, 29);
            RunSortButton.TabIndex = 14;
            RunSortButton.Text = "Запустить сортировку";
            RunSortButton.UseVisualStyleBackColor = false;
            RunSortButton.Click += buttonRunSort_Click;
            // 
            // textBoxTournamentSort
            // 
            textBoxTournamentSort.Location = new Point(319, 395);
            textBoxTournamentSort.Name = "textBoxTournamentSort";
            textBoxTournamentSort.Size = new Size(367, 27);
            textBoxTournamentSort.TabIndex = 13;
            textBoxTournamentSort.Click += buttonRunSort_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(127, 210);
            label2.Name = "label2";
            label2.Size = new Size(170, 20);
            label2.TabIndex = 12;
            label2.Text = "Наш исходный массив:";
            label2.Click += label2_Click;
            // 
            // textBoxCocktailSort
            // 
            textBoxCocktailSort.Location = new Point(319, 341);
            textBoxCocktailSort.Name = "textBoxCocktailSort";
            textBoxCocktailSort.Size = new Size(367, 27);
            textBoxCocktailSort.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 116);
            label1.Name = "label1";
            label1.Size = new Size(237, 20);
            label1.TabIndex = 10;
            label1.Text = "Введите колличество элементов:";
            label1.Click += label1_Click;
            // 
            // GenerateArrayButton
            // 
            GenerateArrayButton.BackColor = Color.LightGray;
            GenerateArrayButton.Location = new Point(319, 142);
            GenerateArrayButton.Name = "GenerateArrayButton";
            GenerateArrayButton.Size = new Size(146, 29);
            GenerateArrayButton.TabIndex = 9;
            GenerateArrayButton.Text = "Сгенерировать";
            GenerateArrayButton.UseVisualStyleBackColor = false;
            GenerateArrayButton.Click += buttonGenerate_Click;
            // 
            // textBoxNumberOfElements
            // 
            textBoxNumberOfElements.Location = new Point(319, 109);
            textBoxNumberOfElements.Name = "textBoxNumberOfElements";
            textBoxNumberOfElements.Size = new Size(452, 27);
            textBoxNumberOfElements.TabIndex = 20;
            // 
            // textBoxGeneratedArray
            // 
            textBoxGeneratedArray.Location = new Point(319, 203);
            textBoxGeneratedArray.Name = "textBoxGeneratedArray";
            textBoxGeneratedArray.Size = new Size(452, 27);
            textBoxGeneratedArray.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(120, 334);
            label4.Name = "label4";
            label4.Size = new Size(180, 40);
            label4.TabIndex = 22;
            label4.Text = "Сортировка Шейкерная \r\nс вставками:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(127, 398);
            label5.Name = "label5";
            label5.Size = new Size(173, 20);
            label5.TabIndex = 23;
            label5.Text = "Турнирная сортировка:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(119, 454);
            label6.Name = "label6";
            label6.Size = new Size(181, 20);
            label6.TabIndex = 24;
            label6.Text = "Нитевидная сортировка:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(379, 32);
            label7.Name = "label7";
            label7.Size = new Size(133, 31);
            label7.TabIndex = 25;
            label7.Text = "Сравнение";
            // 
            // textBoxCocktailSortTime
            // 
            textBoxCocktailSortTime.Location = new Point(722, 341);
            textBoxCocktailSortTime.Name = "textBoxCocktailSortTime";
            textBoxCocktailSortTime.Size = new Size(128, 27);
            textBoxCocktailSortTime.TabIndex = 27;
            // 
            // textBoxThreadedSortTime
            // 
            textBoxThreadedSortTime.Location = new Point(722, 451);
            textBoxThreadedSortTime.Name = "textBoxThreadedSortTime";
            textBoxThreadedSortTime.Size = new Size(128, 27);
            textBoxThreadedSortTime.TabIndex = 28;
            // 
            // textBoxTournamentSortTime
            // 
            textBoxTournamentSortTime.Location = new Point(722, 391);
            textBoxTournamentSortTime.Name = "textBoxTournamentSortTime";
            textBoxTournamentSortTime.Size = new Size(128, 27);
            textBoxTournamentSortTime.TabIndex = 29;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Location = new Point(705, 298);
            button1.Name = "button1";
            button1.Size = new Size(164, 29);
            button1.TabIndex = 30;
            button1.Text = "Время выполнения";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(188, 578);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(614, 385);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(289, 886);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(513, 77);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 32;
            pictureBox2.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(110, 886);
            label8.Name = "label8";
            label8.Size = new Size(180, 40);
            label8.TabIndex = 33;
            label8.Text = "Сортировка Шейкерная \r\nс вставками:";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(117, 923);
            label9.Name = "label9";
            label9.Size = new Size(173, 20);
            label9.TabIndex = 34;
            label9.Text = "Турнирная сортировка:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(109, 943);
            label10.Name = "label10";
            label10.Size = new Size(181, 20);
            label10.TabIndex = 35;
            label10.Text = "Нитевидная сортировка:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(456, 973);
            label11.Name = "label11";
            label11.Size = new Size(0, 20);
            label11.TabIndex = 36;
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(949, 598);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(textBoxTournamentSortTime);
            Controls.Add(textBoxThreadedSortTime);
            Controls.Add(textBoxCocktailSortTime);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBoxGeneratedArray);
            Controls.Add(textBoxNumberOfElements);
            Controls.Add(label3);
            Controls.Add(textBoxThreadedSort);
            Controls.Add(RunSortButton);
            Controls.Add(textBoxTournamentSort);
            Controls.Add(label2);
            Controls.Add(textBoxCocktailSort);
            Controls.Add(label1);
            Controls.Add(GenerateArrayButton);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox textBoxThreadedSort;
        private Button RunSortButton;
        private TextBox textBoxTournamentSort;
        private Label label2;
        private TextBox textBoxCocktailSort;
        private Label label1;
        private Button GenerateArrayButton;
        private TextBox textBoxNumberOfElements;
        private TextBox textBoxGeneratedArray;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBoxCocktailSortTime;
        private TextBox textBoxThreadedSortTime;
        private TextBox textBoxTournamentSortTime;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}