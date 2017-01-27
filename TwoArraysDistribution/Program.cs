using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoArraysDistribution {
    class Program {
        static void Main(string[] args) {
            Console.Write("Array A size: ");
            int arraySizeA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Array B size: ");
            int arraySizeB = Convert.ToInt32(Console.ReadLine());
            int[] arrayA = new int[arraySizeA];
            int[] arrayB = new int[arraySizeB];
            Random rnd = new Random(1000);
            Console.WriteLine("\nArray A:");
            for (int i = 0; i < arrayA.Length; i++) {
                arrayA[i] = rnd.Next(1000);
                Console.Write("{0} ", arrayA[i]);
            }
            Console.WriteLine("\nArray B:");
            for (int i = 0; i < arrayB.Length; i++) {
                arrayB[i] = rnd.Next(1000);
                Console.Write("{0} ", arrayB[i]);
            }
            int[] arrayTmp = new int[arrayA.Length + arrayB.Length];
            arrayA.CopyTo(arrayTmp, 0);
            arrayB.CopyTo(arrayTmp, arrayA.Length);

            Array.Sort(arrayTmp);
            Console.WriteLine("\nTemporary array: ");
            for (int i = 0; i < arrayTmp.Length; i++)
                Console.Write("{0} ", arrayTmp[i]);
            Array.Copy(arrayTmp,0,arrayA,0,arrayA.Length);
            Array.Copy(arrayTmp, arrayA.Length, arrayB, 0, arrayB.Length);

            Console.WriteLine("\nArray A:");
            for(int i=0;i<arrayA.Length;i++) Console.Write("{0} ",arrayA[i]);
            Console.WriteLine("\nArray B:");
            for(int i=0;i<arrayB.Length;i++) Console.Write("{0} ",arrayB[i]);

            Console.ReadLine();
        }
    }
}
