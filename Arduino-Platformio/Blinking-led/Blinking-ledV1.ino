const byte led1 = 2;
const byte led2 = 4;
const byte fadeLed = 3;

unsigned long currentTime = 0;
unsigned long prevTime1 = 0;
unsigned long prevTime2 = 0;
unsigned long prevTime3 = 0;
int brightness = 0;
int brightnessInterval = 1;

void setup(){
    pinMode(led1,OUTPUT);
    pinMode(led2,OUTPUT);
    pinMode(fadeLed,OUTPUT);
}

void loop(){
    currentTime = millis();
    prevTime1 = BlinkingLed(led1,prevTime1,100);
    prevTime2 = BlinkingLed(led2,prevTime2,20);
    FadingLed(20);
}

long BlinkingLed(byte pin,long prevTime,long delay){
    if(currentTime - prevTime >= delay){
        digitalWrite(pin,!digitalRead(pin));
        return currentTime;
    }
    return prevTime;
}

long FadingLed(long delay){
    if(currentTime - prevTime3 >= delay){
        brightness += brightnessInterval;
        analogWrite(fadeLed,brightness);
        if(brightness == 255 || brightness == 0) brightnessInterval *=  -1;
        prevTime3 = currentTime;
    }
}

