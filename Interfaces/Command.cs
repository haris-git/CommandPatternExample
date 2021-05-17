using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControl.Interfaces
{
    /// <summary>
    /// This is the main interface for the command pattern.
    /// </summary>
    public interface Command
    {
        public void execute();
    }
}
