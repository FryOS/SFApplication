using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFApplication.ConsoleApp
{
    public class Account
    {
        public Account(MyType type, double balanse)
        {
            Type = type;
            Balance = balanse;
        }
        // тип учетной записи
        public MyType Type { get; set; }

        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }
    }
}
