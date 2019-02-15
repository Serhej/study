using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console17
{
    
    class Program
    {


        private static bool Check_el(int el, int[] arr )
        {
          
            for (int i = 0; i < arr.Length; i++)
            {
                
                if (arr[i] == el)
                {
                    
                    return true;
                    break;
                }
                
            }
            return false;
        }

        public static int[] Met(int[] mass, params int[] args)
        {
            //bool[] check_mas = new bool[mass.Length];
            //int countm = 0, count_res_mas= mass.Length;
            //foreach(int m in mass)
            //{
            //    foreach(int pm in args)
            //    {
            //        if (m == pm)
            //        {
            //            check_mas[countm] = false;
            //            count_res_mas--;
            //            continue;
            //        }else
            //        {
            //            check_mas[countm] = true;
                        
            //        }
            //    }
            //    countm++;
            //}
            //int[] res_m = new int[count_res_mas];
            //countm = 0;
            //for(int n = 0; n < mass.Length; ++n)
            //{
            //    if (check_mas[n])
            //    {
            //        res_m[countm] = mass[i];
            //        countm++;
            //    }
            //}

            int count = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (!Check_el(mass[i], args))
                    count++;
            }
            int[] res = new int[count];
            count = 0;

            for (int i = 0; i < mass.Length; i++)
            {
                if (!Check_el(mass[i], args))
                {
                    res[count] = mass[i];
                    count++;
                }
                    
            }
            return res;
        }

        static void Main(string[] args)
        {
            int[] mass = { 4, 5, 6, 7, 8,54,2,7,9,5,36 };
            int[] mass2 = { 4,54,36, 8, 9 };
           

            foreach (int element in Met(mass, mass2))
            {
                Console.Write(element+"  ");
            }
            Console.WriteLine();
        }
    }
}

