/*
Copyright (C) 2016 Wei Gao, Dival Banerjee

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
 */

#include <AccelStepper.h>
#include <MultiStepper.h>

#include <SparkFunAutoDriver.h>
#include <SparkFundSPINConstants.h>

#include <Servo.h>

// mimic controller setup

// potentiometer definitions
int BasePot = A0;
int ElbowPot = A1;
int ZAxisPot = A2; // linear potentiometer

// digital input definitions
int unfoldPin = 44;
int vacuumPin = 45;
int effectorPin1 = 46; // determines orientation/configuration of end effector

// stepper motors
AccelStepper HingeStepper(AccelStepper::FULL4WIRE,24,26,28,30,true); // l298n can be run as a full 4-wire mode
// the only thing that EasyDrivers need bare minimum is STEP and DIR
AccelStepper ZAxisStepper(AccelStepper::DRIVER,3,2,true)
AccelStepper ElbowStepper(AccelStepper::DRIVER,5,4,true)

// servos
Servo effServ1;
Servo effServ2;

void setup() {
  // put your setup code here, to run once:
  // wait for unfold command
}

void loop() {
  // put your main code here, to run repeatedly:

}
