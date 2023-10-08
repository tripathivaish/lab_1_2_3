using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHelper
{
    static class MathHelper
    {
        public static double CalculateAverage(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                Console.WriteLine("Array can't be null");
            }

            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return (double)sum / numbers.Length;
        }
        static void Main(string[] args)
        {
            int size;
            size = Convert.ToInt32(Console.ReadLine());
            int[] Array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter the elements {0}", i + 1);
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }
            double average = MathHelper.CalculateAverage(Array);
            Console.WriteLine("Average: " + average);
            Console.ReadKey();
        }
    }
}
