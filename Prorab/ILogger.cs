using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prorab {
    public interface ILogger {
        void DoLog(IStatus sender, string messageText, string actionText="");
    }
}
