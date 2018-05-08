using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    class Program
    {
        static void Main(string[] args)
        {
            var elements = new byte[4,4];
            var elementsA = new byte[4];
            var elementsB = new byte[4];
            Random rand;
            rand = new Random();
            for (var i = 0; i < 4; i++)
            {
                for (var j=0; j < 4; j++)
                {
                    elements[i, j] = (byte)rand.Next(1, 255);
                    Console.Write("{0,4}", elements[i, j]);
                }
                Console.WriteLine();
            }

            var k = 0;
            for (var i = 0; i < 4; i++)
            {
                for (var j = 3; j >= 0; j--)
                {
                    if (i == j)
                    {
                        elementsA[k] = elements[i, j];
                        Console.Write($"{elementsA[k]}");
                        Console.WriteLine();
                        k++;
                    }
                }
            }
            var g = 0;
            for (var i = 0; i < 4; i++)
            {
                for (var j = 3; j >= 0; j--)
                {
                    if (i + j == 3)
                    {
                        elementsB[g] = elements[i, j];
                        Console.Write($"{elementsB[g]}");
                        Console.WriteLine();
                        k++;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
