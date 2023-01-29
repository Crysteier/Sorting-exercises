using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_exercises.Sorting_algos
{
    public class Quicksort
    {
        /// <summary>
        /// My implementation of the quicksort algorithm
        /// Best case scenario: O(n log(n))
        /// Average scenario: O(n log(n))
        /// Worst case scenario: O(n^2)
        /// </summary>
        /// <param name="numbers"></param>
        public Quicksort()
        {

        }

        public void Sort(int[] numbers)
        {
            //TODO
            //implement the quicksort
            Console.WriteLine("Before Quicksort");
            SharedUtility.WriteArrayToConsole(numbers);
            QuickSorting(numbers, 0, numbers.Length - 1);
            Console.WriteLine("\nAfter Quicksort");
            SharedUtility.WriteArrayToConsole(numbers);

        }

        private int Partition(int[] numbers, int low, int high)
        {
            int pivot = numbers[high];

            int i = (low - 1);

            for (int j = low; j <= high - 1; j++)
            {
                if (numbers[j] < pivot)
                {
                    i++;
                    Swap(numbers, i, j);
                }
            }
            Swap(numbers, i + 1, high);
            return (i + 1);
        }

        private void QuickSorting(int[] numbers, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(numbers, low, high);

                QuickSorting(numbers, low, pi - 1);
                QuickSorting(numbers, pi + 1, high);
            }
        }

        private void Swap(int[] numbers, int x, int y)
        {
            int temp = numbers[x];
            numbers[x] = numbers[y];
            numbers[y] = temp;
        }


    }
}
