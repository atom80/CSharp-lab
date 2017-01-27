using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_MultuplicationTable {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Table:");
            for (int arg1 = 1; arg1 < 10; arg1++) {
                int coordLeft = (((arg1 - 1) % 3) * 8 + 1);
                for (int arg2 = 1; arg2 < 10; arg2++) {
                    int coordTop = (int)(Math.Ceiling((decimal)arg1 / 3) - 1) * 10 + 1 + arg2;
                    Console.SetCursorPosition(coordLeft, coordTop); // left, top
                    Console.Write("{0}x{1}={2} ", arg1, arg2, arg1 * arg2);
                }
            }
            Console.ReadLine();
        }
    }
}