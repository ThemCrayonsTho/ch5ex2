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
            InputMonthNum();
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
