using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            MCA_Sec_A m1=new MCA_Sec_A();
            m1.function(); */
          // MCA_secA3 m3 = new MCA_secA3();
            MCA_secA3.function3();
            Console.ReadLine();
        }
    }
    sealed class MCA_Sec_A
    {
        public static void function()
        {
            Console.WriteLine("Sealed class MCA_Sec_A fun 1");
        }
    }
    /*class MCA_SEC_A1: MCA_Sec_A
    {
        public void function2()
        {
            Console.WriteLine("Sealed class MCA_Sec_A fun 1");
        }
    }*/
    class MCA_secA3
    { 
        public static  void function3() {
            Console.WriteLine("function 3 from class MCA_A3");
        }
    }
}
