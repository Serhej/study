using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Set set1 = new Set(new int[] { 3, 4, 7, 2, -3 });
            WriteLine("   ");

            WriteLine("   ");
            Set set2 = new Set(new int[] { 6, 3, 1, -3, 8, 13, 2 });
            WriteLine("   ");


            //WriteLine("Union set1 + set2: ");
            ////Set set3 = set1.Union(set2); // a.UnionWith(b);  объединение
            //Set set3 = set1 + set2;

            //set3.Show();

            //WriteLine("Difference set1 - set2: "); // разность
            ////Set set5 = set1.Difference(set2);
            //Set set5 = set1 - set2;
            //set5.Show();
           

            //WriteLine("Intersect set1 * set2: "); // разность
            ////Set set4 = set1.Intersect(set2);
            //Set set4 = set1 * set2;
            //set4.Show();

            //WriteLine("SD set1 % set2: ");
            ////Set set6 = set1.SymmetricDifference(set2);
            //Set set6 = set1 % set2;
            //set6.Show();


            //WriteLine(" ");
            Set set7 = new Set(new int[] { 1, 2, 6 });
            WriteLine(" ");
            Set set8 = new Set(new int[] { 3, 5, 8, 4 });
            WriteLine(" ");
            Set set9 = new Set(new int[] { 3, 4, 5, 6, 7, 8 });
            WriteLine(" ");

            if(set9 > set7)
                WriteLine("нет");            if(set8 > set9)
                WriteLine("Да");

            //s8.IsSubsetOf(s9);
            //s7.IsSubsetOf(s9);
            //s7.IsSubsetOf(s8);
            //WriteLine(" ");
        }
    }
}
