using SFApplication.ConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            var account = new Account(MyType.Simple, 2) ;
            var account1 = new Account(MyType.Salary, 2);
            var simpelSal = new CalculatorSimple();
            var salarySal = new CalculatorSalary();


            var result = new CalculationResult(account);
            var result1 = new CalculationResult(account1);
            var simpleResult = result.Result(simpelSal);
            var salaryResult = result1.Result(salarySal);


            Console.WriteLine(simpleResult);
            Console.WriteLine(salaryResult);

            Console.ReadKey();
        }



        #region Старый Calculator
        //public static class Calculator
        //{
        //    // Метод для расчета процентной ставки
        //    public static void CalculateInterest(Account account)
        //    {
        //        if (account.Type == "Обычный")
        //        {
        //            // расчет процентной ставки обычного аккаунта по правилам банка
        //            account.Interest = account.Balance * 0.4;

        //            if (account.Balance < 1000)
        //                account.Interest -= account.Balance * 0.2;

        //            if (account.Balance < 50000)
        //                account.Interest -= account.Balance * 0.4;
        //        }
        //        else if (account.Type == "Зарплатный")
        //        {
        //            // расчет процентной ставк зарплатного аккаунта по правилам банка
        //            account.Interest = account.Balance * 0.5;
        //        }
        //    }
        //}
        #endregion

    }
}

