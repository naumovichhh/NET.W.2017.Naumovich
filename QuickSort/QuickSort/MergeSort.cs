using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    public class MergeSort
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
            if (indexHighest <= indexLowest)
                return;
            int mid = indexLowest + (indexHighest - indexLowest) / 2;
            Sort(array, indexLowest, mid);
            Sort(array, mid + 1, indexHighest);
            int[] buf = new int[array.Length];
            Array.Copy(array, buf, array.Length);
            for (int k = indexLowest; k <= indexHighest; k++)
            {
                buf[k] = array[k];
            }
            int i = indexLowest, j = mid + 1;
            for (int k = indexLowest; k <= indexHighest; k++)
            {
                if (i > mid)
                {
                    array[k] = buf[j];
                    j++;
                }
                else if (j > indexHighest)
                {
                    array[k] = buf[i];
                    i++;
                }
                else if (buf[j] < buf[i])
                {
                    array[k] = buf[j];
                    j++;
                }
                else
                {
                    array[k] = buf[i];
                    i++;
                }
            }
        }
    }
}
