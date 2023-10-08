using System;

namespace large_array
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

            int ne = 0, no = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    ne++;
                }
                else
                {
                    no++;
                }
            }

            Console.WriteLine("Number of Even numbers: {0}\nNumber of Odd numbers: {1} ", ne, no);
            Console.ReadKey();
        }
    }
}
