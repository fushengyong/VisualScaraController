# VisualScaraController
A more user-friendly (and dev-friendly :>) way to communicate between Arduino and computer.
For Mason SciOly's 2016-17 Robot Arm event.

## Design
The computer side uses a predetermined model of the Robot Arm to interface with the user. This takes the form of a Windows Forms (VB.NET) application, which has preexisting and robust methods of communicating on a serial port (cf. RXTX or jSSC, which need much more setup). The user's input on a map of the playing field is transmitted as a series of bytes over the serial port to be interpreted by the Arduino. If necessary, the computer can also listen for debugging data from the Arduino.

The Arduino side (included in the repository) reads data from the computer over the attached serial port, interprets it, and uses it to actuate motors which move the robot itself. It should also send debugging data at times, such as heartbeat, motor positions, or other user (hardware) inputs.

## Usage
The Visual Basic.NET code should already be setup.

We recommend setting the directory arduino/ as a sketchbook.

## License
Copyright (C) 2016 Wei Gao

This program is free software; you can redistribute it and/or
modify it under the terms of the GNU General Public License
as published by the Free Software Foundation; either version 2
of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program; if not, write to the Free Software
Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.

(This project is available under GPL v2 and GPL v3.)
