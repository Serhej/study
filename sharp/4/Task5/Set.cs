using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using static System.Console;

namespace Task5
{
    class Set
    {
        List<int> spisok = new List<int>();

        public int Count { get; set; }

        public Set()
        { Count = 0; }

        public Set(int[] mas) 

        {
            Count = 0;

            for (int i = 0; i < mas.Length; i++)
            {
                spisok.Add(mas[i]);
                Count++;
            }

            IEnumerable<int> distinctSet = spisok.Distinct();
            spisok = distinctSet.ToList();

            foreach (int n in spisok)
            {
                Write(n + " ");
            }
        }

        public void Add(int newElement)

        {
            spisok.Add(newElement); 
            IEnumerable<int> distinctSet = spisok.Distinct(); // создаем новую перемен. типа IEnumerable<int> и 
            //записываем туда полученное множество после применения метода Distinct
            spisok = distinctSet.ToList(); //преобразовываем полученное множество к типу лист
        }

        public void Remove(int newElement)
        {
            spisok.Remove(newElement);
        }

        public void Show()
        {
            foreach (int n in spisok)
            {
                Write(n + " ");
            }
            WriteLine(" ");
        }

        public Set Union(Set b)
        {
            Set setsum = new Set();

            for (int i = 0; i < Count; i++)
            {
                setsum.Add(spisok[i]);             // setsum.Add(this.set[i]);
            }

            for (int i = 0; i < b.Count; i++)
            {
                setsum.Add(b.spisok[i]);
            }
            return setsum;
        }

        public Set Difference(Set b)
        {
            Set setrazn = new Set();

            IEnumerable<int> newname = b.spisok; // создоем новый список newname и записываем в него список b, 
            //котрый преобразуем в тип IEnumerable<int>

            newname = spisok.Except(newname); //происходит разность двух множест и перезапись их в новое множество

            setrazn.spisok = newname.ToList(); //в свойство spisok экземпляра класса set передаем список newname

            return setrazn;
        }

        public Set Intersect(Set b) //пересечение
        {
            Set inter = new Set();

            IEnumerable<int> newname = b.spisok;
            newname = spisok.Intersect(newname);
            inter.spisok = newname.ToList();
            return inter;
           
        }


        public Set SymmetricDifference(Set b)//Симметрическая разность
        {
            Set setsumrazn = new Set();
            IEnumerable<int> sum = spisok.Union(b.spisok);// ОбЪединение
            IEnumerable<int> razn = spisok.Intersect(b.spisok);//Пересечение
            IEnumerable<int> list = sum.Except(razn);//Разность между 1 и 2
            setsumrazn.spisok = list.ToList();//Преобразование в свойство spicok экземпляра setrazn класса set передаем список newname
            return setsumrazn;
        }

        public bool IsSubsetOf(Set b)
        {
            bool res = false;

            foreach (int item in spisok)
            {
                if (b.spisok.Contains(item))
                {
                    res = true;
                }
                else
                {
                    res = false;
                    break;
                }
            }

            if (res == true)
            {
                WriteLine("множество является подмножеством");
            }
            else
                WriteLine("множество не является подмножеством");

            return res;
   
        }
    }
}

