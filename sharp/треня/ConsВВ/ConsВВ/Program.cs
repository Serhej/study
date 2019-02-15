using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsВВ
{
    public interface ITransformer
    {
        int Transform(int x);
    }

    class Util
    {
        public static void Trans(int[] values, ITransformer t)
        {
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = t.Transform(values[i]);
            }
        }

    }
    
    class Squarer:ITransformer
    {
        public int Transform(int x) => x * x;
    }

    class Program
    {
        

        static void Main(string[] args)
        {


            int[] mas = { 1, 2, 3, 4 };
            Util.Trans(mas,new Squarer());
            foreach (int item in mas)
            {
                Console.WriteLine(item + " ");
            }
            
        }

        
    }
}
