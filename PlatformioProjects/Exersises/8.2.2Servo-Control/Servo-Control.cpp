#include <Arduino.h>
#include <Servo.h>
#include <BasicClassUtils/TimingControl/Timer.h>

Servo SurgeryServo;
Timer SerialTimer;

const int SurgeryServoPin = 9;
const int SmallPotPin = A0;
const int LargePotPin = A1;
int smallpot;
int largepot;
int smallpos;
int largepos;
int servopos;

void setup(){
    SurgeryServo.attach(SurgeryServoPin);
    Serial.begin(9600);
}

void loop(){
    smallpot = analogRead(SmallPotPin);
    largepot = analogRead(LargePotPin);
    
    smallpos = map(smallpot, 0, 1023, 0, 18);
    largepos = map(largepot,0,1023,0,162);

    servopos = smallpos + largepos;

    if(SerialTimer.CheckTimer(500)){
        Serial.print("Smallpos: ");Serial.println(smallpos);
        Serial.print("Largepos: ");Serial.println(largepos);
        Serial.print("Servopos: ");Serial.println(servopos);
    }
    SurgeryServo.write(servopos);
}