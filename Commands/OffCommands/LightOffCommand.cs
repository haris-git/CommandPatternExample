using RemoteControl.ThirdPartyElectricalDevices;
using RemoteControl.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RemoteControl.Commands.OffCommands
{
    public class LightOffCommand : Command
    {
        public Light light { get; private set; }

        public LightOffCommand(Light light)
        {
            this.light = light;
        }
        public void execute()
        {
            light.Off();
        }
    }
}
