using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class SortArrayExercise
    {
        public int[] BubbleSort(int[] unsortedArray)
        {
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                for (int j = 0; j < unsortedArray.Length - 1; j++)
                {
                    if (unsortedArray[j] < unsortedArray[j + 1])
                        continue;
                    int temp = unsortedArray[j];
                    unsortedArray[j] = unsortedArray[j + 1];
                    unsortedArray[j + 1] = temp;
                }
            }
            return unsortedArray;
        }

        public int[] QuickSort(int[] unsortedArray)
        {
            throw new NotImplementedException();
        }

    }
}
