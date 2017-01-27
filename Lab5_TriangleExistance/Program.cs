using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_TriangleExistance {
    class Program {
        static void Main(string[] args) {
            Console.Write("Triangle side 1: ");
            int trSide1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Triangle side 2: ");
            int trSide2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Triangle side 3: ");
            int trSide3 = Convert.ToInt32(Console.ReadLine());
            bool trExists = (trSide1+trSide2>trSide3)&&(trSide1+trSide3>trSide2)&&(trSide2+trSide3>trSide2);
            if  (trExists) Console.WriteLine("Triangle exists");
            else Console.WriteLine("Triangle doesn't exist");
            Console.ReadLine();
        }
    }
}
