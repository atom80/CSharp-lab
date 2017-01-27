using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prorab {
    public enum OrderStates {
        Unassigned,
        InProgress,
        Finished
    }
    public class Order:IStatus {
        private ILogger vLogger;
        private OrderStates vOrderState = OrderStates.Unassigned;
        public OrderStates OrderState { get { return vOrderState; } set { vOrderState = value; } }
        public string ID { get { return string.Format("[Order] {0}",vOrderName); } }
        private Queue<ITask> vTaskQueue = new Queue<ITask>();

        public ITask[] OrderTasks { get { return vTaskQueue.ToArray(); } }

        public ITask CurrentTask{ get { return vTaskQueue.Peek();} }

        private string vOrderName = "";
        public string OrderName { get { return vOrderName;} }

        //public static implicit operator string(Order from) { 
        //    if (from==null){ return "None";}
        //    else {
        //        string tasks="";
        //        foreach(ITask task in from.Tasks){
        //            tasks+=string.Format("\r\n({0})",(string)(Task)task);
        //        }
        //        string status=string.Format("Name: {0} Tasks({1}): ({2})",from.OrderName,from.Tasks.Length,tasks);
        //        return status;
        //    }
        //}

        public string GetStatus() {
            string tasks = "";
            foreach (ITask task in OrderTasks) {
                tasks += string.Format("\r\n({0})", (string)(Task)task);
            }
            string status = string.Format("Tasks({0}): ({1})", OrderTasks.Length, tasks);
            return status;
        }

        public Order(string orderName, ILogger logger) {
            vOrderName = orderName;
            vLogger = logger;
            RandomExtension rnd = new RandomExtension();
            int taskCount=rnd.Next(3,10);
            for(int i=0;i<taskCount;i++){
                TaskBuild task = new TaskBuild();
                this.vTaskQueue.Enqueue(task);
            }
            logger.DoLog(this, GetStatus(),"NEW ORDER");
        }
        
        public void AddTask(ITask newTask) {
            vTaskQueue.Enqueue(newTask);
        }

        public void CloseTask() {
            vLogger.DoLog(this,(string)(Task)CurrentTask,"TASK CLOSED");
            vTaskQueue.Dequeue();
        }

    }
}
