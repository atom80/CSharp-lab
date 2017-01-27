using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prorab {
    public class TaskArgs : EventArgs {
        public Order Order { get; set; }
        public ITask Task { get; set; }
    }

    public class Prorab : Employee {
        public event Action<object, TaskArgs> CloseTask;
        private ILogger vLogger;
        private List<Order> vOrders = new List<Order>();
        public Order[] Orders { get { return vOrders.ToArray(); } }

        protected List<IWorker> vWorkers = new List<IWorker>();
        public IWorker[] Workers { get { return vWorkers.ToArray(); } }
        //public Employee[] Employees { get { return vWorkers.ToArray<Employee>() ; } }

        public IWorker this[EmployeeTypes personTypes, int index] {
            get {
                IWorker result = null;
                switch (personTypes) {
                    case EmployeeTypes.Worker: { result = vWorkers[index]; }
                    break;
                    default:
                    break;
                }
                return vWorkers[index];
            }
        }

        public int WorkerCount { get { return vWorkers.Count; } }

        int vBalance = 1000;        // initial fund, $
        public int Balance { get { return vBalance; } }

        public Prorab(string name, int initialBalance, int salary, ILogger logger)
            : base(name, EmployeeTypes.Prorab, salary) {
            vBalance = initialBalance;
            vLogger = logger;
            vLogger.DoLog(this, GetStatus(), "NEW PRORAB");
        }

        public override string GetStatus() {
            string status = base.GetStatus();
            status += string.Format(" Balance: ${0}", vBalance);
            string orders = "";
            foreach (Order order in vOrders) {
                orders += string.Format("\r\n({0}): {1}", order.ID, order.GetStatus());
            }
            status += string.Format(" Orders({0}): {1}", vOrders.Count, orders);
            return status;
        }

        public bool AssignOrder(Order order) {
            bool accept = false;
            if (vOrders.Count == 5) {
                vLogger.DoLog(this, " Order declined - I'm full!");
                return false;
            } // maximum 5 orders per prorab! 
            ITask task = order.CurrentTask;
            accept = AssignTask(task);
            if (accept) {
                vOrders.Add(order);
                order.OrderState = OrderStates.InProgress;
                vLogger.DoLog(this, " Order assigned");
            } else {
                vLogger.DoLog(this, " Order declined - all workers are busy!");
            }
            return accept;
        }

        public bool AssignTask(ITask task) {
            bool accept = false;
            int taskSize = task.TaskCapacity;
            for (int i = 0; i < vWorkers.Count; i++) {
                if (vWorkers[i].AssignTask(task)) {
                    accept = true;
                    taskSize -= vWorkers[i].WorkerVelocity;
                    if (taskSize < task.TaskCapacity / 2) { break; }
                }
            }
            return accept;
        }

        public void AddWorker(IWorker newWorker) {
            vWorkers.Add(newWorker);
        }

        public override void DoWork() {
            for (int i = 0; i < vWorkers.Count; i++) {
                vWorkers[i].DoWork();
            }

            // Close finished tasks and orders
            ITask task;
            if (vOrders.Count > 0) {
                Order order;
                for (int i = 0; i < vOrders.Count; i++) {
                    //foreach (Order order in vOrders) {
                    order = vOrders[i];
                    task = order.CurrentTask;
                    if ((task != null) && (task.TaskRemaining <= 0)) {
                        vBalance += task.TaskCost;
                        order.CloseTask();
                        if (CloseTask != null) {
                            CloseTask(this, new TaskArgs() { Task = task, Order = order });
                        }
                    }
                    if (order.OrderTasks.Length == 0) {
                        order.OrderState = OrderStates.Finished;
                        vOrders.Remove(order);
                    }
                }

                // Assign tasks
                for (int i = 0; i < vOrders.Count; i++) {
                    //foreach (Order order in vOrders) {
                    task = vOrders[i].CurrentTask;
                    if (task != null) {
                        AssignTask(task);
                    }
                }
            }
        }


        public void PaySalary() {
            int totalSalary = 0;
            foreach (IWorker worker in vWorkers) {
                totalSalary += (worker as Employee).EmployeeSalary;
            }
            vBalance -= totalSalary;
            vBalance -= this.EmployeeSalary;
            vLogger.DoLog(this, string.Format("${0}", totalSalary), "SALARY PAID");
        }
    }
}
