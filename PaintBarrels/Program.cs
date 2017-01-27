using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintBarrels {
    class Program {
        static void Main(string[] args) {
            const int paintVolume = 3;
            Console.Write("Diameter,m: ");
            int barrelDiameter = Convert.ToInt32(Console.ReadLine());
            Console.Write("Height,m: ");
            int barrelHeight = Convert.ToInt32(Console.ReadLine());
            Console.Write("Paint consumption,l/m2: ");
            int paintConsumption = Convert.ToInt32(Console.ReadLine());
            double paintConsPerBarrel = Math.PI * barrelDiameter * barrelHeight * paintConsumption; // side area
            paintConsPerBarrel += paintConsumption*Math.PI * Math.Pow(barrelDiameter / 2, 2); //top area
            double result = Math.Ceiling(paintConsPerBarrel / paintVolume);
            Console.WriteLine("You need {0} barrels of paint",result.ToString());
            Console.ReadLine();
             }
    }
}
