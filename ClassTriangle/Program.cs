using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTriangle {
    class Program {
        static void Main(string[] args) {
            Console.Write("Select input method(1-coordinates; 2-sides):");
            int inputMethod = Convert.ToInt32(Console.ReadLine());
            Triangle triangle;
            switch (inputMethod) {
                case 1: // coords
                Console.Write("Coordinates(xA,yA,xB,yB,xC,yC)");
                string userInput = Console.ReadLine();
                string[] strInput = userInput.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                coordPoint A, B, C;
                A.X = Convert.ToInt32(strInput[0]);
                A.Y = Convert.ToInt32(strInput[1]);
                B.X = Convert.ToInt32(strInput[2]);
                B.Y = Convert.ToInt32(strInput[3]);
                C.X = Convert.ToInt32(strInput[4]);
                C.Y = Convert.ToInt32(strInput[5]);
                triangle = new Triangle(A, B, C);
                break;

                case 2: // sides
                Console.Write("Side A:");
                double sideA = Convert.ToDouble(Console.ReadLine());
                Console.Write("Side B:");
                double sideB = Convert.ToDouble(Console.ReadLine());
                Console.Write("Side C:");
                double sideC = Convert.ToDouble(Console.ReadLine());
                triangle = new Triangle(sideA, sideB, sideC);
                break;

                default:
                triangle = new Triangle(0,0,0);
                break;
            }

            if (!triangle.GetExists()) {
                Console.WriteLine("Triangle doesn't exist!");
            } else {
                Console.WriteLine("Perimeter = {0}", triangle.GetPerimeter());
                Console.WriteLine("Area = {0}", triangle.GetArea());
                Angles angles = triangle.GetAngles();
                Console.WriteLine("Alpha: {0}",angles.alpha);
                Console.WriteLine("Beta: {0}", angles.beta);
                Console.WriteLine("Gamma: {0}", angles.gamma);

            }
            Console.ReadLine();
        }
    }
}
