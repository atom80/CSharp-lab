using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prorab {
    public enum WorkerState {
        Idle,
        Working
    }
    public interface IWorker {
        ITask CurrentTask{get;}
        WorkerState WorkerState { get; }
        WorkerSkills WorkerSkill {get;}
        int WorkerVelocity{get;} // size of work per step
       // int WorkerSalary { get; }
        bool AssignTask(ITask newTask);
         void DoWork();
    }
}
