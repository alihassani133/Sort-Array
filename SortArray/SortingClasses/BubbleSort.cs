using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArray.SortingClasses
{
    /// <summary>
    /// This class represents a car.
    /// </summary>
    class BubbleSort : ISort
    {
        public void SortArray(int[] numbers)
        {
            bool isSwapped = true;
            int length = numbers.Length;
            for (int i = 0; i < length && isSwapped; i++)
            {
                isSwapped = false;
                for (int j = 0; j < length - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        (numbers[j + 1], numbers[j]) = (numbers[j], numbers[j + 1]);
                        isSwapped = true;
                    }
                }
            }
        }
    }
}
