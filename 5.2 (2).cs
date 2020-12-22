using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[5, 5];
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    a[i, j] = random.Next(100);
                    Console.Write("{0,4}", a[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
