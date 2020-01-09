using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your Birtday date (DD.MM)");

            string str = Console.ReadLine();
            string day = "", month = "";
            int i = 0;
            for (; i < str.Length && str[i] != '.'; i++)
                day += str[i];

            for (int j = i + 1; j < str.Length; j++)
                month += str[j];
            try
            {
                int diff = Date.DayOfYear(DateTime.Now.Year, int.Parse(month), int.Parse(day)) - DateTime.Now.DayOfYear;
                if (diff < 0)
                    diff = DateTime.MaxValue.DayOfYear - DateTime.Now.DayOfYear + Date.DayOfYear(DateTime.Now.Year + 1, int.Parse(month), int.Parse(day));
                Console.WriteLine("Your Birthday will be in " + diff + " days");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
    
    static class Date
    {
        public static int Day { get; set; }
        public static int Month { get; set; }

        public static int DayOfYear(int year, int month, int day)
        {
            int res = 0;
            for (int i = 1; i < month; i++)
                res+=DateTime.DaysInMonth(year, i);
            return res + day;
        }
    }
}
