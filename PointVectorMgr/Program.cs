using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointVectorMgr {
    class Program {
        static void Main(string[] args) {
            Manager mgr = new Manager();
            Console.WriteLine("Array manager");
            int action = 0;
            do {
                Console.Write("\nAction(1-list, 2-new, 3-add, 4-is zero? 0-quit): ");
                action = Convert.ToInt32(Console.ReadLine());
                switch (action) {
                    case 1: {
                        for (int i = 0; i < mgr.ElemCount; i++) {
                            Console.WriteLine("{0}: {1}", i, (string)mgr[i]);
                        }
                    }
                    break;
                    case 2: {
                        Console.Write("New(x1,x2,y1,y2): ");
                        string[] userCoords = Console.ReadLine().Split(new Char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        mgr.AddVector(int.Parse(userCoords[0]), Convert.ToInt32(userCoords[1]), int.Parse(userCoords[2]), Convert.ToInt32(userCoords[3]));
                    }
                    break;
                    case 3: { 
                        Console.Write("Vector indexes to add: ");
                        string[] indexes = Console.ReadLine().Split(',');
                        int ix1=Convert.ToInt32(indexes[0]);
                        int ix2=Convert.ToInt32(indexes[1]); 
                        Console.WriteLine("\nResult: {0}",(string)(mgr[ix1]+mgr[ix2]));
                    }
                    break;
                    case 4: {
                        Console.Write("Index to check: ");
                        int ix=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("{0}",(bool)mgr[ix]);
                    }
                    break;
                    default:
                    break;
                }

            } while (action != 0);
        }
    }
}
