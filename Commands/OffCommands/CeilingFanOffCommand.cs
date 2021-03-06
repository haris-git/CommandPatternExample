using RemoteControl.Interfaces;
using RemoteControl.ThirdPartyElectricalDevices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControl.Commands.OffCommands
{
    public class CeilingFanOffCommand : Command
    {
        public CeilingFan CeilingFan { get; private set; }

        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            this.CeilingFan = ceilingFan;
        }
        public void execute()
        {
            CeilingFan.Off();
        }
    }
}
