using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFApplication.ConsoleApp
{
    public class CalculatorSalary : ICalculateInterest
    {
        public void CalculateInterest(Account account)
        {
            if (account.Type == MyType.Salary )
            {
                // расчет процентной ставк зарплатного аккаунта по правилам банка
                account.Interest = account.Balance * 0.5;
            }
        }
    }

}
