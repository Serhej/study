using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static (int v, int b, double n) MinPol(int[] mass)
        {
            var perem = (v: 0, b: 0, n: 0.0);
            
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] > 0)
                {
                    perem.v = mass[i];
                    break;
                }
            }

            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] < 0)
                {
                    perem.b = mass[i];
                    break;
                }
            }

            int count = 0;
            int sum = 0;
            double sred = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] > 0)
                {
                    sum += mass[i];
                    count++;
                }
            }

            sred = (double)sum / count;
            perem.n = sred;
            return perem;
        }


        static void Main(string[] args)
        {
            int[] mass = { 4, 8, -2, 7, -5, 3, 4 };
            foreach (int u in mass)
            {
                Console.Write(u + " ");
            }
            Console.WriteLine();

            Array.Sort(mass);

            foreach (int f in mass)
            {
                Console.Write(f + " ");
            }
            Console.WriteLine();

            var tuple = MinPol(mass);
            Console.WriteLine("Минимальный положительный " + tuple.v);
            Console.WriteLine("Максимальный отрицательный " + tuple.b);
            Console.WriteLine("Среднее положительное " + tuple.n);
        }
    }
}

