#include <Arduino.h>
const byte buttonPin = 2;
const byte ledPin = 3;
int prevState = LOW;
int buttonState;
int ledState = LOW;

unsigned long debounceTime = 0;
unsigned long debounceDelay = 100;

void setup(){
    pinMode(buttonPin,INPUT);
    pinMode(ledPin,OUTPUT);
    digitalWrite(ledPin,ledState);
}

void loop(){
    int state = digitalRead(buttonPin);

    if(state != prevState){ debounceTime = millis();}

    if(millis() - debounceTime >= debounceDelay){

        if(state != buttonState){
            buttonState = state;
            if(buttonState == HIGH){digitalWrite(ledPin,!digitalRead(ledPin));}
        }
    }

    prevState = state;
}

