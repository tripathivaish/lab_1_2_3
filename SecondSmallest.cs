using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondSmallest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter size");
            n=Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for(int i=0;i<a.Length;i++) {
                Console.Write("Enter element{0}", i + 1);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int x, p;
            for(int i=0;i<a.Length;i++)
            {
                x = a[i];
                p = i;
                while(p>0 && a[p-1]>x){
                    a[p] = a[p - 1];
                    p--;

                }
                if(p!=i)

                {
                    a[p] = x;   
                }            }
            Console.Write("second Smallest element:{0}", a[1]);

            Console.ReadKey();
        }
        

    }
}
