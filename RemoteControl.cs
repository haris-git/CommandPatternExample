using RemoteControl.Commands;
using RemoteControl.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RemoteControl
{
    /// <summary>
    /// The main tool, over which the command pattern is implemented. 
    /// A new instance of this class, can have many pairs of ON-OFF commands. 
    /// These commands are triggered when a button is pushed...
    /// </summary>
    public class RemoteControl
    {
        public Command[] OnCommands { get; private set; }
        public Command[] OffCommands { get; private set; }

        /// <summary>
        /// Give the number of the devices to be controlled as a parameter to the constructor.
        /// </summary>
        /// <param name="numberOfDevicesToBeControlled"></param>
        public RemoteControl(int numberOfDevicesToBeControlled)
        {
            OnCommands = new Command[numberOfDevicesToBeControlled];
            OffCommands = new Command[numberOfDevicesToBeControlled];

            Command emptyCommand = new EmptyCommand();

            // Initialize all the command slots with an empty command.
            for (int i = 0; i < numberOfDevicesToBeControlled; i++)
            {
                SetCommand(i, emptyCommand, emptyCommand);
            }
        }

        /// <summary>
        /// Set an ON and an OFF command to the current slot of the commands array.
        /// </summary>
        /// <param name="slot"></param>
        /// <param name="OnCommand"></param>
        /// <param name="OffCommand"></param>
        public void SetCommand(int slot, Command OnCommand, Command OffCommand)
        {
            OnCommands[slot] = OnCommand;
            OffCommands[slot] = OffCommand;
        }

        /// <summary>
        /// This function executes the ON command.
        /// </summary>
        /// <param name="slot"></param>
        public void ButtonOnWasPushed(int slot)
        {
            OnCommands[slot].execute();
        }

        /// <summary>
        /// This function executes the OFF command.
        /// </summary>
        /// <param name="slot"></param>
        public void ButtonOffWasPushed(int slot)
        {
            OffCommands[slot].execute();
        }
    }
}
