using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SortProgram
{
    public partial class Form3 : Form
    {

        public delegate void SortEventHandler();
        public event SortEventHandler SortEvent;
        public int[] array;
        public Form3()
        {
            InitializeComponent();

        }


        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void buttonGenerateAndSort_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxNumberOfElements.Text, out int numberOfElements) &&
               int.TryParse(textBoxMinValue.Text, out int minValue) &&
               int.TryParse(textBoxMaxValue.Text, out int maxValue))
            {
                if (numberOfElements > 0 && minValue < maxValue)
                {
                    array = GenerateRandomArray(numberOfElements, minValue, maxValue);
                    textBoxOriginal.Text = string.Join(", ", array);

                }

            }
        }
        private void buttonSort_Click(object sender, EventArgs e)
        {
            if (array != null)
            {
                TournamentSort(array);
                textBoxSorted.Text = string.Join(", ", array);
            }
            else
            {
                MessageBox.Show("Пожалуйста, сначала сгенерируйте массив.");
            }
        }

        private int[] GenerateRandomArray(int size, int minValue, int maxValue)
        {
            Random random = new Random();
            int[] newArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                newArray[i] = random.Next(minValue, maxValue + 1);
            }
            return newArray;
        }


        private void TournamentSort(int[] array, int n, int index)
        {
            int left = 2 * index + 1;
            int right = 2 * index + 2;
            int largest = index;

            if (left < n && array[left] > array[largest])
            {
                largest = left;
            }

            if (right < n && array[right] > array[largest])
            {
                largest = right;
            }

            if (largest != index)
            {
                Swap(ref array[index], ref array[largest]);
                TournamentSort(array, n, largest);
            }

        }




        private void BuildMaxHeap(int[] array)
        {
            int n = array.Length;
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                TournamentSort(array, n, i);
            }
        }


        public void TournamentSort(int[] array)
        {

            int n = array.Length;

            BuildMaxHeap(array);

            for (int i = n - 1; i > 0; i--)
            {
                Swap(ref array[0], ref array[i]);
                TournamentSort(array, i, 0);
            }
        }



        private void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            // Код для перехода на другую форму
            // Например, если у вас есть другая форма с именем Form2, и вы хотите перейти на нее:
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide(); // Скроет текущую форму (Form1) при открытии Form2
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }




    }

}

