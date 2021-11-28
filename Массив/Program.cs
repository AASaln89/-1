using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Массив
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7];
            array[0] = Convert.ToInt32(Console.ReadLine());
            array[1] = Convert.ToInt32(Console.ReadLine());
            array[2] = Convert.ToInt32(Console.ReadLine());
            array[3] = Convert.ToInt32(Console.ReadLine());
            array[4] = Convert.ToInt32(Console.ReadLine());
            array[5] = Convert.ToInt32(Console.ReadLine());
            array[6] = Convert.ToInt32(Console.ReadLine());
            float sSum = 0;
            Console.WriteLine("Значения массива");
            for (int i = 0; i <7; i++)
            {
                sSum += array[i];
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Среднее значение = {0}", sSum/7);
            Console.ReadKey();
        }
    }
}
