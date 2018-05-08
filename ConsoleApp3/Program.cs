using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Random rand = new Random();
            int x = 25;
            int y = 0;
            int platformSize = 10;
            int platformX = rand.Next(5, 35);
            ConsoleKeyInfo currentKey = new ConsoleKeyInfo();
            Task.Factory.StartNew(() =>
            {
                while (true)
                    currentKey = Console.ReadKey(false);
            });
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(platformX, 10);
                Console.WriteLine("__________");

                Console.SetCursorPosition(x,y);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write('#');
                if (currentKey.Key == ConsoleKey.RightArrow)
                {
                    x++;
                    currentKey = new ConsoleKeyInfo();
                }
                else if (currentKey.Key == ConsoleKey.LeftArrow)
                {
                    x--;
                    currentKey = new ConsoleKeyInfo();
                }

                y++;
                if (y == 11)
                {
                    Console.SetCursorPosition(0,11);
                    if(x>= platformX && x  <= platformX + platformSize)
                    {
                        Console.WriteLine("Вы спасены!");
                    }
                    else
                    {
                        Console.WriteLine("Вы погибли");
                    }
                    break;

                }
                System.Threading.Thread.Sleep(200);
                Console.Clear();
            }

            Console.ReadLine();
            
            
        
            Console.ReadKey();
        }
    }
}
