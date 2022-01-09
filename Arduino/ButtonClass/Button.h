#ifndef Button_h
#define Button_h
#include "Arduino.h"
class Button{
    public:
    Button(byte pin, unsigned long debounceTime);
    byte read();
    void setupButton();
    private:
    byte _pin;
    unsigned long _debounceDelay;  
    unsigned long _debounceTime;
    int _buttonState;
    int _prevState;
};
#endif