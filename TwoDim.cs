using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDim
{
    internal class Program
    {

        int[,] arr = new int[3, 4];
        public void fillMat()
        {
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1);j++)

                    arr[i, j] = i + j;

        }
        public void showMat()
        {
            for (int i = 0; i < arr.GetLength(0); i++) { 
                for (int j = 0; j < arr.GetLength(1);j++)
                
                    Console.WriteLine(arr[i,j]+" ");
                    Console.WriteLine();
            }
            
        }

        static void Main(string[] args)
        {
            Program c = new Program();

            c.fillMat();
            c.showMat();
            Console.ReadKey();
        }
    }
}
