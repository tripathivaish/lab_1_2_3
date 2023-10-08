using System;

namespace multiply_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, f;
            Console.Write("Enter size: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Enter element {0}: ", i + 1);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter Factor: ");
            f = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                a[i] *= f;
            }

            Console.WriteLine("New array:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
