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
#include <Servo.h>

// analog inputs
#define BASE_POT A0
#define ELBOW_POT A1
#define ZAXIS_POT A2

// digital inputs
#define UNFOLD_PIN 44
#define FLIP_PIN 45 // still figuring this function out
#define LED_PIN 46
#define DISPENSE_PIN 47 // for a solenoid?0

// hinge stepper - hooked up to external L298N board0
#define HINGE_1 24
#define HINGE_2 26
#define HINGE_3 28
#define HINGE_4 30

// base stepper - hooked up to arduino motor shield r3
#define BASE_EN1 3 // must be set HIGH
#define BASE_EN2 11 // must be set HIGH
#define BASE_1 25 
#define BASE_2 27
#define BASE_3 29
#define BASE_4 31

#define ZAXIS_STEP 10
#define ZAXIS_DIR 7
#define ZAXIS_EN 6

#define ELBOW_STEP 5
#define ELBOW_DIR 4
#define ELBOW_EN 2
// stepper motors
AccelStepper HingeStepper(AccelStepper::FULL4WIRE,HINGE_1,HINGE_2,HINGE_3,HINGE_4,true); // l298n can be run as a full 4-wire mode
AccelStepper BaseStepper(AccelStepper::FULL4WIRE,BASE_1,BASE_2,BASE_3,BASE_4,true);
// the only thing that EasyDrivers need bare minimum is STEP and DIR
AccelStepper ZAxisStepper(AccelStepper::DRIVER,ZAXIS_STEP,ZAXIS_DIR,true) // EN must still be connected
AccelStepper ElbowStepper(AccelStepper::DRIVER,ELBOW_STEP,ELBOW_DIR,true)

// servos
Servo eServo1;
Servo eServo2;

void setup() {
  // put your setup code here, to run once:
  // wait for unfold command
}

void loop() {
  // put your main code here, to run repeatedly:

}
