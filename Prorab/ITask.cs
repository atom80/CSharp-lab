using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prorab {
    public interface ITask {
        WorkerSkills TaskRequiredSkill{get;}
        int TaskCapacity{get;} // task size to do
        int TaskRemaining { get; }
        string TaskName { get; }
        int TaskCost { get; }
        void DoTask(int taskSize);
        //void CloseTask();
    }
}
