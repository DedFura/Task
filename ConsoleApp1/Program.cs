using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            var size = rand.Next(2, 10);
            var elementsA = new int[size,size];
            for (var i = 0; i < size; i++)
            {
                for (var j = 0; j < size; j++)
                {
                    elementsA[i, j] = (byte)rand.Next(1, 255);
                    Console.Write("{0,4}", elementsA[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
