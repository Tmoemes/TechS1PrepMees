#include <Arduino.h>
#include <BasicClassUtils/TimingControl/Timer.h>

Timer timer;
const int ldr = A0;
const int ledPin = 3;
//0,1023
int dimmingStart = 500;
int dimmingEnd = 800;
//0,255
int maxDimming = 0;

void setup(){
    pinMode(ldr, INPUT);
    Serial.begin(9600);
}

void loop(){
    int lightLevel = analogRead(ldr);
    if(lightLevel > dimmingEnd){
        analogWrite(ledPin,LOW);
    }
    else{
        analogWrite(ledPin,map(lightLevel,dimmingEnd,dimmingStart,maxDimming,255));
    }
    
    if(timer.CheckTimer(100)){
        Serial.println(lightLevel);
    }   
}