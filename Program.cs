using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4._2._2
{
    class Program
    {
            static void Main(string[] args)
            {
                Console.WriteLine("Введите последовательность положительных и отрицательных чисел");
                int X, Y;
                X = Y = 0;
                int N;
                do
                {
                    N = Convert.ToInt32(Console.Read());
                    if (N > 0)
                    {
                        X++;
                    }
                    else
                    {
                        Y++;
                    }
                } while (N != 0);
                Console.WriteLine("Количество положительных чисел - {0}, количество отрицательных - {1}", X, Y);
                Console.ReadKey();
            }
    }
}
