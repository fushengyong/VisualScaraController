#include <LiquidCrystal.h>

// TODO: update with new hardware pin settings
LiquidCrystal lcd(41,39,23,25,27,29,31,33,35,37);
void setup() {
  // put your setup code here, to run once:
  //lcd.autoscroll();
  Serial.begin(9600);
  lcd.begin(16, 2);
  lcd.print("hello world!");
  delay(3000);
  lcd.clear();
  delay(500);
}

void loop() {
  // when characters arrive over the serial port...
  if (Serial.available()) {
    // wait a bit for the entire message to arrive
    delay(100);
    // clear the screen
    lcd.clear();
    // read all the available characters
    lcd.print(Serial.readString());
  }
}
