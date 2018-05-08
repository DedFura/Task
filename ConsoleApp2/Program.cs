using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            String chars = "SC";
            var str = new StringBuilder();
            Random random = new Random();
            for (var i=0; i<Console.WindowWidth * Console.WindowHeight; i++)
            {
                var c = chars[random.Next(0, chars.Length)];
                str.Append(c);
            }

            
            
            String myString = str.ToString();
            Console.WriteLine(myString);
            var count = 0;
            foreach (var symbol in myString)
            {

                if (symbol == 'C')
                {
                    count++;
                }

            }

            int ch = Convert.ToInt32(Console.ReadLine());
            if (ch == count)
            {
                Console.WriteLine("Вы правы");
            }
            else
            {
                Console.WriteLine("Повторите попытку");
            }

            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
