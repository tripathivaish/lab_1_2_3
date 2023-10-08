using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab1secondprogram
{
    internal class Class1
    {
        int[,] arr = new int[3, 4];
        public void fillMat()
        {
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1);)

                    arr[i, j] = i + j;

        }
        public void showMat()
        {
            for(int i=0; i<arr.GetLength(0);i++)
               for(int j=0; j<arr.GetLength(1);)
                {
                    Console.WriteLine(arr[i, j]);
                }
        }
            
        static void Main(string[] args)
        {
            Class1 c=new Class1();

            c.fillMat();
            c.showMat();
            Console.ReadKey();
        }
            
        
    }
}
