using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter x1: ");
            string x1s = Console.ReadLine();
            Console.Write("Enter y1: ");
            string y1s = Console.ReadLine();
            Console.Write("Enter x2: ");
            string x2s = Console.ReadLine();
            Console.Write("Enter y2: ");
            string y2s = Console.ReadLine();
            Console.WriteLine("Calculating factors for ({0};{1})-({2};{3})", x1s, y1s,x2s,y2s);
            int x1 = Convert.ToInt32(x1s);
            int y1 = Convert.ToInt32(y1s);
            int x2 = Convert.ToInt32(x2s);
            int y2 = Convert.ToInt32(y2s);
            if (x1==x2){
                Console.WriteLine("Can't calculate");
            }else{
            float k = (y1-y2)/(x1-x2);
            float b = y2 - k * x2;
            Console.WriteLine("y={0}x+{1}",k,b);}
            Console.ReadLine();
        }
    }
}
