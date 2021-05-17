# CommandPatternExample
This is a command pattern example, implemented in C# .NET5.0 as a WPF Windows application. It has a virtual remote control which can control several virtual electronic devices.
The remote control is decoupled from the devices. Instead, when we initialize it, we assign **commands** to its buttons. These commands are responsible for controlling the devices.

# Explanation of the command pattern
The command pattern is used when we want to decouple the object making request from the objects that know how to perform the request. In the current example, 
the remote control doesn't know how to lights or the ceiling fan are turn on or off. It can only send the commands for these action, when the correct button is pressed.
Each electical device has two action, on and off. So, we implement one command that turns on the device and one command that turns off the device. Both of these 
commands _implement the same C# interface_.
