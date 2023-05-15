using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArray.SortingClasses
{
    class SelectionSort : ISort
    {
        public void SortArray(int[] numbers)
        {
            int length = numbers.Length;
            for (int i = 0; i < length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < length; j++)
                {
                    if (numbers[j] < numbers[minIndex])
                    {
                        minIndex = j;
                    }
                }
                (numbers[i], numbers[minIndex]) = (numbers[minIndex], numbers[i]);
            }
        }
    }
}
