using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFApplication.ConsoleApp
{
    
    // класс Издатель(вызывает события)
    public class SortLastNameReader
    {
        public delegate void LastNameReaderDelegate(int number, string[] arr); //делегат
        public event LastNameReaderDelegate LastNameReaderEvent; //событие, метод обработчика события

        public static string[] SortAZ(string[] array)
        {
            string memory;
            for (int i = 0; i < array.Length; i++)
            {
                for (int k = 0; k < array.Length - 1; k++)
                {
                    if (array[i][0] < array[k][0])
                    {
                        memory = array[k];
                        array[k] = array[i];
                        array[i] = memory;
                    }
                }
            }
            return array;
        }


        public static string[] SortZA(string[] array)
        {
            string memory;
            for (int i = 0; i < array.Length; i++)
            {
                for (int k = 0; k < array.Length - 1; k++)
                {
                    if (array[i][0] > array[k][0])
                    {
                        memory = array[k];
                        array[k] = array[i];
                        array[i] = memory;
                    }
                }
            }
            return array;
        }

        public void Read()
        {
            Console.WriteLine("Введите число 1 или 2");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number != 1 && number != 2) throw new MyExeption();
            string[] names = new string[5];
            Console.WriteLine("Введите имена");
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = Console.ReadLine();
            }
            
            LastNameEntered(number, names);
        }

        protected virtual void LastNameEntered(int number, string[] arr)
        {
            LastNameReaderEvent?.Invoke(number, arr);
        }
    }
}
