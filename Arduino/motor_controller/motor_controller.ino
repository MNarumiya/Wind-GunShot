#include <Servo.h>

Servo Motor_L;
Servo Motor_R;

#define PIN_L 2
#define PIN_R 9

#define MOTORNUM 2

int MotorVal[MOTORNUM];
int MotorMemory[MOTORNUM];
const int BaseValue[MOTORNUM] = {1010, 1150};
const int NormalValue[MOTORNUM] = {1100, 1300};
const int GunShockValue[MOTORNUM] = {1370, 1000};
const int SafeLimitVlaue[MOTORNUM] = {1500, 1500};

bool PW_ON = false;
bool SafeLimit = true;

const int delayTime = 500;

void setup() {
  Serial.begin(115200);
  
  MotorInit();
  delay(500);
}

void loop() {
  CommandRead();
//  sendMotorData();
}

void MotorInit(){
  for(int i=0; i<MOTORNUM; i++) MotorVal[i] = 1000;
  Motor_L.attach(PIN_L, 1000, 2000);
  Motor_R.attach(PIN_R, 1000, 2000);
  MotorWrite();
}

void MotorStart(){
  for(int i=0; i<MOTORNUM; i++) MotorVal[i] = BaseValue[i];
  MotorWrite();
}

void MotorStop(){
  for(int i=0; i<MOTORNUM; i++) MotorVal[i] = 1000;
  MotorWrite();
}

void MotorNormal(){
  for(int i=0; i<MOTORNUM; i++) MotorVal[i] = NormalValue[i];
  MotorWrite();
}

void MotorGenerateGunShock() {
  for(int i=0; i<MOTORNUM; i++) MotorVal[i] = GunShockValue[i];
  MotorWrite();
}

void MotorDetach() {
  Motor_L.detach();
  Motor_R.detach();
}


void MotorWrite(){
  Motor_L.writeMicroseconds(MotorVal[0]);
  Motor_R.writeMicroseconds(MotorVal[1]);
}

void sendMotorData() {
  for(int i=0; i<MOTORNUM; i++) {
    Serial.print(MotorVal[i]);
    Serial.print("\t");
  }
  Serial.println();
}

void CommandRead() {
  if(Serial.available()){
    char mode = Serial.read();
          
    switch(mode){
      case '0':
        MotorStop();
        break;

      case '9':
        MotorDetach();
        break;

      case '1':
        MotorStart();
        break;
        
      case '2':
        MotorNormal();
        break;

      case '3':
        MotorGenerateGunShock();
        break;
    }
  }
}

     

