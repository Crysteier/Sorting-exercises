using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_exercises
{
    public static class SharedUtility
    {
        public static void WriteArrayToConsole(int[] arr)
        {
            Console.Write($"[ ");
            foreach (var item in arr)
            {
                Console.Write($"{item}, ");
            }
            Console.Write($" ]");
        }
    }
}
