using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Quadrant {
    class Program {
        static void Main(string[] args) {
            Console.Write("x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            byte quadrant = 0;
            string axisLocation = "", axisSign="";
            if ((x > 0) && (y > 0))
                quadrant = 1;
            else if ((x > 0) && (y < 0))
                quadrant = 4;
            else if ((x < 0) && (y > 0))
                quadrant = 2;
            else if ((x < 0) && (y < 0))
                quadrant = 3;
            else {
                if (x == 0)
                    axisLocation = "X-axis";
                else
                    axisLocation = "Y-axis"; 
                if ((x<0)||(y<0)) axisSign="Negative";
                else axisSign="Positive";
            };
            if (quadrant > 0)
                Console.WriteLine("Quadrant: {0}", quadrant);
            else {
                Console.WriteLine("{0} {1}",axisSign,axisLocation);
            }
            Console.ReadLine();
        }
    }
}
