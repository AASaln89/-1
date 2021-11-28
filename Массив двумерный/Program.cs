using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Массив_двумерный
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[N,N];
            for (int i = 0; i < N; i++)
            {
                int a=0;
                    if (a==0)
                for (int j = 0; j < N; j++)
                    {
                    Console.Write("0 ", array[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
