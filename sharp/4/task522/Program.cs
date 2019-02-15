using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using Cons3;

namespace task522
{

        class Program
    {
        static void Main(string[] args)
        {
            Set<int> set1 = new Set<int>(new int[] { 3, 4, 7, 2, -3 });
            WriteLine("   ");

            WriteLine("   ");
            Set<int> set2 = new Set<int>(new int[] { 6, 3, 1, -3, 8, 13, 2 });
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
            Set<int> set7 = new Set<int>(new int[] { 1, 2, 6 });
            WriteLine(" ");
            Set<int> set8 = new Set<int>(new int[] { 3, 5, 8, 4 });
            WriteLine(" ");
            Set<int> set9 = new Set<int>(new int[] { 3, 4, 5, 6, 7, 8 });
            WriteLine(" ");

            if (set9 > set7)
                WriteLine("нет");            if (set8 > set9)
                WriteLine("Да");


            //s8.IsSubsetOf(s9);
            //s7.IsSubsetOf(s9);
            //s7.IsSubsetOf(s8);
            //WriteLine(" ");


            Set<string> set10 = new Set<string>(new string[] { "Help", "me", "Hello" });
            WriteLine("   ");

            WriteLine("   ");
            Set<string> set11 = new Set<string>(new string[] { "Help", "me", "Hello OO" });
            WriteLine("   ");

            WriteLine("Union set1 + set2: ");
            Set<string> set12 = set10.Union(set11); // a.UnionWith(b);  объединение
            set12.Show();
            Set<string> set13 = set10 + set11;
            set12.Show();


            Set<Knopka> knopki = new Set<Knopka>(new Knopka[] { new Knopka("R"), new Knopka("T"), new Knopka("Q") });
            Set<Knopka> knopki2 = new Set<Knopka>(new Knopka[] { new Knopka("Z"), new Knopka("X"), new Knopka("Q") });

            WriteLine("Difference knopki - knopki2: "); // разность
            Set<Knopka> set55 = knopki.Difference(knopki2);
            set55.Show();
            Set<Knopka> set56 = knopki - knopki2;
            set56.Show();
            WriteLine(" ");
            Console.WriteLine(knopki.Equals(knopki2)); // true

        }
    }
}
