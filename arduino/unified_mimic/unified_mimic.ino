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
#define BASE_POT A8
#define ELBOW_POT A9
#define ZAXIS_POT A10

// digital inputs
#define UNFOLD_PIN 44
#define FLIP_PIN 45 // still figuring this function out
#define LED_PIN 46
#define DISPENSE_PIN 47 // for a solenoid?0

// digital outputs
#define SOL_OUT 48
#define LED_OUT 49

// hinge stepper - hooked up to external L298N board0
#define HINGE_1 24
#define HINGE_2 26
#define HINGE_3 28
#define HINGE_4 30

// base stepper - hooked up to arduino motor shield r3
#define BASE_EN1 3 // must be set HIGH
#define BASE_EN2 11 // must be set HIGH
#define BASE_BRAKE1 8
#define BASE_BRAKE2 9
#define BASE_1 12
#define BASE_2 13

// regular EasyDriver
#define ZAXIS_STEP 10
#define ZAXIS_DIR 7
#define ZAXIS_EN 6
// Big EasyDriver
#define ELBOW_STEP 5
#define ELBOW_DIR 4
#define ELBOW_EN 2

// servo control pins
#define CLAW_SIG 14
#define FLIP_SIG 15

#define BASE_STEPS 200
#define ELBOW_STEPS 200
#define ZAXIS_STEPS 200
#define HINGE_STEPS 200
#define DEADZONE 5

// stepper motors
AccelStepper HingeStepper(AccelStepper::FULL4WIRE,HINGE_1,HINGE_2,HINGE_3,HINGE_4); // l298n can be run as a full 4-wire mode
AccelStepper BaseStepper(AccelStepper::FULL2WIRE,BASE_1,BASE_2);
// the only thing that EasyDrivers need bare minimum is STEP and DIR
AccelStepper ZAxisStepper(AccelStepper::DRIVER,ZAXIS_STEP,ZAXIS_DIR,true); // EN must still be connected
AccelStepper ElbowStepper(AccelStepper::DRIVER,ELBOW_STEP,ELBOW_DIR,true);

// servos
Servo flipServo;
Servo clawServo;

// helps with controller deadzone
int basePrevious = 0;
int elbowPrevious = 0;
int zAxisPrevious = 0;

// other global vars
bool ledOn = false;
unsigned char flipPos = 0;


void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  // set direction of all the pins
  pinMode(UNFOLD_PIN,INPUT);
  pinMode(FLIP_PIN,INPUT);
  pinMode(LED_PIN,INPUT);
  pinMode(DISPENSE_PIN,INPUT);

  pinMode(LED_OUT,OUTPUT);
  pinMode(SOL_OUT,OUTPUT);

  // enable all the motors
  pinMode(BASE_EN1,OUTPUT); 
  digitalWrite(BASE_EN1,HIGH);
  pinMode(BASE_EN2,OUTPUT);
  digitalWrite(BASE_EN2,HIGH);
  pinMode(BASE_BRAKE1,OUTPUT);
  digitalWrite(BASE_BRAKE1,LOW);
  pinMode(BASE_BRAKE2,OUTPUT);
  digitalWrite(BASE_BRAKE2,LOW);

  ZAxisStepper.setEnablePin(ZAXIS_EN);
  ElbowStepper.setEnablePin(ELBOW_EN);

  // set stepper max speeds
  BaseStepper.setMaxSpeed(1000);
  ElbowStepper.setMaxSpeed(1000);
  HingeStepper.setMaxSpeed(1000);
  ZAxisStepper.setMaxSpeed(1000);
  
  
  // attach servos
  flipServo.attach(FLIP_SIG);
  clawServo.attach(CLAW_SIG);
  
  // wait for unfold command
  while(digitalRead(UNFOLD_PIN) == LOW);

  // unfold when told to do so
  HingeStepper.moveTo(90); // CHECK THE DIReCTION ON THiS oNE
  HingeStepper.setSpeed(100);
  HingeStepper.runSpeedToPosition();
}

void loop() {
  // put your main code here, to run repeatedly:

  // take inputs
  
  // read digital inputs
  bool led = digitalRead(LED_PIN);
  bool flip = digitalRead(FLIP_PIN);
  bool dispense = digitalRead(DISPENSE_PIN);
  
  // read potentiometers
  int baseReading = analogRead(BASE_POT);
  int elbowReading = analogRead(ELBOW_POT);
  int zAxisReading = analogRead(ZAXIS_POT);
  // move motors while applying the deadzone
  if(abs(baseReading - basePrevious) > DEADZONE) {
    BaseStepper.moveTo(baseReading/16);

  }
  BaseStepper.setSpeed(100);
  BaseStepper.runSpeedToPosition();
  if(elbowReading - elbowPrevious > DEADZONE) {
    ElbowStepper.moveTo(elbowReading/16);
  }
  ElbowStepper.setSpeed(100);
  ElbowStepper.runSpeedToPosition();
  if(zAxisReading - zAxisPrevious > DEADZONE) {
    ZAxisStepper.moveTo(zAxisReading/16);
  }
  ZAxisStepper.setSpeed(100);
  ZAxisStepper.runSpeedToPosition();

  // respond to inputs
  // digital outputs
  if(led){
    ledOn = !ledOn;
    digitalWrite(LED_PIN,ledOn);
  }

  if(flip){
    unsigned char sPos = flipPos;
    if(sPos == 0){
      sPos = 2100; // TODO: must figure this out by testing hardware
    }
    else {
      sPos = 900; // TODO: this is currently set for Hitec servos, not generic futaba ones
    }
    flipServo.writeMicroseconds(sPos);
  }

  if(dispense){
    digitalWrite(SOL_OUT,HIGH);
  }else{
    digitalWrite(SOL_OUT,LOW);
  }
  
}


float getAngleFromSteps(int steps, int stepsPerRot) { // return the angle to which a given number of steps corresponds
  float rotations = (float)steps / stepsPerRot;
  float angle = rotations * 360;
  return angle;
}

int getStepsFromAngle(float angle, int stepsPerRot) { // return the number of steps needed to traverse a given angle
  float rotations = (float)angle / 360;
  long steps = stepsPerRot * rotations;
  return steps;
}
