using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArray
{
    interface ISort
    {
        /// <summary>
        /// Sorts an array of integers.
        /// </summary>
        /// <param name="numbers">The array to be sorted.</param>
        void SortArray(int[] numbers);
    }
}
