using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Average {
    class Program {
        static void Main(string[] args) {
            Console.Write("Number 1: ");
            double v1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Number 2: ");
            double v2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Number 3: ");
            double v3 = Convert.ToDouble(Console.ReadLine());
            if ((v1==v2)||(v1==v3)||(v2==v3)){
                Console.WriteLine("Error");
            }else{
              
            Console.WriteLine("Average: {0}", Convert.ToDouble((v1 + v2 + v3)/3) );}
            Console.ReadLine();
        }
    }
}
