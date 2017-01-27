using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadFibonacci {
    class Program {
        static void DoFibonacci() {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            int elemTo = rnd.Next(1,100);
            Console.WriteLine("Task {0} started execution(Fibonacci({1}))", Task.CurrentId,elemTo);
            Decimal sum = 0;
            Decimal sumPrev = 1;  // 0,1,1,2,3,5,8,13,21,34...
            for (int elemNo = 1; elemNo < elemTo; elemNo++) {
                Decimal sumTmp = sumPrev;
                sumPrev += sum;
                sum = sumTmp;
                if (elemNo % 10 == 0) {
                    Console.WriteLine("[Task {0}]: {1} {2}", Task.CurrentId, elemNo, sum);
                }
                Thread.Sleep(200);
            }
            Console.WriteLine("Task {0} ended execution", Task.CurrentId);
        }

        static void Main(string[] args) {
            int vThreadCount = 5;
            List<Task> taskList=new List<Task>();
            Task vTask;
            for (int i = 0; i < vThreadCount; i++) {
                vTask=new Task(DoFibonacci);
                taskList.Add(vTask);
                vTask.Start();
            }

            List<int> completedIds = new List<int>();
            bool allDone=true;
            int tick = 0;
            int tickDelay = 100;
            do{
                tick++;
                allDone = true;
                foreach (Task task in taskList) {
                    allDone&=task.IsCompleted;
                    if ((task.IsCompleted) && (!completedIds.Contains(task.Id))) {
                        Console.WriteLine("Task {0} completed @ {1}!", task.Id, tick);
                        completedIds.Add(task.Id);
                    }
                }
                Thread.Sleep(tickDelay);
            }while (!allDone);

            Console.Write("\nDone!");
            Console.ReadLine();
        }
    }
}
