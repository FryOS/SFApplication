using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account  = new Account() { Type = "Обычный", Balance = 2 };
            var simpelSal = new CalculatorSimple();
            var salarySal = new CalculatorSalary();
            

            var result = new CalculationResult();
            result.Result(simpelSal.CalculateInterest(account));
            result.Result(salarySal);

            Console.ReadKey();
        }

        public class Account
        {
            // тип учетной записи
            public string Type { get; set; }

            // баланс учетной записи
            public double Balance { get; set; }

            // процентная ставка
            public double Interest { get; set; }
        }

        #region Старый Calculator
        public static class Calculator
        {
            // Метод для расчета процентной ставки
            public static void CalculateInterest(Account account)
            {
                if (account.Type == "Обычный")
                {
                    // расчет процентной ставки обычного аккаунта по правилам банка
                    account.Interest = account.Balance * 0.4;

                    if (account.Balance < 1000)
                        account.Interest -= account.Balance * 0.2;

                    if (account.Balance < 50000)
                        account.Interest -= account.Balance * 0.4;
                }
                else if (account.Type == "Зарплатный")
                {
                    // расчет процентной ставк зарплатного аккаунта по правилам банка
                    account.Interest = account.Balance * 0.5;
                }
            }
        }
        #endregion

        public interface ICalculateInterest
        {
            void CalculateInterest(Account account);
        }

        public class CalculatorSimple : ICalculateInterest
        {
            public void CalculateInterest(Account account)
            {
                if (account.Type == "Обычный")
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

        public class CalculatorSalary : ICalculateInterest
        {
            public void CalculateInterest(Account account)
            {
                if (account.Type == "Зарплатный")
                {
                    // расчет процентной ставк зарплатного аккаунта по правилам банка
                    account.Interest = account.Balance * 0.5;
                }
            }
        }

        public class CalculationResult
        {
            Account account { get; set; }
            public string Result(ICalculateInterest calculateInterest)
            {
                calculateInterest.CalculateInterest(account);
                return account.Interest.ToString();
            }
        }
    }
}

