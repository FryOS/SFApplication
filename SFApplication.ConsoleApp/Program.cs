using System;

namespace SFApplication.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = GetArrayFromConsole();
            //arr = SortArray(arr);
            //WriteArray(arr);
            

            int myage = 11;

            Console.WriteLine(myage);
            ChangeAge(ref myage);
            Console.WriteLine(myage);
            Console.ReadKey();


        }

        static int[] GetArrayFromConsole(ref int range)
        {
            var result = new int[range];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }

        static int[] SortArray(int[] array)
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
            return array;
        }

        static void WriteArray(int[] arr)
        {
            Console.WriteLine("Ваши числа");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
        }

        static void ChangeAge(ref int age)
        {
            Console.WriteLine("Введите возраст");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(age);
        }

       
       // int SumNumbers(ref int num1, in int num2, out int num3, int num4)

    }
}
