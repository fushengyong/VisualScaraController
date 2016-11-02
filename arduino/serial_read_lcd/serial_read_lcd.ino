#include <LiquidCrystal.h>
LiquidCrystal lcd(4,5,6,7,8,9,10,11,12,13);
void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  lcd.begin(16,2);
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
