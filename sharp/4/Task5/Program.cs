using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task5
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

            //WriteLine("Add : ");
            //set1.Add(8);
            //set1.Show();

            //WriteLine("Remove  : ");
            //set2.Remove(3);
            //set2.Remove(1);
            //set2.Show();

            
            WriteLine("Union set1 + set2: ");
            Set set3 = set1.Union(set2); // a.UnionWith(b);  объединение

            set3.Show();

            WriteLine("Difference: "); // разность
            Set set5 = set1.Difference(set2);
            set5.Show();
            //s5 = { 4, 7 }

            WriteLine("Intersect: "); // разность
            Set set4 = set1.Intersect(set2);
            set4.Show();

            WriteLine("SD: ");
            Set set6 = set1.SymmetricDifference(set2);
            set6.Show();


            WriteLine(" ");
            Set s7 = new Set(new int[] { 1, 2, 6 });
            WriteLine(" ");
            Set s8 = new Set(new int[] { 3, 5, 8, 4 });
            WriteLine(" ");
            Set s9 = new Set(new int[] { 3, 4, 5, 6, 7, 8 });
            WriteLine(" ");
            s8.IsSubsetOf(s9);
            s7.IsSubsetOf(s9);
            s7.IsSubsetOf(s8);
            WriteLine(" ");
        }
    }
}
