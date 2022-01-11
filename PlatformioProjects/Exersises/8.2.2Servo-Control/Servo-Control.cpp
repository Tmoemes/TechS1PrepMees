#include <Arduino.h>
#include <Servo.h>

Servo SurgeryServo;

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
    
}

void loop(){
    smallpot = analogRead(SmallPotPin);
    largepot = analogRead(LargePotPin);
    
    smallpos = map(smallpot, 0, 1023, 0, 18);
    largepos = map(largepot,0,1023,18,162);

    servopos = smallpos + largepos;

    SurgeryServo.write(servopos);
}