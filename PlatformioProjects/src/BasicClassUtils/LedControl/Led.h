#ifndef Led_h
#define Led_h
#include "Arduino.h"
class Led{
    public:
    Led(byte pin);
    void setup();
    void on();
    void off();
    void toggle();
    private:
    byte _pin;
};
#endif