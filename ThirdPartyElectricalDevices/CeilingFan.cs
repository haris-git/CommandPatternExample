using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControl.ThirdPartyElectricalDevices
{
    public class CeilingFan
    {
        public string Area { get; private set; }

        public CeilingFan(string area)
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

        public void SetSpeed(int speed)
        {
            // Here goes the code that sets the speed of the ceiling fan...
        }
    }
}
