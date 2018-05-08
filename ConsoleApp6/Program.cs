using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int N = Convert.ToInt32(Console.ReadLine());
            byte [ , ] mas = new byte[N,N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    mas[i, j] = (byte)rand.Next(1, 255);
                    Console.Write($"{i}{j}");
                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
