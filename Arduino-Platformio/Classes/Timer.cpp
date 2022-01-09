#include "Timer.h"
#include "Arduino.h"
Timer::Timer() {
    init();
}

void Timer::init(){
    for(int i; i<sizeof(timers); i++){
    timers[i] = 0;
    }
}

bool Timer::CheckTimer(int index,int delay){
    currentTime = millis();
    if(currentTime - timers[index] >= delay){
    timers[index] = currentTime;
    return true;
    }
return false;
}




