const byte led1 = 2;
const byte led2 = 3;
const byte led3 = 4;

long timers[10];
unsigned long currentTime = 0;

void setup(){
    pinMode(led1,OUTPUT);
    pinMode(led2,OUTPUT);
    pinMode(led3,OUTPUT);
    StartTimers();
}

void loop(){
    currentTime = millis();
    if(CheckTimer(0,500)) digitalWrite(led1,!digitalRead(led1));
    if(CheckTimer(1,250)) digitalWrite(led2,!digitalRead(led2));
    if(CheckTimer(2,125)) digitalWrite(led3,!digitalRead(led3));
}

void StartTimers(){
    for(int i; i<sizeof(timers); i++){
        timers[i] = 0;
    }
}

bool CheckTimer(int index,int delay){
    if(currentTime - timers[index] >= delay){
        timers[index] = currentTime;
        return true;
    }
    return false;
}