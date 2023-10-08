using System;
using System.Linq;

namespace remove_duplicate_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter size: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Enter element {0}: ", i + 1);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] unique = a.Distinct().ToArray();
            Console.WriteLine("Array after removing duplicate values: ");
            Array.ForEach(unique, j => Console.Write(j + " "));

            Console.ReadKey();

        }
    }
}
