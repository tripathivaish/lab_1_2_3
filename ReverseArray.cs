using System;

namespace reverse_array
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

            int t;

            for (int i = 0; i < n / 2; i++)
            {
                t = a[i];
                a[i] = a[n - i - 1];
                a[n - i - 1] = t;
            }

            Console.WriteLine("Reversed array:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
