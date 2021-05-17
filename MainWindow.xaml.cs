using RemoteControl.Commands.OnCommands;
using RemoteControl.Commands.OffCommands;
using RemoteControl.ThirdPartyElectricalDevices;
using System.Windows;


namespace RemoteControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public RemoteControl RemoteControl { get; private set; }
        private static readonly int NUMBEROFDEVICESTOBECONTROLLED = 3;  // For this example, the remote control will be able to control 3 devices.

        public MainWindow()
        {
            InitializeComponent();

            // Initialize the remote control.
            RemoteControl = new RemoteControl(NUMBEROFDEVICESTOBECONTROLLED);

            // Initialize the 'things' we want to control.
            Light frontDoorLight = new Light("Front door light");
            Light kitchenLight = new Light("Kitchen light");
            CeilingFan kitchenCeilingFan = new CeilingFan("Kitchen ceiling fan");

            // For each thing, we create two commands (ON and OFF).
            LightOnCommand frontDoorLightOn = new LightOnCommand(frontDoorLight);
            LightOffCommand frontDoorLightOff = new LightOffCommand(frontDoorLight);
            LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);
            CeilingFanOnCommand kitchenCeilingFanOn = new CeilingFanOnCommand(kitchenCeilingFan);
            CeilingFanOffCommand kitchenCeilingFanOff = new CeilingFanOffCommand(kitchenCeilingFan);

            // Set each pair of ON-OFF commands to the buttons of the remote control.
            RemoteControl.SetCommand(0, frontDoorLightOn, frontDoorLightOff);
            RemoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
            RemoteControl.SetCommand(2, kitchenCeilingFanOn, kitchenCeilingFanOff);


            device1Label.Content = frontDoorLight.Area;
            device2Label.Content = kitchenLight.Area;
            device3Label.Content = kitchenCeilingFan.Area;
        }

        private void Button1On_Click(object sender, RoutedEventArgs e)
        {
            RemoteControl.ButtonOnWasPushed(0);
        }

        private void Button1Off_Click(object sender, RoutedEventArgs e)
        {
            RemoteControl.ButtonOffWasPushed(0);
        }

        private void Button2On_Click(object sender, RoutedEventArgs e)
        {
            RemoteControl.ButtonOnWasPushed(1);
        }

        private void Button2Off_Click(object sender, RoutedEventArgs e)
        {
            RemoteControl.ButtonOffWasPushed(1);
        }

        private void Button3On_Click(object sender, RoutedEventArgs e)
        {
            RemoteControl.ButtonOnWasPushed(2);
        }

        private void Button3Off_Click(object sender, RoutedEventArgs e)
        {
            RemoteControl.ButtonOffWasPushed(2);
        }
    }
}
