using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int t = Convert.ToInt32(Console.ReadLine());
            int i = 65536;
            int num = 0;
            int value = 0;
            while (true)
            {
                if ((n & i) != 0)        
                    Console.Write("1");
                else
                    Console.Write("0");
                if (i == 1)       
                    break;
               
                i >>= 1;
                
                num++;
                if (num == t && (n & i) != 0)
                {
                    value = 1;
                }
                else if (num == t && (n & i) == 0)
                {
                    value = 0;
                }
            }

            Console.WriteLine();
            Console.WriteLine(value);
            Console.ReadKey();
        }
    }
}
