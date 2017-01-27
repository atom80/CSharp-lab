using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prorab {
    public enum EmployeeTypes { Prorab, Worker, Unknown };
    abstract public class Employee : IStatus {
        private EmployeeTypes vEmployeeType = EmployeeTypes.Unknown;
        public EmployeeTypes EmployeeType { get { return vEmployeeType; } }

        private int vEmployeeSalary;
        public int EmployeeSalary { get { return vEmployeeSalary; } }

        protected string vEmployeeName = "";
        public string EmployeeName { get { return vEmployeeName; } }
        public string ID { get { return string.Format("{0} {1}", vEmployeeType, vEmployeeName); } }

        //public static implicit operator string(Employee from) {
        //    return string.Format("[{0}] {1}",from.vPersonType,from.vName);
        //}

        public Employee() { vEmployeeName = "Employee"; vEmployeeType = EmployeeTypes.Unknown; vEmployeeSalary = 0; }

        public Employee(string employeeName, EmployeeTypes employeeType, int employeeSalary) { 
            vEmployeeName = employeeName; 
            vEmployeeType = employeeType;
            vEmployeeSalary = employeeSalary;
        }

        public virtual void DoWork() {

        }

        public virtual string GetStatus() {
            return "";
        }
    }
}
