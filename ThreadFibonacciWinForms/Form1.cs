using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace ThreadFibonacciWinForms {
    public partial class Form1 : Form {
        int vTick = 0;
        public Form1() {
            InitializeComponent();
        }
        private decimal DoFibonacci() {
            //Random rnd = new Random(Guid.NewGuid().GetHashCode());
            //int elemTo = rnd.Next(1, 100);
            int elemTo = 100;
            decimal sum = 0;
            decimal sumPrev = 1;  // 0,1,1,2,3,5,8,13,21,34...
            for (int elemNo = 1; elemNo < elemTo; elemNo++) {
                decimal sumTmp = sumPrev;
                sumPrev += sum;
                sum = sumTmp;
                Thread.Sleep(100);
            }
            return sum;
        }

        private async void button1_Click(object sender, EventArgs e) {
            button1.Text = "Stop";
            timer1.Start();
            button1.Text = "Start";
            //Decimal result=DoFibonacci();
            Task<decimal> taskCalc = Task.Run<decimal>(() => DoFibonacci());
            decimal result = await taskCalc;
            MessageBox.Show(result.ToString());
            timer1.Stop();

        }

        private void timer1_Tick(object sender, EventArgs e) {
            lblTicks.Text = vTick.ToString();
            vTick++;
        }
    }
}
