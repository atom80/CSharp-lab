using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_Fibonacci {
    class Program {
        static void Main(string[] args) {
            Console.Write("Fibonacci element no: ");
            int elemTo = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int sumPrev = 1;  // 0,1,1,2,3,5,8,13,21,34...
            for (int elemNo = 1; elemNo < elemTo; elemNo++) {
                int sumTmp = sumPrev;
                sumPrev += sum;
                sum = sumTmp;
                Console.WriteLine("{0}: {1} {2}", elemNo, sum, sumPrev);
            }
            Console.WriteLine("{0}th Fibonacci number is {1}", elemTo, sum);
            Console.ReadLine();
        }
    }
}
