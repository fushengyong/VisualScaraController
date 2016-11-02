#include <LiquidCrystal.h>

LiquidCrystal lcd(4,5,6,7,8,9,10,11,12,13);
void setup() {
  // put your setup code here, to run once:
  lcd.begin(16,2);
  lcd.print("hello world!");
  delay(4000);
}

void loop() {
  // put your main code here, to run repeatedly:

}
