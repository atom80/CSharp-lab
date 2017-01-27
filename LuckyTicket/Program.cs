using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTicket {
    class Program {
        static void Main(string[] args) {
            int[,] data = new int[2, 1000];
            int count = 0;
            for (int s = 0; s < 10; s++)
                for (int d = 0; d < 10; d++)
                    for (int e = 0; e < 10; e++) {
                        data[0, e + 10 * d + 100 * s] = e + d + s;
                        data[1, e + 10 * d + 100 * s] = 0;
                    }
            for (int i = 0; i < data.GetLength(1); i++)
                for (int j = 0; j < data.GetLength(1); j++) {
                    if ((data[0, i]) == (data[0, j])) {
                        count += 1;
                        data[1, i] = data[0, j];
                    }
                }
            Console.WriteLine("Found {0} lucky tickets", count);
            Console.ReadLine();
        }
    }
}
