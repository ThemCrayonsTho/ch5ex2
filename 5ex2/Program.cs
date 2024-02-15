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
            DisplayInstructions();
            InputMonthNum();
        }
        public static void DisplayInstructions()
        {
            Console.WriteLine("you will enter the month number and will receive the days in that month and its name");
            Console.ReadKey();
            Console.Clear();
        }
        public static string InputMonthNum()
        {
            string monthNum;
            Console.WriteLine("enter month number");
            monthNum = Console.ReadLine();
            return monthNum;
        }
    }
}
