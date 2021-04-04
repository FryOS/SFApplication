using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFApplication.ConsoleApp
{
    public class CalculatorSimple : ICalculateInterest
    {
        public void CalculateInterest(Account account)
        {
            if (account.Type == MyType.Simple)
            {
                // расчет процентной ставки обычного аккаунта по правилам банка
                account.Interest = account.Balance * 0.4;

                if (account.Balance < 1000)
                    account.Interest -= account.Balance * 0.2;

                if (account.Balance < 50000)
                    account.Interest -= account.Balance * 0.4;
            }
        }
    }
}
