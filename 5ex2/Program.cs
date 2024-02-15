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

        }
        public static char InputMonthNum()
        {
            string inValue;
            char monthNum;
            Console.WriteLine("enter month number");
            inValue = Console.ReadLine();
            monthNum = Convert.ToChar(inValue);
            return monthNum;
        }
}
