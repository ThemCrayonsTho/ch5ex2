using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _ch5ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int monthNumber;
            DisplayInstructions();
            monthNumber = InputMonthNum();
            MonthName firstTest = new MonthName(monthNumber);
            Console.WriteLine(firstTest);
            Console.WriteLine("\n\npress key to start a nother test");
            Console.ReadKey();
            Console.Clear();
            monthNumber = InputMonthNum();
            MonthName secondTest = new MonthName(monthNumber);
            Console.WriteLine(secondTest);
            Console.WriteLine("\n\npress key to start a nother test");
            Console.ReadKey();
            Console.Clear();
            monthNumber = InputMonthNum();
            MonthName thirdTest = new MonthName(monthNumber);
            Console.WriteLine(thirdTest);
            Console.ReadKey();
            Console.Clear();
        }
        public static void DisplayInstructions()
        {
            Console.WriteLine("you will enter the month number and will receive the days in that month and its name");
            Console.ReadKey();
            Console.Clear();
        }
        public static int InputMonthNum()
        {
            int monthNum;
            Console.WriteLine("enter month number");
            monthNum = Console.ReadLine();
            return monthNum;
        }

    }
}
