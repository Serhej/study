using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conso19
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "C#";
            Random x = new Random();
            
            try
            {
                for (int i = 0; i < 20; i++)
                {          
                    int y1 = x.Next(0, Console.WindowWidth);
                    int x2 = x.Next(0, Console.WindowHeight);

                    Console.SetCursorPosition(y1, x2);

                    Console.WriteLine(str);

                    System.Threading.Thread.Sleep(250);

                    Console.Clear();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("значение аргумента находится вне диапазона допустимых значений");
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (System.Security.SecurityException e)
            {
                Console.WriteLine(e.HelpLink);
            }
        }
    }
}

