# VisualScaraController
A more user-friendly (and dev-friendly :>) way to communicate between Arduino and computer.
For Mason SciOly's 2016-17 Robot Arm event.

## Design
The computer side uses a predetermined model of the Robot Arm to interface with the user. This takes the form of a Windows Forms (VB.NET) application, which has preexisting and robust methods of communicating on a serial port (cf. RXTX or jSSC, which need much more setup). The user's input on a map of the playing field is transmitted as a series of bytes over the serial port to be interpreted by the Arduino. If necessary, the computer can also listen for debugging data from the Arduino.
The Arduino side (included in the repository) reads data from the computer over the attached serial port, interprets it, and uses it to actuate motors which move the robot itself. It should also send debugging data at times, such as heartbeat, motor positions, or other user (hardware) inputs.
