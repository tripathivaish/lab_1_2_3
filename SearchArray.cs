using System;

namespace search_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            Console.Write("Enter size: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[n];
            Console.WriteLine("Enter Elements:");
            for (i = 0; i < a.Length; i++)
            {
                Console.Write("Enter element {0}: ", i + 1);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            int x, f = 0;
            Console.Write("Enter element to find: ");
            x = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < a.Length; i++)
            {
                if (a[i] == x)
                {
                    f = 1;
                    break;
                }
            }

            if (f == 1)
                Console.WriteLine("Element found at index: " + i);
            else
                Console.WriteLine("Element not found");

            Console.ReadKey();
        }
    }
}
