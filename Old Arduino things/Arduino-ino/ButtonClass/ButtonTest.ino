#include "Button.h"

const byte ledPin = 3;

Button testButton (2,50);

void setup(){
    pinMode(ledPin,OUTPUT);
}

void loop(){
    if(testButton.read()) digitalWrite(ledPin,!digitalRead(ledPin));
}