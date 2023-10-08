using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp2
{
    internal class Program1
    {
        private int stud_id;

        public void SetValue(int std_id)
        {
            stud_id = std_id;
        }

        public int GetValue()
        {
            return stud_id;
        }
    }
    internal class Program2
    {
        public void AccessValue()
        {
            Program1 p = new Program1();
            Console.WriteLine("Enter the Student Id: ");
            int value = Convert.ToInt32(Console.ReadLine());
            p.SetValue(value);
            int value1 = p.GetValue();
            Console.WriteLine(value1);
        }
        static void Main(string[] args)
        {
            Program2 p1 = new Program2();
            p1.AccessValue();
        }
    }
}