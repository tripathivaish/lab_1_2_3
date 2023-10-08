using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name,cName;
            Console.WriteLine("Enter your name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter your college name:");
            cName = Console.ReadLine();
            Console.WriteLine("name:" + name);
            Console.WriteLine("college name:" + cName);

            //array

            string[] students = new string[5];
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter name of srudents"+(i + 1));
                students[i] = Console.ReadLine();
            }
            for(int i = 0;i < 5; i++)
            {
                Console.WriteLine("Name of students" + (i + 1) +" "+ students[i]);
            }
            Console.ReadLine();
        }
    }
}
