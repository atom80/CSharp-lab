using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prorab {
    public enum WorkerSkills {
        Designer = 0,
        Builder = 1,
        Plumber = 2,
        Electrician = 3
    }

    public class Worker : Employee, IWorker {
        private ILogger vLogger;

        private WorkerState vWorkerState;
        public WorkerState WorkerState { get { return vWorkerState; } }

        private WorkerSkills vWorkerSkill;
        public WorkerSkills WorkerSkill { get { return vWorkerSkill; } }

        private int vWorkerVelocity;
        public int WorkerVelocity { get { return vWorkerVelocity; } }

        //private int vWorkerSalary;
        //public int WorkerSalary { get { return vWorkerSalary; } }

        private ITask vCurrentTask;
        public ITask CurrentTask { get { return vCurrentTask; } }

        public Worker(string workerName, WorkerSkills workerSkill, int workerVelocity, int workerSalary, ILogger Logger)
            : base(workerName, EmployeeTypes.Worker,workerSalary) {
            vWorkerSkill = workerSkill;
            vWorkerState = WorkerState.Idle;
            vWorkerVelocity = workerVelocity;
//            vWorkerSalary = workerSalary;
            vLogger = Logger;
            vLogger.DoLog(this, GetStatus(), "NEW WORKER");
        }

        public bool AssignTask(ITask newTask) {
            bool result = false;
            if ((newTask.TaskRequiredSkill == this.vWorkerSkill) && (vCurrentTask == null)) {
                this.vCurrentTask = newTask;
                this.vWorkerState = WorkerState.Working;
                result = true;
            }

            return result;
        }

        public override void DoWork() {
            if (vCurrentTask == null) {
                vWorkerState = WorkerState.Idle;
                return;
            }

            vCurrentTask.DoTask(this.vWorkerVelocity);

            if (vCurrentTask.TaskRemaining <= 0) {
                vWorkerState = WorkerState.Idle;
                vCurrentTask = null;
                //TODO: Thow event "DONE"
            } else {
                vWorkerState = WorkerState.Working;
            }
        }

        public override string GetStatus() {
            string status = "";
            status += string.Format(" State: {0}", vWorkerState);
            status += string.Format(" Skill: {0}", vWorkerSkill);
            status += string.Format(" Velocity: {0}", vWorkerVelocity);
            status += string.Format(" Task: ({0})", (string)(Task)vCurrentTask);
            return status;
        }
    }
}
