using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consol1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] mass = { 4, 2, 6, 4, 5, 3, 7, 6, 4, 9 };
                       
            int[] mass3 = new int[10];  //копия начального массива
            for(int i = 0; i < mass.Length; i++)
            {
                mass3[i] = mass[i];
            }

            int temp;

            for (int i = 0; i < mass.Length - 1; i++) // сортировка массива по возрастанию
            {
                for (int j = i + 1; j < mass.Length; j++)
                {
                    if (mass[i] > mass[j])
                    {
                        temp = mass[i];
                        mass[i] = mass[j];
                        mass[j] = temp;
                    }
                }
            }

            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine(mass[i]);
            }
            
            int[] mass2 = new int[10];
           
            for (int i = 0; i < mass.Length; i++)  //i элемент массива + i минимальный элемент массива
            {
                mass2[i] = mass[i] + mass3[i];
            }
            
            for (int i = 0; i < mass.Length; i++)  //вывод массива на экран
            {
                Console.WriteLine(mass2[i]);
            }


            //Task5();
            //Task4();
            //Task2();
            //Task1();
        }

        static void Task5()
        {
            int count = 0;
            int numOfErrors = 0;
            Random rnd = new Random();
            // получаем массив значений элементов из которых состоит перечисление ConsoleKey  
            var keys = Enum.GetValues(typeof(ConsoleKey));  //ConsoleKey - клавиши консоли

            do
            {
                // получаем случайное значение клавиши консоли типа object из массива keys
                var key = keys.GetValue(rnd.Next(0, keys.Length));
                int tmpKey = (int)key; // приводим к типу int для более простой проверки
                if (tmpKey > 123 || (tmpKey > 90 && tmpKey < 96) || (tmpKey < 48)) // если не соответствует условию
                    continue;   // то переходим на следующую итерацию цикла
                Console.WriteLine($"Нажмите клавишу: {key}");
                ConsoleKeyInfo pressedKey = Console.ReadKey(true); // читаем(набираем) клавишу консоли

                if (pressedKey.Key == (ConsoleKey)key) // если клавиши(которую нужно ввести и которую мы ввели) совпадают
                {
                    ++count;
                    if (count == 20)
                    {
                        Console.WriteLine("Вы справились с задачей!!!!!");
                        break;
                    }
                }
                else // если нет
                {
                    count = 0;
                    ++numOfErrors;
                    if (numOfErrors == 3)
                    {
                        Console.WriteLine("Слишком много ошибок - это конец!!!!!");
                        break;
                    }

                }
            } while (true);
        }


        static void Task4()
        {
            string str = "C#";
            Random x = new Random();

            for (int i = 0; i < 20; i++)

            {
                int y1 = x.Next(0, Console.WindowWidth);
                int x2 = x.Next(0, Console.WindowHeight);

                Console.SetCursorPosition(y1, x2);

                Console.WriteLine(str);

                System.Threading.Thread.Sleep(250);

                Console.Clear();

            }
        }

        static void Task2()
        {

            string kam, hoz, bum, komp;
            int moj = 0;
            string name = "Game: \"Камень - ножницы - бумага\" (1 - камень, 2 - нажницы, 3 - бумага)";
            Console.WriteLine(name);
            Console.WriteLine("Введите свое значение: ");
            char moj2 = (char)Console.Read();
            moj = Convert.ToInt32(moj2.ToString());
            Console.WriteLine();

            Random rnd = new Random();
            int value = rnd.Next(1, 3);
            Console.WriteLine(value);

            if (moj == value)
                Console.WriteLine("Ничья");
            else if (moj > value && value != 2 && moj != 2)
                Console.WriteLine("Победа");
            else if (moj > value && value != 1)
                Console.WriteLine("Поражение");
            else if (moj > value && moj != 3 && value != 2 && value != 3)
                Console.WriteLine("Поражение");
            else if (moj < value && moj != 1)
                Console.WriteLine("Победа");
            else if (moj < value && moj != 3 && moj != 2)
                Console.WriteLine("Поражение");
            else
                Console.WriteLine("Победа");

        }


        static void Task1()
        {
            string str = "Я буду усердно делать все задания по C# и заниматься дома";
            Console.WriteLine("Введите: " + str);
            string str1 = Console.ReadLine();

            if (String.CompareOrdinal(str, str1) != 0)

                Console.WriteLine("Строки s1 и s2 не равны");

            else
                Console.WriteLine("За это ты получишь печеньку");
        }

        
    }
}

/*
static int Factorial(int n) // Факториал
{
    if (n == 0)
    {
        return 1;
    }
    else
    {
        return n * Factorial(n - 1);
    }
}




static void Method3()  //1.3
{
    decimal sum1 = 0;
    decimal sum2 = 0;

    Console.Write("Введите число n: ");

    int n = Int32.Parse(Console.ReadLine());

    if (n >= 0)
    {
        for (int i = 0; i <= n; i++)
        {
            if (i <= 20)
            {
                sum1 = sum1 + (1.0m / Factorial(i));
            }
            if (i != 0)
            {
                //sum2 = sum2 + (decimal)( i % 2 == 0 ? 1 : -1) / (decimal)(2 * i + 1);
                sum2 = sum2 + (decimal)(Math.Pow(-1, i)) / (decimal)(2 * i + 1);
            }
            else
            {
                sum2 = sum2 + (decimal)Math.Pow(-1, i) / 1.0m;
            }
        }
        sum2 = sum2 * 4;

        Console.WriteLine(sum1);
        Console.WriteLine(sum2);

    }
    else
    {
        Console.WriteLine("Было введено отрицательное число!");
    }


    Console.Write("Нажмите кнопку x для выхода из программы...");
    Console.ReadKey();


