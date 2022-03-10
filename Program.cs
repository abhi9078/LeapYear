using System;

namespace LeapYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Leap Year Problem ");
            Console.WriteLine("Enter year to check: ");
            int year=int.Parse(Console.ReadLine());
            bool isleapyear=Program.isLeapYear(year);
            if (isleapyear)
            {
                Console.WriteLine("Leap Year");
            }
            else
            {
                Console.WriteLine("Not a LeapYear");
            }
        }
        public static bool isLeapYear(int year)
        {
            if ((year%400==0) || (year%100!=0 && year % 4 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
