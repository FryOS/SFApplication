using System;

namespace SFApplication.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = GetArrayFromConsole();
            SortArray(arr);
            WriteArray(arr);
            Console.ReadKey();
        }

        static int[] GetArrayFromConsole()
        {
            var result = new int[5];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }

        static void SortArray(int[] array)
        {
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int u = 0; u < array.Length; u++)
                {
                    if (array[i] < array[u])
                    {
                        temp = array[i];
                        array[i] = array[u];
                        array[u] = temp;
                    }
                }
            }
        }

        static void WriteArray(int[] arr)
        {
            Console.WriteLine("Ваши числа");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
        }
    }
}
