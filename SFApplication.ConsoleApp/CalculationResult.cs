using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFApplication.ConsoleApp
{
    public class CalculationResult
    {
        private readonly Account _account;

        public CalculationResult(Account account)
        {
            _account = account;
        }
        public string Result(ICalculateInterest calculateInterest)
        {
            calculateInterest.CalculateInterest(_account);
            return _account.Interest.ToString();
        }
    }

}
