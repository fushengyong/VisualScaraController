#include <Servo.h>

#include <LiquidCrystal.h>

LiquidCrystal lcd(41,39,23,25,27,29,31,33,35,37);
Servo servo;
int servo_min = 560;
int servo_max = 2405 ;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  servo.attach(13,servo_min,servo_max);
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
    if(val > servo_max) val = servo_max;
    if(val < servo_min) val = servo_min;
    lcd.print(val);
    servo.write(val);
  }
}
