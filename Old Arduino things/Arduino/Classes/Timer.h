#ifndef Timer_h
#define Timer_h
#include "Arduino.h"
class Timer{
    public:
    Timer();
    void init();
    bool CheckTimer(int index, int delay);
    private:
    long timers[32];
    unsigned long currentTime = 0;
};
#endif