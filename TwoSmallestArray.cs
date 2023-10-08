using System;

namespace _2smallest_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input Array
            int n;
            Console.Write("Enter size: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Enter element {0}: ", i + 1);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Sorting Array using bubble sort
            int x, p;
            for (int i = 0; i < a.Length; i++)
            {
                x = a[i];
                p = i;

                while (p > 0 && a[p - 1] > x)
                {
                    a[p] = a[p - 1];
                    p--;
                }

                if (p != i)
                {
                    a[p] = x;
                }
            }

            //Finding 2nd smallest element
            Console.Write("Second smallest element: {0}", a[1]);


            Console.ReadKey();
        }
    }
}
