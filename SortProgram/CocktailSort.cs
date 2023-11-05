using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortProgram
{
    internal class CocktailSort
    {
        public static void CocktailSortWithInsertion(int[] array)
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

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}


