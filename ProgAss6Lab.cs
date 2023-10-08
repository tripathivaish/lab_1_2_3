using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp6
{
    public class Program
    {
        public string first_name, last_name;

        public Program(string fName, string lName)
        {
            Console.Write("Enter the first name: ");
            fName = Console.ReadLine();
            Console.Write("Enter the last name: ");
            lName = Console.ReadLine();
        }
    }
}