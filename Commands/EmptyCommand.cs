using RemoteControl.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControl.Commands
{
    /// <summary>
    /// This is an empty command. It is used to initialize the empty command slot of a new remote control.
    /// </summary>
    class EmptyCommand : Command
    {
        public void execute()
        {
            Debug.WriteLine("Empty Command.");
        }
    }
}
