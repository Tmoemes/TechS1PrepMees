#include"Button.h"
#include"Arduino.h"
Button::Button(byte pin, unsigned long debounceDelay){
    _pin = pin;
    _debounceDelay = debounceDelay;
}

void Button::setupButton(){
    pinMode(_pin,INPUT);
}

byte Button::read(){
    int state = digitalRead(_pin);

    if(state != _prevState){ _debounceTime = millis();}

    if(millis() - _debounceTime >= _debounceDelay){

        if(state != _buttonState){
            _buttonState = state;
            if(_buttonState == HIGH){return HIGH;}
        }
    }
    _prevState = state;
    return LOW;
}



