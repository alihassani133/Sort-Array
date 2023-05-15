using SortArray;
using SortArray.SortingClasses;


int[] numbers = { 5, 2, 4, 1, 0, 3 };


ISort quickSort = new QuickSort();
quickSort.SortArray(numbers);
Console.WriteLine("Quick Sort:");
Print.PrintArray(numbers);

//ISort bubbleSort = new BubbleSort();
//bubbleSort.SortArray(numbers);
//Console.WriteLine("Bubble Sort:");
//Print.PrintArray(numbers);

//ISort selectionSort = new SelectionSort();
//selectionSort.SortArray(numbers);
//Console.WriteLine("Selection Sort:");
//Print.PrintArray(numbers);