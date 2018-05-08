using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            
            int max = 0;
            int[] mas = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int min = mas[0];

            
            Console.WriteLine("В масиве" + string.Join(" ", mas));
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] < min)
                {
                    min = mas[i];
                } else if (mas[i] > max)
                {
                    max = mas[i];
                }
                sum += mas[i];
            }

            Console.WriteLine( $"{sum} {max} {min}");
            Console.ReadKey();

            

        }
    }
}
