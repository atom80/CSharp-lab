using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMatrixElemUnderDiag {
    class Program {
        static void Main(string[] args) {
            int[,] dataMatrix = new int[10, 10];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++) {
                    dataMatrix[i, j] = rnd.Next(100,999);
                    Console.SetCursorPosition(4*i,j);//top left
                    Console.Write("{0} ",dataMatrix[i,j]);
                }
            int minElem = 1000;
            for (int i = 0; i < 10; i++)
                for (int j = 9; j >= i; j--)
                    minElem = (minElem < dataMatrix[i, j]) ? minElem : dataMatrix[i, j];
            Console.WriteLine("\nMin: {0}",minElem);
                    Console.ReadLine();

        }
    }
}
