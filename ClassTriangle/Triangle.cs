using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTriangle {
    public struct coordPoint {
        public int X;
        public int Y;
    }
    public struct Angles {
        public double alpha;
        public double beta;
        public double gamma;
        public Angles(double alpha, double beta, double gamma) {
            this.alpha = alpha;
            this.beta = beta;
            this.gamma = gamma;
        }
    }
   public class Triangle {
        private double sideA;
        private double sideB;
        private double sideC;
        private bool exists=false;

        public bool GetExists() { return this.exists; }

        private void SetExists(){
            bool tmpExists=this.sideA+this.sideB>=this.sideC;
            tmpExists=tmpExists&&((this.sideA+this.sideC)>=this.sideB);
            tmpExists=tmpExists&&((this.sideB+this.sideC)>=this.sideA);
            this.exists=tmpExists;
        }

        private void SetSides(double sideA, double sideB, double sideC) {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
            this.SetExists();
        }


        public Triangle(double sideA, double sideB, double sideC) {
            this.SetSides(sideA,sideB,sideC);
        }

        public Triangle(coordPoint coordA, coordPoint coordB, coordPoint coordC) {
            double sideA = Math.Sqrt(Math.Pow((coordB.X-coordA.X),2)+Math.Pow((coordB.Y-coordA.Y),2));
            double sideB = Math.Sqrt(Math.Pow((coordC.X - coordB.X), 2) + Math.Pow((coordC.Y - coordB.Y), 2));
            double sideC = Math.Sqrt(Math.Pow((coordA.X - coordC.X), 2) + Math.Pow((coordA.Y - coordC.Y), 2));
            this.SetSides(sideA, sideB, sideC);
        }

        public double GetPerimeter() {
            double perimeter = 0;
            if (this.exists){
                perimeter = sideA + sideB + sideC;
            }
            return perimeter;
        }

        public double GetArea() {
            double area = 0;
            if (this.exists) { 
                double p=this.GetPerimeter()/2;
                area = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
            }
            return area;
        }

        public Angles GetAngles(){
            Angles angles = new Angles(0,0,0);
            if (this.exists) {
                const double factor = 180 / Math.PI;
                double alpha = factor * Math.Acos(((Math.Pow(this.sideB, 2)) + (Math.Pow(this.sideC, 2)) - (Math.Pow(this.sideA, 2))) / (2 * this.sideB * this.sideC));
                double beta = factor * Math.Acos(((Math.Pow(this.sideA, 2)) + (Math.Pow(this.sideC, 2)) - (Math.Pow(this.sideB, 2))) / (2 * this.sideA * this.sideC));
                double gamma = 180 - (alpha + beta);
                angles.alpha = alpha;
                angles.beta = beta;
                angles.gamma = gamma;
            }
            return angles;
        }
    }

}