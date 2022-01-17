#include "RGBLed.h"
#include "Arduino.h"

RGBLed::RGBLed(byte R, byte G, byte B) {
    _R = R;
    _G = G;
    _B = B;
}

void RGBLed::setup(){
    pinMode(_R,OUTPUT);
    pinMode(_G,OUTPUT);
    pinMode(_B,OUTPUT);
    off();
}

void RGBLed::rgb(int R, int G, int B){
    analogWrite(_R,R);
    analogWrite(_G,G);
    analogWrite(_B,B);
}

void RGBLed::white(){
    digitalWrite(_R,HIGH);
    digitalWrite(_G,HIGH);
    digitalWrite(_B,HIGH);
}

void RGBLed::red(){
    off();
    digitalWrite(_R,HIGH);
}

void RGBLed::green(){
    off();
    digitalWrite(_G,HIGH);
}
void RGBLed::blue(){
    off();
    digitalWrite(_B,HIGH);
}
void RGBLed::cyan(){
    off();
    digitalWrite(_B,HIGH);
    digitalWrite(_G,HIGH);
}
void RGBLed::yellow(){
    off();
    digitalWrite(_R,HIGH);
    digitalWrite(_G,HIGH);
}
void RGBLed::purple(){
    off();
    digitalWrite(_B,HIGH);
    digitalWrite(_R,HIGH);
}

void RGBLed::off(){
    digitalWrite(_R,LOW);
    digitalWrite(_G,LOW);
    digitalWrite(_B,LOW);
}

// void RGBLed::toggle(int r, int g, int b){
//     digitalWrite(pin,!digitalRead(pin));
// }
