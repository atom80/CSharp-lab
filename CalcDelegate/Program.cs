using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcDelegate {

    class Calc {
        public void Task(Op op) {
            Console.Write("Args: ");
            string[] userInput = Console.ReadLine().Split(',');
            int op1 = Convert.ToInt32(userInput[0]);
            int op2 = Convert.ToInt32(userInput[1]);
            Console.WriteLine("Result: {0}", op(op1, op2));
        }
        public int Sum(int op1, int op2) { return op1 + op2; }
        public int Mul(int op1, int op2) { return op1 * op2; }
        public int Minus(int op1, int op2) { return op1 - op2; }
    }

    public delegate int Op(int op1, int op2);
    class Program {
        static void Main(string[] args) {
            Op op = null;
            Calc calc = new Calc();
            int opCode = 0;
            do {
                Console.Write("Op(1-plus, 2-mul, 3-minus, 0-exit): ");
                opCode = Convert.ToInt32(Console.ReadLine());
                switch (opCode) {
                    case 0: {
                        op = null;
                    }
                    break;
                    case 1: { op = calc.Sum; }
                    break;
                    case 2: { op = calc.Mul; }
                    break;
                    case 3: { op = calc.Minus; }
                    break;
                    default:
                    break;
                }
                if (op != null) {
                    calc.Task(op);
                }

            } while (opCode != 0);
        }
    }
}




