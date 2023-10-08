using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Exp3;

namespace exp3_1
{
    class Program1
    {
        static void Main(string[] args)
        {
            Assembly1 p = new Assembly1();
            Console.Write("Enter the name:");
            string sName = Console.ReadLine();
            p.studName(sName);
            Console.WriteLine("Name is: " + p.GetName());
        }
    }
}