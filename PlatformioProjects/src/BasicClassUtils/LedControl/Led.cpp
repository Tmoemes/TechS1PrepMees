#include "Led.h"
#include "Arduino.h"

Led::Led(byte pin) {
    _pin = pin;
    pinMode(pin,OUTPUT);
    off();
}

void Led::on(){
    digitalWrite(_pin,HIGH);
}

void Led::off(){
    digitalWrite(_pin,LOW);
}

void Led::toggle(){
    digitalWrite(_pin,!digitalRead(_pin));
}
