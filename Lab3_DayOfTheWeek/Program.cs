using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_DayOfTheWeek {
    class Program {
        static void Main(string[] args) {
            Console.Write("Day of the year: ");
            int dayOfYear = Convert.ToInt32(Console.ReadLine());
            int dayOfWeek = (dayOfYear % 7);
            string dow = "";
            switch (dayOfWeek){
                case 0:dow="Sun";break;
                case 1:dow="Mo"; break;
                case 2:dow="Tue"; break;
                case 3:dow="Wed"; break;
                case 4:dow="Thu"; break;
                case 5:dow="Fri"; break;
                case 6:dow="Sat"; break;
            }
            Console.WriteLine("It's {0}!", dow);
            Console.ReadLine();
        }
    }
}
