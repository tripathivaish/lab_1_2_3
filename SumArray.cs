using System;

namespace sum_array
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

            int sum = 0;

            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }

            Console.WriteLine("Sum: " + sum);
            Console.ReadKey();
        }
    }
}
