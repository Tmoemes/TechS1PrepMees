#include <Arduino.h>
int rOut = 3;
int gOut = 5;
int bOut = 6;

int rIn = A0;
int gIn = A1;
int bIn = A2;

void setup(){

    //preparing needed pins: 
    pinMode(rOut,OUTPUT);
    pinMode(gOut,OUTPUT);
    pinMode(bOut,OUTPUT);
    pinMode(rIn,INPUT);
    pinMode(gIn,INPUT);
    pinMode(bIn,INPUT);
}

void loop(){
    analogWrite(rOut,analogRead(rIn)/4);
    analogWrite(gOut,analogRead(gIn)/4);
    analogWrite(bOut,analogRead(bIn)/4);
}