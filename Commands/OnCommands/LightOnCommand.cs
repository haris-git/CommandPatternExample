using RemoteControl.ThirdPartyElectricalDevices;
using RemoteControl.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControl.Commands.OnCommands
{
    public class LightOnCommand : Command
    {
        public Light light { get; private set; }

        public LightOnCommand(Light light)
        {
            this.light = light;
        }
        public void execute()
        {
            light.On();
        }
    }
}
