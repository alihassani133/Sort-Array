using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArray.SortingClasses
{
    class QuickSort : ISort
    {
        public void SortArray(int[] numbers)
        {
            QuickSortRecursive(numbers, 0, numbers.Length - 1);
        }
        private void QuickSortRecursive(int[] numbers, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(numbers, low, high);
                QuickSortRecursive(numbers, low, pivotIndex - 1);
                QuickSortRecursive(numbers, pivotIndex + 1, high);
            }
        }
        private int Partition(int[] numbers, int low, int high)
        {
            int pivot = numbers[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (numbers[j] <= pivot)
                {
                    i++;
                    (numbers[j], numbers[i]) = (numbers[i], numbers[j]);
                }
            }

            (numbers[high], numbers[i + 1]) = (numbers[i + 1], numbers[high]);
            return i + 1;
        }
    }
}
