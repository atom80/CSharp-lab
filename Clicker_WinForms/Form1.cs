using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker_WinForms {
    public partial class Form1 : Form {
        private bool inGame = false;
        private int pointCount = 0;
        private int countdown = 0;
        public Form1() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void btnStart_Click(object sender, EventArgs e) {
            if (inGame) {
                lblPoints.Text = string.Format("{0} points!", ++pointCount);            } else {
                inGame = true;
                pointCount = 0;
                btnStart.Text = "Click!";
                countdown = 15;
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            lblCountdown.Text = string.Format("{0}",countdown--);
            if (countdown < 0) {
                inGame = false;
                btnStart.Text="Start";
                timer1.Stop();
                MessageBox.Show(string.Format("{0} points in 15 seconds!", pointCount));
            }
        }

    }
}
