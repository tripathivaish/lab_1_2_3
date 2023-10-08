using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1secondprogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 ,4,4,5,6,7,8};
            float sum=0;
            for(int i=0; i<arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
