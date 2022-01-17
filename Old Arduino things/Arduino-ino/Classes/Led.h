#ifndef Led_h
#define Led_h
#include "Arduino.h"
class Led{
    public:
    Led(byte pin);
    void on();
    void off();
    void toggle();
    private:
    byte pin;
};
#endif