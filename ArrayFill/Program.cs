using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayFill {
    class Program {
        static void Main(string[] args) {
            const int matrixLen = 10;
            int[,] matrix = new int[matrixLen, matrixLen];
            for (int i = 0; i < matrixLen; i++) {
                for (int j = 0; j < matrixLen; j++) {
                    if (i == j)
                        //if (i <= j)
                        //if ((i<=5)&&(j<=i))
                        matrix[i, j] = 1;
                    else
                        matrix[i, j] = 0;
                    Console.SetCursorPosition(j, i);// left top
                    Console.Write(matrix[i, j]);
                }
            }
            Console.ReadLine();
        }
    }
}
