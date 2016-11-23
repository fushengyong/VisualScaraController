byte basePotPin = A15;
byte elbowPotPin = A14;
byte zAxisPotPin = A13;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(10,OUTPUT);
  pinMode(11,OUTPUT);
  pinMode(12,OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  int base = map(analogRead(basePotPin),0,1023,0,255);
  int elbow = map(analogRead(elbowPotPin),0,1023,0,255);
  int zaxis = map(analogRead(zAxisPotPin),0,1023,0,255);
  analogWrite(10,base);
  analogWrite(11,elbow);
  analogWrite(12,zaxis);
  Serial.print(base);
  Serial.print(" ");
  
  
  Serial.print(elbow);
  Serial.print(" ");
  
  
  Serial.println(zaxis);
  delay(1);
}
