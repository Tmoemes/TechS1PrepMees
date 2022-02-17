#include "Arduino.h"
#include "BasicClassUtils/TimingControl/Timer.h"
Timer timer;

void setup(){
    Serial.begin(9600);
    pinMode(A0,INPUT);
    pinMode(A1,INPUT);
    pinMode(3,OUTPUT);
}

void loop(){
    if(timer.CheckTimer(500)){
    Serial.print("Input V: ");
    Serial.println(analogRead(A0)/205.0);

    Serial.print("Output V: ");
    Serial.println(analogRead(A1)/205.0);
    }
    analogWrite(3,map(analogRead(A0), 0, 1023, 0, 255));
}