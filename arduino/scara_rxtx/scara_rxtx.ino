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

#include <SparkFunAutoDriver.h>
#include <SparkFundSPINConstants.h>

/*
 * Mason SciOly 2016-17 Robot Arm
 * Arduino Serial Receiver/Slave code
 * For use with Mega 2560
 */

// TODO: put required libraries in repo
// or make a note that they're needed

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(13,OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  if(Serial.available()){
    String str = Serial.readString();
    if(str == "test    "){
      // send back confirmation?
      for (int j = 0; j < 1000; j++){
        digitalWrite(13,HIGH);
        delay(100);
        digitalWrite(13,LOW);
        delay(100);
      }
    }
  }
  
}
