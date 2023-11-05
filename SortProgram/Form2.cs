using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using String = System.String;

namespace SortProgram
{

    public partial class Form2 : Form
    {

        public delegate void SortEventHandler();
        public event SortEventHandler SortEvent;
        public int[] array;
        public Form2()
        {
            InitializeComponent();
            array = GenerateRandomArray(10, 1, 100);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public static void SortShaker()
        {
            // Генерация случайного массива
            int[] array = GenerateRandomArray(10, 1, 100);



            Console.WriteLine("Исходный массив:");
            PrintArray(array);

            // Сортировка массива с использованием сортировки Шейкерной с вставками
            CocktailSortWithInsertion(array);

            Console.WriteLine("Отсортированный массив:");
            PrintArray(array);
        }

        // Генерация случайного массива чисел
        public static int[] GenerateRandomArray(int size, int minValue, int maxValue)
        {
            Random random = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(minValue, maxValue + 1);
            }
            return array;
        }

        // Сортировка Шейкерная с вставками

        public static int[] CocktailSortWithInsertion(int[] array)
        {
            int comparisonsCount = 0;
            bool swapped;
            int start = 0;
            int end = array.Length - 1;

            do
            {
                swapped = false;

                // Проход слева направо, как при сортировке пузырьком
                for (int i = start; i < end; ++i)
                {
                    comparisonsCount++;
                    if (array[i] > array[i + 1])
                    {
                        Swap(ref array[i], ref array[i + 1]);
                        swapped = true;
                    }
                }

                if (!swapped)
                    break;

                swapped = false;
                end--;

                // Обратный проход справа налево
                for (int i = end - 1; i >= start; --i)
                {
                    comparisonsCount++;
                    if (array[i] > array[i + 1])
                    {
                        Swap(ref array[i], ref array[i + 1]);
                        swapped = true;
                    }
                }

                start++;

            } while (swapped);
            return array;

        }

        // Обмен значений двух переменных
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // Вывод массива в консоль
        public static void PrintArray(int[] array)
        {
            foreach (var number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
        private void SortButton_Click(object sender, EventArgs e)
        {
            int b = Convert.ToInt32(textBox1.Text);
            // Генерация случайного массива
            //array = GenerateRandomArray(b, 1, 100);

            String a = string.Join(", ", array);

            // Вывод исходного массива (опционально)
            textBox2.Text = a;


        }









        private void buttonBack1_Click(object sender, EventArgs e)
        {
            // Код для перехода на другую форму
            // Например, если у вас есть другая форма с именем Form2, и вы хотите перейти на нее:
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide(); // Скроет текущую форму (Form1) при открытии Form2
        }


        private void button4_Click(object sender, EventArgs e)
        {
            bool swapped;
            int start = 0;
            int end = array.Length - 1;

            do
            {
                swapped = false;

                // Проход снизу вверх
                for (int i = start; i < end; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(ref array[i], ref array[i + 1]);
                        swapped = true;
                        String swappedArray = string.Join(", ", array);
                        listBox1.Items.Add(swappedArray);
                    }
                }

                if (!swapped)
                    break;

                end--;

                // Проход сверху вниз
                for (int i = end; i > start; i--)
                {
                    if (array[i] < array[i - 1])
                    {
                        Swap(ref array[i], ref array[i - 1]);
                        swapped = true;
                        String swappedArray = string.Join(", ", array);
                        listBox1.Items.Add(swappedArray);
                    }
                }

                start++;
            }
            while (swapped);

            String sorted = string.Join(", ", array);
            textBox3.Text = sorted;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
