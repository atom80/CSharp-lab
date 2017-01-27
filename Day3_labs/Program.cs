using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_labs {
    class Program {
        static void Main(string[] args) {
            Labs labs = new Labs();
            Console.WriteLine("Day3\n");

            Console.WriteLine("Routine number:");
            Console.WriteLine("\t1 - Simple or not simple number");
            Console.WriteLine("\t2 - Triangle type by given sides");
            Console.WriteLine("\t3 - Number of characters in a given value");
            Console.WriteLine("\t4 - Convert from DEC into BIN");
            int value;

            switch (int.Parse(Console.ReadLine())) {
                case 1:
                // Number 2
                Console.Write("Number: ");
                value = Convert.ToInt32(Console.ReadLine());
                if (labs.IsSimple(value))
                    Console.WriteLine("{0} is simple", value);
                else
                    Console.WriteLine("{0} is not simple", value);

                break;
                case 2:
                // Number 3
                Console.Write("Side A:");
                int sideA = Convert.ToInt32(Console.ReadLine());
                Console.Write("Side B:");
                int sideB = Convert.ToInt32(Console.ReadLine());
                Console.Write("Side C:");
                int sideC = Convert.ToInt32(Console.ReadLine());
                TriangleType trType = labs.GetTriangleType(sideA, sideB, sideC);
                Console.WriteLine("\nTriangle is {0} and {1}", trType.sideType, trType.angleType);

                break;
                case 3:
                // Number 4
                Console.Write("\nValue: ");
                value = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("{0} consists of {1} characters", value, labs.GetCharCount(value));


                break;
                case 4:
                //Number 5
                Console.Write("\nValue: ");
                value = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("{0}(DEC) = {1}(BIN)", value, labs.ToBinary(value));

                break;
                default:
                break;
            }

            Console.ReadLine();
        }
    }
}
