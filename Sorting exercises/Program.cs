using Sorting_exercises;
using Sorting_exercises.Sorting_algos;

int[] sortThis = { 50, 48, 22, 1154, 1, 0, 8859, -51, 555444488, 999, 123456, 852456, 2, 3, -100, 963 };

Console.WriteLine("I will be sorting this array: ");
sortThis.WriteArrayToConsole();
Console.WriteLine();

var quicksort = new Quicksort((int[])sortThis.Clone());
var selectionsort = new SelectionSort((int[])sortThis.Clone());
var bubblesort = new BubbleSort((int[])sortThis.Clone());

quicksort.Sort();
selectionsort.Sort();
bubblesort.Sort();