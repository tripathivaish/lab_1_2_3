using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp1
{
    internal class Program
    {
        private int a;

        public void setValue(int value)
        {
            a = value;
        }
        public void Display()
        {
            Console.WriteLine(a);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.setValue(1);
            p.Display();
            Console.WriteLine();
        }
    }
}