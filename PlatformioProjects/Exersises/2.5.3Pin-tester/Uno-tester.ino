#include <Arduino.h>
int digitalPins[11] = {12,11,10,9,8,7,6,5,4,3,2};
int analogPins[6] = {A5,A4,A3,A2,A1,A0};
int centralTestPin = 13;

// //plan, make every pin output and end in pin 0. check if pin 0 reads then
// //serial print status.

//to add support for analog input, attach a pot to all the analog inputs
//cycle through all pins, user twists the pot while program waits

void setup(){

}

void loop(){

}

String testDigitalPin(int pin){
    String result = String(pin) +": ";
    pinMode(centralTestPin,OUTPUT);
    digitalWrite(centralTestPin,HIGH);
    pinMode(pin,INPUT);
    if(digitalRead(pin) == HIGH){
        result += "INPUT OK,";
    }else{
        result += "INPUT ERROR,";
    }

    pinMode(centralTestPin,INPUT);
    pinMode(pin,OUTPUT);
    digitalWrite(pin,HIGH);
    if(digitalRead(centralTestPin) == HIGH){
        result += "OUTPUT OK,";
    }else{
        result += "OUTPUT ERROR,";
    }
    result += "\n";
    return result;
} 

String testAnalogPin(int pin){
    String result = String(pin) + ": ";
    pinMode(centralTestPin,OUTPUT);
    digitalWrite(centralTestPin,HIGH);
    pinMode(pin,INPUT);
    if(analogRead(pin) != 0){
        result = result + "INPUT OK " + String(analogRead(pin)) + "V,";
    }else{
        result += "INPUT ERROR,";
    }
    result += "\n";
    return result;
}