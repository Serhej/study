using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Con1
{

    //public static string Met(string[]mass)
    //{
    //    return 0;
    //}

    class Program
    {
        static void Main(string[] args)
        {

            string str =  "Мария" ;
            var res = str.Select(c => new { @Char = c, Code = (int)c, Count = str.Where(ch => ch == c).Count()})
                .Distinct().Sum(s => Math.Pow(s.Code, s.Count)) % 8;

            //foreach (var item in res)
            //{
            //    WriteLine($"{item.Char}-{item.Code}-{item.Count}");
            //}

            WriteLine(res);


            ////Met(mass);
            //int count = 0;
            //string str1;

            //for(int i = 0; i < 5; i++)
            //{
            //    for(int y = 1; y < 6; y++)
            //    {
                    
            //        if(str[i] == str[y])
            //        {

            //        }
            //    }
            //    Console.WriteLine( (int)str[i]);
            //}
            


        }
    }
}
