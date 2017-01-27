using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_MaxOfThree {
    class Program {
        static void Main(string[] args) {
            Console.Write("Number 1: ");
            int numOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 2: ");
            int numTwo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 3: ");
            int numThree = Convert.ToInt32(Console.ReadLine());
            int result = (numOne > numTwo) ? numOne : numTwo;
            result = (result > numThree) ? result : numThree;
            Console.WriteLine("Max is {0}",result.ToString());
            Console.ReadLine();
        }
    }
}
