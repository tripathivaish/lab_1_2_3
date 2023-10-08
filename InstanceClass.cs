using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceClass
{
    internal class Program
    {
       
        }
        static void Main(string[] args)

        {

        int n, f;
        Console.WriteLine("enter size");
      
       n= Convert.ToInt32(Console.ReadLine());
        int[] a =new int[n];
        for(int i=0; i < a.Length;i++)
        {
            Console.Write("enter element{0}:", i + 1);
            a[i] = Convert.ToInt32(Console.ReadLine());

        }
        Console.Write("enter factor");
        f = Convert.ToInt32(Console.ReadLine());
        for(int i=0;i<n;i++)
        {
            a[i] *= f;
        }
        Console.WriteLine("new array");
        for(int i=0;i<a.Length;i++)
        {
            Console.Write(a[i] + "");

        }
        Console.ReadKey();
        }
    }
}
