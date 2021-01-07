using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFApplication.ConsoleApp
{
    class Obj
    {
        public string Name;
        public string Description;
        public static int MaxValue = 2000;
    }

    class Helper
    {
        static void Swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }

    class Obj1
    {
        public string Name;
        public string Description;

        public static string Parent;
        public static int DaysInWeek;
        public static int MaxValue;

        static Obj1()
        {
            Parent = "System";
            DaysInWeek = 7;
            MaxValue = 2000;
        }
    }

    static class IntExtension
    {
        public static int GetNegative(this int num)
        {
            if (num > 0)
                return num*=-1;
            else
            {
                return num;
            }
        }

        public static int GetPositive(this int num)
        {
            if (num < 0)
                return num = num * -1 ;
            else
            {
                return num;
            }
        }
    } 
}
