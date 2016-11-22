byte basePotPin = A15;
byte elbowPotPin = A14;
byte zAxisPotPin = A13;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  Serial.print(analogRead(basePotPin));
  Serial.print(" ");
  Serial.print(analogRead(elbowPotPin));
  Serial.print(" ");
  Serial.println(analogRead(zAxisPotPin));
  delay(10);
}
