using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace task522
{
    class Set<T>
    {
        List<T> spisok = new List<T>();

        public int Count { get; set; }

        public Set()
        { Count = 0; }

        public Set(T[] mas)

        {
            Count = 0;

            for (int i = 0; i < mas.Length; i++)
            {
                spisok.Add(mas[i]);
                Count++;
            }

            IEnumerable<T> distinctSet = spisok.Distinct();
            spisok = distinctSet.ToList();

            foreach (T n in spisok)
            {
                Write(n + " ");
            }
        }


        public static Set<T> operator +(Set<T> a, Set<T> b) // перегрузка оператора +
        {
            Set<T> setsum = a.Union(b);

            return setsum;
        }

        public static Set<T> operator -(Set<T> a, Set<T> b) // перегрузка оператора +
        {
            Set<T> setsum = a.Difference(b);

            return setsum;
        }

        public static Set<T> operator *(Set<T> a, Set<T> b)
        {
            Set<T> setsum = a.Intersect(b);

            return setsum;
        }

        public static Set<T> operator %(Set<T> a, Set<T> b)
        {
            Set<T> setsum = a.SymmetricDifference(b);

            return setsum;
        }

        public void Add(T newElement)

        {
            spisok.Add(newElement);
            IEnumerable<T> distinctSet = spisok.Distinct(); // создаем новую перемен. типа IEnumerable<int> и 
            //записываем туда полученное множество после применения метода Distinct
            spisok = distinctSet.ToList(); //преобразовываем полученное множество к типу лист
        }

        public void Remove(T newElement)
        {
            spisok.Remove(newElement);
        }

        public void Show()
        {
            foreach (T n in spisok)
            {
                Write(n + " ");
            }
            WriteLine(" ");
        }

        public Set<T> Union(Set<T> b)
        {
            Set<T> setsum = new Set<T>();

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

        public Set<T> Difference(Set<T> b)
        {
            Set<T> setrazn = new Set<T>();

            IEnumerable<T> newname = b.spisok; // создоем новый список newname и записываем в него список b, 
            //котрый преобразуем в тип IEnumerable<int>

            newname = spisok.Except(newname); //происходит разность двух множест и перезапись их в новое множество

            setrazn.spisok = newname.ToList(); //в свойство spisok экземпляра класса set передаем список newname

            return setrazn;
        }

        public Set<T> Intersect(Set<T> b) //пересечение
        {
            Set<T> inter = new Set<T>();

            IEnumerable<T> newname = b.spisok;
            newname = spisok.Intersect(newname);
            inter.spisok = newname.ToList();
            return inter;

        }


        public Set<T> SymmetricDifference(Set<T> b)//Симметрическая разность
        {
            Set<T> setsumrazn = new Set<T>();
            IEnumerable<T> sum = spisok.Union(b.spisok);// ОбЪединение
            IEnumerable<T> razn = spisok.Intersect(b.spisok);//Пересечение
            IEnumerable<T> list = sum.Except(razn);//Разность между 1 и 2
            setsumrazn.spisok = list.ToList();//Преобразование в свойство spicok экземпляра setrazn класса set передаем список newname
            return setsumrazn;
        }

        public static bool operator >(Set<T> a, Set<T> b)
        {
            return a.IsSubsetOf(b);

        }


        public static bool operator <(Set<T> a, Set<T> b)
        {
            return b.IsSubsetOf(a);
        }

        public bool IsSubsetOf(Set<T> b)
        {
            bool res = false;

            foreach (T item in spisok)
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




