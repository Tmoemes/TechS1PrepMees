#include <Arduino.h>
#include <BasicClassUtils/TimingControl/Timer.h>

//change for different responsiveness
const int readingAmount = 25;
const int readingDelay = 250;

//hysteresis margin
int hystMargin = 50;

//start and stop values for led dimming between 0,1023
int dimmingStart = 500;
int dimmingEnd = 800;

//for the array of read values
int readings[readingAmount];
int readIndex = 0;
int initReading = 0;

//timers for printing and frequency of measurements
Timer printTimer;
Timer readTimer;

//const pins for ldr and led
const int ldr = A0;
const int ledPin = 3;

int readerAverage(){
    int total = 0;
    for (int i = 0; i < readingAmount; i++)
    {
        total += readings[i];
    }
    return int(total/readingAmount);
}


void setup(){
    pinMode(ldr, INPUT);
    Serial.begin(9600);
    for (int i = 0; i < readingAmount; i++)
    {
        readings[i]=initReading;
    }
    analogWrite(ledPin,map(analogRead(ldr),dimmingEnd,dimmingStart,0,255));
}

void loop(){
    if(readTimer.CheckTimer(readingDelay)){
        readings[readIndex] = analogRead(ldr);
        Serial.print("reading from ldr: ");
        Serial.println(readings[readIndex]);
        Serial.print("readindex:");
        Serial.println(readIndex);
        if(readIndex >= readingAmount-1){
            readIndex = 0;
        }else readIndex++;
    }

    if(readerAverage() >= dimmingEnd + hystMargin){
        analogWrite(ledPin,LOW);
    }
    else if(readerAverage() < dimmingEnd - hystMargin){
        analogWrite(ledPin,map(readerAverage(),dimmingEnd,dimmingStart,0,255));
    }
    
    if(printTimer.CheckTimer(100)){
        Serial.print("average reading is:");
        Serial.println(int(readerAverage()));
    }   
}

