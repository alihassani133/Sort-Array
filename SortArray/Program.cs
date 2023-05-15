using SortArray;
using SortArray.SortingClasses;


int[] numbers = new int[]
{
    78, 23, 95, 32, 47, 12, 56, 83, 69, 40,
    1, 63, 88, 19, 72, 8, 94, 37, 51, 7,
    26, 68, 99, 14, 61, 84, 39, 73, 43, 70,
    31, 91, 20, 96, 54, 80, 28, 74, 9, 49,
    15, 87, 34, 77, 62, 22, 50, 85, 97, 42,
    6, 89, 24, 76, 48, 3, 18, 64, 30, 92,
    17, 60, 38, 79, 45, 11, 66, 82, 98, 57,
    25, 75, 10, 41, 90, 13, 67, 35, 81, 21,
    2, 55, 71, 46, 33, 16, 93, 36, 4, 65,
    29, 86, 58, 100, 27, 53, 5, 59, 44, 52
};


ISort quickSort = new QuickSort();
quickSort.SortArray(numbers);
Console.WriteLine("Quick Sort:");
Print.PrintArray(numbers);

ISort bubbleSort = new BubbleSort();
bubbleSort.SortArray(numbers);
Console.WriteLine("Bubble Sort:");
Print.PrintArray(numbers);

ISort selectionSort = new SelectionSort();
selectionSort.SortArray(numbers);
Console.WriteLine("Selection Sort:");
Print.PrintArray(numbers);