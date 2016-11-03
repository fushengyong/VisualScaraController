#include <Servo.h>

#include <LiquidCrystal.h>

LiquidCrystal lcd(41,39,23,25,27,29,31,33,35,37);
Servo servo;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  servo.attach(13,700,2200);
  lcd.begin(16, 2);
  lcd.print("hello world!");
  delay(3000);
  lcd.clear();
  delay(500);
  lcd.print("Enter a value");
  lcd.setCursor(0,1);
}

void loop() {
  // put your main code here, to run repeatedly:
  if (Serial.available()) {
    lcd.clear();
    lcd.print("Enter a value:");
    lcd.setCursor(0,1);
    int val = Serial.parseInt();
    if(val > 2200) val = 2200;
    if(val < 700) val = 700;
    lcd.print(val);
    servo.write(val);
  }
}
