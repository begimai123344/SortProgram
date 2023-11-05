using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SortProgram
{

    public partial class Form4 : Form
    {
        private int[] array; // Массив для сортировки
        private int currentIndex = 0; // Текущий индекс для нитевидной сортировки
        public delegate void SortEventHandler();
        public event SortEventHandler SortEvent;

        public Form4()
        {
            InitializeComponent();

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        public void ThreadedSort(int[] array)
        {
            bool swapped;
            int start = 0;
            int end = array.Length - 1;

            do
            {
                swapped = false;

                // Проход слева направо, как при сортировке пузырьком
                for (int i = start; i < end; ++i)
                {
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
                    if (array[i] > array[i + 1])
                    {
                        Swap(ref array[i], ref array[i + 1]);
                        swapped = true;
                    }
                }

                start++;

            } while (swapped);
        }

        public void buttonGenerate_Click(object sender, EventArgs e)
        {
            // Проверка на корректный ввод количества элементов
            if (int.TryParse(textBoxNumberOfElements.Text, out int numberOfElements) && numberOfElements > 0)
            {
                // Генерация случайных чисел
                Random random = new Random();
                array = Enumerable.Range(1, numberOfElements).Select(i => random.Next(1, 100)).ToArray();

                // Отображение сгенерированного массива в текстбоксе
                textBoxGeneratedArray.Text = string.Join(", ", array);
            }

        }

        private void buttonStep_Click(object sender, EventArgs e)
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
            textBoxSortedArray.Text = sorted;
            
            // Проверка, что массив существует и не пустой
            if (array != null && array.Length > 0)
            {
                // Выполнение одного шага нитевидной сортировки
                ThreadedSort(array);

                // Отображение текущего состояния массива в текстбоксе
                textBoxSortedArray.Text = string.Join(", ", array);
            }
            else
            {
                MessageBox.Show("Сначала сгенерируйте массив.");
            }
        }


        public void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            // Код для перехода на другую форму
            // Например, если у вас есть другая форма с именем Form2, и вы хотите перейти на нее:
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide(); // Скроет текущую форму (Form1) при открытии Form2
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
