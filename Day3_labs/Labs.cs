using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassTriangle;

namespace Day3_labs {
    public enum TriangleTypeBySides {
        Isosceles,   // равнобедренный (две одинаковые стороны)
        Equilateral, // равносторонний (все стороны равны)
        Scalene      // разносторонний все стороны разные
    };
    public enum TriangleTypeByAngles {
        Right,    // прямоугольный (один угол = 90)
        Obtuse,   // тупоугольный (один угол > 90)
        Acute     // остроугольный (все углы < 90)
    }
    public struct TriangleType {
        public TriangleTypeBySides sideType;
        public TriangleTypeByAngles angleType;
    }
    public class Labs {
        private int ConvertUserInput(string userInput) {
            return Convert.ToInt32(userInput);
        }

        public bool IsSimple(int value) {
            bool isSimple = false;
            for (int i = 1; i < value; i++) if (value % i == 0) { isSimple = true; break; }
            return isSimple;
        }

        public TriangleType GetTriangleType(int sideA, int sideB, int sideC) {
            TriangleType triangleType;
            triangleType.sideType = TriangleTypeBySides.Scalene; // разносторонний
            triangleType.angleType = TriangleTypeByAngles.Acute; // остроугольный
            bool eqAB = sideA == sideB;
            bool eqAC = sideA == sideC;
            bool eqBC = sideB == sideC;
            if (eqAB && eqAC && eqBC)
                triangleType.sideType = TriangleTypeBySides.Equilateral;
            else if ((eqAB && eqAC) || (eqAB && eqBC) || (eqAC && eqBC))
                triangleType.sideType = TriangleTypeBySides.Isosceles;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            Angles triangleAngles = triangle.GetAngles();
            if ((triangleAngles.alpha == 90) || (triangleAngles.beta == 90) || (triangleAngles.gamma == 90))
                triangleType.angleType = TriangleTypeByAngles.Right;
            else if ((triangleAngles.alpha > 90) || (triangleAngles.beta > 90) || (triangleAngles.gamma > 90))
                triangleType.angleType = TriangleTypeByAngles.Obtuse;
            return triangleType;
        }

        public int GetCharCount(int value) {
            int count = 0;
            double val = value;
            do {
                val = val / 10;
                count++;
            } while (Math.Truncate(val) != 0);
            return count;
        }

        public string ToBinary(int value) {
            string binary = String.Empty;
            int remainder;
            int count = 0;
            while (value > 0) {
                count++;
                remainder = value % 2;
                value /= 2;
                binary = remainder.ToString() + binary;
                if((count%4==0)&&(value>0)) binary='`'+binary;
            }
            return binary;
        }
    }
}
