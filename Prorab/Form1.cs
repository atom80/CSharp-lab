using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prorab {
    public partial class Form1 : Form {
        private SimController controller = null;
        private bool vIsRunning = false;
        private bool vIsFirstRun = true;
        Logger vLogger;
        private void UpdateGUI() {
            int prorabBalance = 0;
            int ordersInProgress = 0;
            int ordersDeclined = 0;


            if (controller.Prorab != null) {
                prorabBalance = controller.Prorab.Balance;
                ordersInProgress = controller.Prorab.Orders.Length;
                for (int i=0;i<controller.OrderList.Length;i++){
                    if (controller.OrderList[i].OrderState==OrderStates.Unassigned){ordersDeclined++;}
                }
            }
            labelCurrentBalance.Text = string.Format("Balance: ${0}", prorabBalance);
            labelCurrentOrders.Text = string.Format("Orders in progress: {0}", ordersInProgress);
            labelOrdersDeclined.Text = string.Format("Orders declined: {0}", ordersDeclined);
        }

        public Form1() {
            InitializeComponent();
            vLogger = new Logger(DoLogMessage);
            controller = new SimController(vLogger);
            UpdateGUI();
            //dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "message" });
        }

        public void DoLogMessage(string msgText){
            textBox1.AppendText(msgText);
            //MessageBox.Show(msgText);
            
            //dataGridView1.Rows.Add(msgText);
            //dataSet1.Tables[0].DataSet.
        }

        public void DoCloseTask(object sender, TaskArgs e) {
            //vLogger.DoLog((IStatus)sender, "DoCloseTask", "EVENT");
            dataGridView1.Rows.Add(e.Order.OrderName, e.Order.OrderState,e.Task.TaskName, e.Task.TaskRequiredSkill,e.Task.TaskCost,e.Task.TaskCapacity);
            

            string evText = string.Format("{0}.{1}", e.Order.ID, (string)(Task)e.Task);
            vLogger.DoLog(null, evText, "EVENT CLOSE TASK");
        }

        private void button1_Click(object sender, EventArgs e) {
            if (vIsFirstRun) {
                vIsFirstRun = false;
                controller.AddProrab(textBoxProrabName.Text, Convert.ToInt32(textBoxInitialBalance.Text), Convert.ToInt32(textBoxOrdersLimit.Text));
                controller.Prorab.CloseTask += this.DoCloseTask;
                controller.Prorab.AddWorker(new Worker("Ravshan", WorkerSkills.Builder, 5, 50, vLogger));
                controller.Prorab.AddWorker(new Worker("Dzhamshut", WorkerSkills.Builder, 8, 80, vLogger));
                controller.Prorab.AddWorker(new Worker("Vova", WorkerSkills.Electrician, 10, 100, vLogger));
                controller.Prorab.AddWorker(new Worker("Pedro", WorkerSkills.Plumber, 10, 100, vLogger));
                controller.Prorab.AddWorker(new Worker("George", WorkerSkills.Designer, 10, 100, vLogger));
            }
            //vIsRunning = !vIsRunning;
            //timerStep.Enabled = vIsRunning;
            //buttonStart.Text = vIsRunning ? "Stop" : "Start";
            controller.DoStep();
            UpdateGUI();
        }

        private void timerStep_Tick(object sender, EventArgs e) {
            controller.DoStep();
            UpdateGUI();
        }

        private void textBoxInitialBalance_TextChanged(object sender, EventArgs e) {

        }

    }
}
