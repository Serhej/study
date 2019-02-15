using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexsator
{
    class Program
    {
        class MyClass
        {
            private string[] key = new string[5];
            private string[] value = new string[5];

            public MyClass()
            {
                key[0] = "book"; value[0] = "книга";
                key[1] = "pen"; value[1] = "rucka";
                key[2] = "sun"; value[2] = "solnce";
                key[3] = "apple"; value[3] = "jabloko";
                key[4] = "table"; value[4] = "stol";
            }

            public string this[string index]
            {
                get
                {
                    for (int i = 0; i < key.Length; i++)
                    
                        if (key[i] == index)
                            return key[i] + " - " + value[i];

                        return string.Format($"{index} - Het dannogo slowa");
                    
                }
            }
        }

        static void Main(string[] args)
        {

        }
    }
}
