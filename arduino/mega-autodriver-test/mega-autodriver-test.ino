#include <SPI.h>
#include <SparkFunAutoDriver.h>
#include <SparkFundSPINConstants.h>

#define MOSI 51
#define MISO 50
#define SCK 52
#define SLAVE_SELECT_PIN 53

#define DRIVER_FLAG 13
#define DRIVER_RST 12
#define DRIVER_BUSY 11
#define DRIVER_SEL 53
#define BASE_POT_PIN A15
#define STEPS_PER_ROT 200


AutoDriver base(DRIVER_SEL,DRIVER_RST,DRIVER_BUSY);
int curPos = 0;
int targetPos = 0;

void AutoDriverSetup() {
  Serial.println("Config sync pin");
  base.configSyncPin(BUSY_PIN,0);
  Serial.println("Config step mode");
  base.configStepMode(STEP_FS);
  Serial.println("Config max speed");
  base.setMaxSpeed(100); // 100 steps per second
  // default min speed = 0
  // because STEP_FS is the step mode, full speed won't be set
  base.setAcc(100);
  base.setDec(100); // takes ~1 seconds each to reach full speed and back
  base.setOCThreshold(OC_5250mA); // will reach overcurrent at 5.25A (massive overkill)
  base.setOCShutdown(OC_SD_DISABLE);
  base.setSlewRate(SR_530V_us);
  base.setOscMode(INT_16MHZ); // no OSCOUT output
  base.setVoltageComp(VS_COMP_DISABLE);

  base.setAccKVAL(255);
  base.setDecKVAL(255);
  base.setRunKVAL(255);
  base.setHoldKVAL(255);
  
}

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  Serial.println("Setting up board");
  AutoDriverSetup();
  Serial.println("Setup done");
  Serial.println("Waiting for status");
  while(base.getStatus() != 0x2E88){
    Serial.print("Status: ");
    Serial.println(base.getStatus());
  }
  Serial.println(base.getStatus());
  //base.run(FWD,50);
  //delay(8000);
  //base.softStop();
  base.resetPos();
  curPos = base.getPos(); 
  targetPos = analogRead(BASE_POT_PIN);
}

void loop() {
  // put your main code here, to run repeatedly:
//  curPos = base.getPos();
//  targetPos = analogRead(BASE_POT_PIN);
//  int posDelta = targetPos - curPos;
//  byte dir = FWD;
//  if(posDelta < 0) dir = REV;
//  posDelta = abs(posDelta);
//  unsigned long stepsDelta = map(posDelta,0,1023,0,200);
//  Serial.print(curPos);
//  Serial.print(" ");
//  Serial.print(targetPos);
//  Serial.print(" ");
//  Serial.print(posDelta);
//  Serial.print(" ");
//  Serial.print(dir);
//  Serial.print(" ");
//  Serial.println(stepsDelta);
//  base.move(dir, stepsDelta);
//  delay(1);
  Serial.println("running");
  base.run(FWD,50);
  delay(8000);
  Serial.println("done");
  base.softStop();
  delay(1000);
}
