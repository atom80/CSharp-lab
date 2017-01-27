using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayElementInsert {
    class Program {
        static void Main(string[] args) {
            int[] oldArray = new int[10];
            Random rnd = new Random(); // not really random
            Console.WriteLine("Array: ");
            for (int i = 0; i < oldArray.Length; i++) {
                oldArray[i] = rnd.Next(1000);
                Console.Write("{0}:{1} ",i+1, oldArray[i]);
            }
            int index=0;
            do{
            Console.Write("\nIndex to insert after: ");
            index = Convert.ToInt32(Console.ReadLine());
            }
            while ((index<=0)||(index>oldArray.Length));
            int[] newArray = new int[oldArray.Length+1];
            Array.Copy(oldArray,0,newArray,0,index-1);
            newArray[index-1]=7777;
            Array.Copy(oldArray, index-1,newArray,index,oldArray.Length-index+1);

            Console.WriteLine("\nResult: ");
            for(int i=0;i<newArray.Length;i++) Console.Write("{0}:{1} ",i, newArray[i]);

            Console.ReadLine();
        }
    }
}
