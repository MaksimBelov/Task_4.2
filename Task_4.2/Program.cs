using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательность целых чисел через Enter (кончанием последовательности служит число 0)");
            int N;
            int number=0;

            do
            {
                Console.Write("Введите число: ");
                N = Convert.ToInt32(Console.ReadLine());
                if (N > 0)
                    number ++;
                else
                    number --;
            } while (N!=0);
            number++;
            if (number < 0)
                Console.WriteLine("Введено больше отрицательных чисел, чем положительных");
            else
                if (number > 0)
                Console.WriteLine("Введено больше положительных чисел, чем отрицательных");
                else
                Console.WriteLine("Введено равное количество положительных и отрицательных чисел");
            Console.ReadLine();
        }
    }
}
