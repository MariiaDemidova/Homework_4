using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N=");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int Y = N / N; Y <= N; Y++)
            {
                int x = 0;
                for (int j = 1; j <= Y; j++)
                {
                    x += (2 * j - 1);
                }
                Console.WriteLine("{0}", x);
            }
            Console.ReadKey();
        }
    }
}
