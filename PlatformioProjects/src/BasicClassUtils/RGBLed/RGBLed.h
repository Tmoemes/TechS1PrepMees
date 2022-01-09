#ifndef RGBLed_h
#define RGBLed_h
#include "Arduino.h"
class RGBLed{
    public:
    RGBLed(byte R,byte G, byte B);
    void white();
    void red();
    void green();
    void blue();
    void cyan();
    void yellow();
    void purple();
    void off();
    void toggle(int R,int G,int B);
    private:
    byte _R;
    byte _G;
    byte _B;
};
#endif