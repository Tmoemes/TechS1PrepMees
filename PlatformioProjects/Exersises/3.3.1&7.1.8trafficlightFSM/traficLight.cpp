#include <Arduino.h>
#include <CircularBuffer.h>
#include <BasicClassUtils/ButtonClass/Button.h>
#include <BasicClassUtils/RGBLed/RGBLed.h>
#include <BasicClassUtils/TimingControl/Timer.h>
#include <BasicClassUtils/LedControl/Led.h>

const int car1Pin = 6;
const int car2Pin = 7;

//make most values a const with clear name
Button button1 (2,50);
Led car1 (car1Pin);
RGBLed led1 (8,9,10);
Timer timer1;


Button button2 (3,50);
Led car2 (car2Pin);
RGBLed led2 (11,12,13);
Timer timer2;

CircularBuffer<int,100> queue;

void setup(){
    Serial.begin(9600);
}

void loop(){

    if(button1.read() && !digitalRead(car1Pin)){
        queue.push(1);
        car1.on();
    }
        
    if(button2.read() && !digitalRead(car2Pin)){
        queue.push(2);
        car2.on();
    }

    switch (queue.first())
    {
    case 1:
        led1.red();
        led2.red();
        Serial.println("case 1");
        if(timer1.Delay(500)){
            led1.green();
            queue.shift();//removes item at front of queue
            queue.unshift(11);//adds item to front of queue
        }
        break;

    case 11:
        Serial.println("case 11");
        if(timer1.Delay(3000)){
            queue.shift();
            queue.unshift(111);
            led1.yellow();
            car1.off();
        }
        break;

    case 111:
        Serial.println("case 111");
        if(timer1.Delay(1000)){
            led1.red();
            queue.shift();
        }
        break;

    case 2:
        led1.red();
        led2.red();
        Serial.println("case 2");
        if(timer2.Delay(500)){
            led2.green();
            queue.shift();
            queue.unshift(22);
        }
        break;

    case 22:
        Serial.println("case 22");
        if(timer2.Delay(3000)){
            queue.shift();
            queue.unshift(222);
            led2.yellow();
            car2.off();
        }
        break;
    case 222:
        Serial.println("case 222");
        if(timer2.Delay(1000)){
            led2.red();
            queue.shift();
        }
        break;
    
    default:
        led1.red();
        led2.red();
        break;
    }

}

