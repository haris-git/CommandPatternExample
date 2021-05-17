using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControl.ThirdPartyElectricalDevices
{
    public class Light
    {
        public string Area { get; private set; }

        public Light(string area)
        {
            this.Area = area;
        }

        public void On()
        {
            Debug.WriteLine($"{Area} is on.");
        }

        public void Off()
        {
            Debug.WriteLine($"{Area} is off.");
        }
    }
}
