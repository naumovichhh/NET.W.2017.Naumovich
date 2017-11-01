using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    public static class QuickSort
    {
        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void Sort(int[] array)
        {
            Sort(array, 0, array.Length - 1);
        }

        private static void Sort(int[] array, int indexLowest, int indexHighest)
        {
            int i = indexLowest, j = indexHighest;
            int x = array[(i + j) / 2];
            do
            {
                while (array[i] < x)
                {
                    ++i;
                }
                while (array[j] > x)
                {
                    --j;
                }
                if (i <= j)
                {
                    Swap(ref array[i], ref array[j]);
                    ++i;
                    --j;
                }
            } while (i <= j);
            if (indexLowest < j)
            {
                Sort(array, indexLowest, j);
            }
            if (i < indexHighest)
            {
                Sort(array, i, indexHighest);
            }
        }
    }
}
