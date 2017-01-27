using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prorab {
    public delegate void DoOutput(string msgText);
    class Logger : ILogger {
        //TextBox vTextBox = null;
        private DoOutput vLogMessageProc;
        public Logger(DoOutput LogMessage) {
            //vTextBox = textBox;
            vLogMessageProc=LogMessage;
        }

        public void DoLog(IStatus sender, string messageText, string actionText="") {
            if (actionText != "") { actionText = string.Format("\r\n[{0}]",actionText); }
            string senderText = "";
            if ((sender!=null)&&(sender.ID != "")) { senderText = string.Format("[{0}]: ",sender.ID); }
            //vTextBox.AppendText(string.Format("\r\n{0}{1}{2}", actionText,senderText, (string)messageText));
            if (vLogMessageProc!= null){
            vLogMessageProc(string.Format("\r\n{0}{1}{2}", actionText,senderText, (string)messageText));
            }
        }
    }
}
