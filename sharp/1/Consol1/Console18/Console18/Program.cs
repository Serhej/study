using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console18
{
    class Program
    {
        static void MinPol(int[]mass, out int v, out int b, out double n)
        {
            v = b = 0;
            n = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] > 0)
                {
                    v = mass[i];
                    break;
                }
            }

            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] < 0)
                {
                    b = mass[i];
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
            n = sred;
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

            int v, b;
            double n;
            MinPol(mass, out v, out b, out n);
            Console.WriteLine("Минимальный положительный " + v);
            Console.WriteLine("Максимальный отрицательный " + b);
            Console.WriteLine("Среднее положительное " + n);
        }
    }
}