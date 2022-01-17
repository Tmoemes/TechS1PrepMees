#include "Led.h"
#include "Arduino.h"

Led::Led(byte pin) {
    this->pin = pin;
    pinMode(pin,OUTPUT);
    off();
}

void Led::on(){
    digitalWrite(pin,HIGH);
}

void Led::off(){
    digitalWrite(pin,LOW);
}

void Led::toggle(){
    digitalWrite(pin,!digitalRead(pin));
}
