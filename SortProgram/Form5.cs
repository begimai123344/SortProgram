using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Windows.Forms.DataVisualization.Charting;

namespace SortProgram
{

    public partial class Form5 : Form
    {
        public int[] array;
        private Form2 form2;
        private Form3 form3;
        private Form4 form4;
        public Form5()
        {
            InitializeComponent();
            form2 = new Form2();
            form2.SortEvent += HandleSortEvent;
            form3 = new Form3();
            form3.SortEvent += HandleSortEvent;
            form4 = new Form4();

            form4.SortEvent += HandleSortEvent;


        }
        private void HandleSortEvent()
        {
            // Этот метод будет вызван при вызове события SortEvent из Form2
            // Вы можете выполнить необходимые действия здесь
            // Например, вызвать сортировку

            int[] arrayToSort = { 4, 2, 8, 1, 3, 7, 6, 5 };
            Form3 form3 = new Form3();
            Form4 form4 = new Form4();

            Form2.CocktailSortWithInsertion(arrayToSort);
            form3.TournamentSort(arrayToSort);
            form4.ThreadedSort(arrayToSort);
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }





        private TimeSpan MeasureSortingTime(Action sortingMethod)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            sortingMethod(); // Вызываем метод сортировки
            stopwatch.Stop();
            return stopwatch.Elapsed;
        }




        private int[] GenerateRandomArray(int size, int minValue, int maxValue)
        {
            Random random = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(minValue, maxValue + 1);
            }
            return array;
        }

        private int[] RunCocktailSort(int[] array)
        {
            // Возвращаем отсортированный массив
            return Form2.CocktailSortWithInsertion((int[])array.Clone());

        }

        private int[] RunTournamentSort(int[] array)
        {
            Form3 form3 = new Form3();

            int[] sortedArray = (int[])array.Clone(); // Создаем копию массива
            form3.TournamentSort(sortedArray); // Сортируем копию массива внутри метода TournamentSort
            return sortedArray; // Возвращаем отсортированный массив
        }


        private int[] RunThreadedSort(int[] array)
        {
            Form4 form4 = new Form4();
            int[] sortedArray = (int[])array.Clone(); // Создаем копию массива
            form4.ThreadedSort(sortedArray);
            return sortedArray;
        }



        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxNumberOfElements.Text, out int size) && size > 0)
            {
                int minValue = 1; // Минимальное значение элемента массива
                int maxValue = 100; // Максимальное значение элемента массива

                int[] randomArray = GenerateRandomArray(size, minValue, maxValue);
                // Отображение сгенерированного массива в текстовом поле
                textBoxGeneratedArray.Text = string.Join(", ", randomArray);
            }
        }

        private void buttonRunSort_Click(object sender, EventArgs e)
        {
            // Проверка на корректный ввод количества элементов
            if (int.TryParse(textBoxNumberOfElements.Text, out int size) && size > 0)
            {
                int minValue = 1; // Минимальное значение элемента массива
                int maxValue = 100; // Максимальное значение элемента массива

                // Генерация случайного массива для каждой сортировки
                int[] randomArray = GenerateRandomArray(size, minValue, maxValue);
                int[] cocktailSortArray = (int[])randomArray.Clone();
                int[] tournamentSortArray = (int[])randomArray.Clone();
                int[] threadedSortArray = (int[])randomArray.Clone();

                // Выполнение сортировок и измерение времени выполнения
                TimeSpan cocktailSortTime = MeasureSortingTime(() => RunCocktailSort(cocktailSortArray));
                TimeSpan tournamentSortTime = MeasureSortingTime(() => RunTournamentSort(tournamentSortArray));
                TimeSpan threadedSortTime = MeasureSortingTime(() => RunThreadedSort(threadedSortArray));

                // Отображение времени выполнения каждой сортировки в соответствующих текстбоксах
                textBoxCocktailSortTime.Text = $"{cocktailSortTime.TotalMilliseconds} мс";
                textBoxTournamentSortTime.Text = $"{tournamentSortTime.TotalMilliseconds} мс";
                textBoxThreadedSortTime.Text = $"{threadedSortTime.TotalMilliseconds} мс";

                // Отображение отсортированных массивов в текстовых полях
                textBoxCocktailSort.Text = string.Join(", ", cocktailSortArray);
                textBoxTournamentSort.Text = string.Join(", ", tournamentSortArray);
                textBoxThreadedSort.Text = string.Join(", ", threadedSortArray);

            }
        }




        private void Form5_Load(object sender, EventArgs e)
        {

        }







    }
}
