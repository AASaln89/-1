using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smin_max
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            int N = 15;
            int[] array = new int[N];
            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                array[i] = random. Next(0, 15);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            int Max = array[0];
            int Min = array[0];
            int Sum = 0;
            #endregion
            foreach (int a in array)
            {
                if (a > Max)
                    Max = a;
            }
            foreach (int b in array)
            {
                if (b < Min)
                    Min = b;
            }
            Console.WriteLine("Сумма Макс и Мин = {0}",Min+Max);
            Console.ReadKey();
        }
    }
}
