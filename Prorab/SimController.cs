using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prorab {
    public class SimController:IStatus {
        //public List<Employee> Employees {
        //    get {
        //        List<Employee> empList=new List<Employee>();
        //        empList.Add(vProrab);
        //        empList.AddRange(vProrab.Employees.ToList());
        //        return empList;
        //    }
        //}
        public string ID { get { return "Program"; } }
        RandomExtension rnd = new RandomExtension();
        private ILogger vLogger = null;
        private Prorab vProrab = null;
        public Prorab Prorab { get { return vProrab; } }
        public int currentStep = 0;
        private int vOrderNo = 0;
        private List<Order> vOrderList = new List<Order>();
        public Order[] OrderList { get { return vOrderList.ToArray(); } }
        public SimController(ILogger logger) {
            vLogger = logger;
            //vProrab = new Prorab("Mihalych", 500, 50,logger);
            //vProrab.AddWorker(new Worker("Ravshan", WorkerSkills.Builder, 5, 50, vLogger));
            //vProrab.AddWorker(new Worker("Dzhamshut", WorkerSkills.Builder, 8, 80,vLogger));
            //vProrab.AddWorker(new Worker("Vasiliy", WorkerSkills.Electrician, 10, 100,vLogger));
            //vProrab.AddWorker(new Worker("Pedro", WorkerSkills.Plumber, 10, 100, vLogger));
            //vProrab.AddWorker(new Worker("George", WorkerSkills.Designer, 10, 100, vLogger));
        }

        public void AddProrab(string prorabName, int initBalance, int salary){
            vProrab = new Prorab(prorabName, initBalance, salary,vLogger);
        }

        public void DoStep() {
            currentStep++;
            vLogger.DoLog(this, string.Format("[Step {0}]: =================================================================================================",currentStep));

            //TODO: Generate new order
            if ((rnd.Next(0, 100) < (20 * (currentStep % 5))) || (vProrab.Orders.Length == 0)) {
                Order newOrder = new Order((string.Format("Order #{0}", vOrderNo++)), vLogger);
                vOrderList.Add(newOrder);
                vProrab.AssignOrder(newOrder);
            }

            vProrab.DoWork();

            if (currentStep % 10 == 0) { // end of "month"
                PaySalary();
            }

            vLogger.DoLog(vProrab, vProrab.GetStatus());

            for (int i = 0; i < vProrab.WorkerCount; i++) {
                Worker worker = (Worker)vProrab[EmployeeTypes.Worker, i];
                vLogger.DoLog(worker,worker.GetStatus());
            }

        }

        public void PaySalary() {
            //foreach (Employee emp in Employees) { }
            vProrab.PaySalary();
        }

        public string GetStatus() {
            return "";
        }

    }
}
