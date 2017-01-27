using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prorab {

    public abstract class Task : ITask {
        private ILogger vLogger;

        private readonly int vTaskCapacity;
        public int TaskCapacity { get { return vTaskCapacity; } }

        private int vTaskRemaining;
        public int TaskRemaining { get { return vTaskRemaining; } }

        private string vTaskName;
        public string TaskName { get { return vTaskName; } }

        private int vTaskCost;
        public int TaskCost { get { return vTaskCost; } }

        private WorkerSkills vTaskRequiredSkill;
        public WorkerSkills TaskRequiredSkill { get { return vTaskRequiredSkill; } }

        public static implicit operator string(Task from){
            string status;
            if (from == null) { status = "None"; }
            else{
            status=string.Format("Name: {0} Cap: {1}/{2}sz Cost: ${3} Skill: {4}", from.TaskName, from.TaskCapacity,from.TaskRemaining, from.TaskCost,from.TaskRequiredSkill);}
            return status;
        }

        public Task(string taskName, int taskCapacity, int taskCost, WorkerSkills taskRequiredSkill) {
            vTaskName = taskName;
            vTaskCapacity = taskCapacity;
            vTaskRemaining = taskCapacity;
            vTaskCost = taskCost;
            vTaskRequiredSkill = taskRequiredSkill;
        }

        public Task() {
            string[] taskTypes = new string[] { "Task 1", "Task 2", "Task 3", "Task 4", "Task 5", "Task 6", "Task 7", "Task 8", "Task 9", "Task 10" };
            RandomExtension rnd = new RandomExtension();
            vTaskName = taskTypes[rnd.Next(0, taskTypes.Length)];
            vTaskCapacity = rnd.Next(1, 101);
            vTaskRemaining = vTaskCapacity;
            vTaskCost = rnd.Next(10, 200);
            vTaskRequiredSkill = (WorkerSkills)rnd.Next((int)WorkerSkills.Designer, (int)WorkerSkills.Electrician+1);
        }

        public void DoTask(int taskSize) {
            vTaskRemaining -= taskSize;
            vTaskRemaining = (vTaskRemaining > 0) ? vTaskRemaining : 0;
        }


    }
}
