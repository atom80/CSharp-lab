using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeIndex {
    class Program {
        static void Main(string[] args) {
            int[] array = new int[20];
            Random rnd = new Random();
            Console.WriteLine("Array: ");
            for (int i = 0; i < array.Length; i++) {
                array[i] = rnd.Next(1000);
                Console.Write("{0} ", array[i]);
            }
            Console.Write("\nRange: ");
            string userInput = Console.ReadLine();
            string[] rangeText = userInput.Split(new Char[] { ' ', '-', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);
            //foreach (string range in rangeText)
            //    Console.WriteLine("{0}", range);
            int rangeFrom = Convert.ToInt32(rangeText[0]);
            int rangeTo = Convert.ToInt32(rangeText[1]);
            int rangeMax = (rangeFrom > rangeTo) ? rangeFrom : rangeTo;
            int rangeMin = (rangeFrom < rangeTo) ? rangeFrom : rangeTo;

            Console.WriteLine("\nValues from {0} to {1}:", rangeMin, rangeMax);

            for (int i = 0; i < array.Length; i++) if ((array[i] >= rangeMin) && (array[i] <= rangeMax))
                    Console.Write("[{0}]={1} ", i,array[i]);
            Console.ReadLine();
        }
    }
}
