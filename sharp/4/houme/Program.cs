using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace houme
{
    // Методы для работы с массивом
    // Все методы возвращают void и принимают массив
    static class ArrayUtils
    {
        // Обобщённый метод для вывода массива на консоль
        public static void ShowArray<T>(T[] arr)
        {
            Console.Write("Array:  ");
            // С помощью метода Join класса string
            // Массив преобразовывается в строку с добавлением запятых между элементами
            Console.WriteLine(string.Join(", ", arr));
        }

        // Метод для вывода максимального элемента массива
        public static void ShowMax(int[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("Array is empty");
            }
            int max = arr[0];
            for (int i = 1; i < arr.Length; ++i)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Max value in the array is {0}", max);
        }

        // Метод для вывода минимального элемента массива
        public static void ShowMin(int[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("Array is empty");
                return;
            }
            int min = arr[0];
            for (int i = 1; i < arr.Length; ++i)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Min value in the array is {0}", min);
        }

        // Метод для вывода среднего значения элементов массива
        public static void ShowAvg(int[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("Array is empty");
                return;
            }
            int sum = 0;
            for (int i = 0; i < arr.Length; ++i)
            {
                sum += arr[i];
            }
            float avg = (float)sum / arr.Length;
            Console.WriteLine("Average value in the array is {0}", avg);
        }

        // Метод для вывода нормализованного массива
        // *Нормализованный - все элементы редуцированы до значений -1, 0 и 1
        public static void ShowNormalize(int[] arr)
        {
            int[] tmpArr = new int[arr.Length];
            arr.CopyTo(tmpArr, 0);
            for (int i = 0; i < tmpArr.Length; ++i)
            {
                // Вс положительные элементы
                if (tmpArr[i] > 0)
                {
                    // Заменяются на 1
                    tmpArr[i] = 1;
                }
                // Все отрицательные элементы
                else if (tmpArr[i] < 0)
                {
                    // Заменяются на -1
                    tmpArr[i] = -1;
                }
            }
            Console.Write("Normalize array:  ");
            Console.WriteLine(string.Join(", ", tmpArr));
        }
    }

    // Объявлен тип делегата для вышеописанных методов
    delegate void MultiDelegate(int[] array);

    class Program
    {
        static void Main(string[] args)
        {
            // Создаётся массив
            int[] array1 = { -2, 17, 23, 6, -5, 14, 0, -11, -2 };

            // Создаётся делегат, в него записывается метод ShowArray
            // *Конкретный тип для обобщённого метода определяется автоматически
            // На основании типов делегата
            MultiDelegate multigate = ArrayUtils.ShowArray;
            // А затем к делегату добавляются другие методы
            multigate += ArrayUtils.ShowAvg;
            // В том порядке, в котором они добавляются
            multigate += ArrayUtils.ShowMax;
            // Они и будут вызываться
            multigate += ArrayUtils.ShowMin;
            multigate += ArrayUtils.ShowNormalize;

            // Вызов делегата запускает цепочку вызовов
            // Всех записанных в него методов
            multigate(array1);
            Console.WriteLine();

            // Из делегата удаляются некоторые методы
            multigate -= ArrayUtils.ShowMin;
            multigate -= ArrayUtils.ShowMax;
            multigate -= ArrayUtils.ShowAvg;

            // Делегат вызывается снова
            // Теперь будут выполнены лишь оставшиеся методы
            multigate(array1);

        }
    }
}
