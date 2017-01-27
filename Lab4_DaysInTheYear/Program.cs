using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_DaysInTheYear {
    class Program {
        static void Main(string[] args) {
            Console.Write("Year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            int yearDays = 0;
            if ((0 == (year % 400)) || ((0 == (year % 4)) && (0 != (year % 100))))
                yearDays = 366;
            else
                yearDays = 365;
            Console.WriteLine("{0} days",yearDays);
            Console.ReadLine();
        }
    }
}
