using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharArray {
    class Program {
        static void Main(string[] args) 
        
        {
            char[,] charArray = new char[10, 10];
            int[,] usedChars = new int[2, 100];
            int usedIndex = 0;
            int newVal = 0;
            Random rnd = new Random();
            Console.WriteLine("Array: ");
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++) {
                    newVal = rnd.Next(65, 90);
                    charArray[i, j] = (char)newVal;
                    usedIndex = newVal - 65; // cheat
                    usedChars[0, usedIndex] = newVal;
                    usedChars[1, usedIndex] = usedChars[1, usedIndex] + 1;
                    Console.SetCursorPosition(i * 2, j);
                    Console.Write("{0} ", charArray[i, j]);
                }

            Console.WriteLine("\nUsed characters:");
            int count = 0;
            for (int i = 0; i < 100; i++) {
                if (usedChars[1, i] != 0) {
                    Console.Write("'{0}': {1} ", (char)usedChars[0, i], usedChars[1, i]);
                    count++;
                    if ((count % 5) == 0)
                        Console.Write("\n");
                }
            }
            Console.ReadLine();
        }
    }
}
