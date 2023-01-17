#include <Arduino.h>
#include <CircularBuffer.h>
#include <BasicClassUtils/ButtonClass/Button.h>
#include <BasicClassUtils/RGBLed/RGBLed.h>
#include <BasicClassUtils/TimingControl/Timer.h>
#include <BasicClassUtils/LedControl/Led.h>

typedef enum{
    Light1_Red,
    Light1_Green,
    Light1_Yellow,
    Car_Waiting_at_1,
    Light2_Red,
    Light2_Green,
    Light2_Yellow,
    Car_Waiting_at_2,
}Light_State;

// typedef struct{
//     Led car2 (car2Pin);
//     RGBLed led2 (11,12,13);
//     Timer timer2;
//     Light_State light2;
// }Traffic_Light;

const int car1Pin = 6;
const int car2Pin = 7;

//make most values a const with clear name
Button button1 (2,50);
Led car1 (car1Pin);
RGBLed led1 (8,9,10);
Timer timer1;
Light_State light1 = Light1_Red;

Button button2 (3,50);
Led car2 (car2Pin);
RGBLed led2 (11,12,13);
Timer timer2;
Light_State light2 = Light2_Red;

CircularBuffer<int*,100> queue;

void setup(){
    Serial.begin(9600);
}

void loop(){

    if(button1.read() && !digitalRead(car1Pin)){
        queue.push(&light1);
        car1.on();
    }
        
    if(button2.read() && !digitalRead(car2Pin)){
        queue.push(&light2);
        car2.on();
    }

    switch (*queue.first())
    {
    case Car_Waiting_at_1:
        led1.red();
        led2.red();
        Serial.println("case 1");
        if(timer1.Delay(500)){
            led1.green();
            light1 = Light1_Green;
            // queue.shift();//removes item at front of queue
            // queue.unshift(11);//adds item to front of queue
        }
        break;

    case Light1_Green:
        Serial.println("case 11");
        if(timer1.Delay(3000)){
            light1 = Light1_Yellow;
            // queue.shift();
            // queue.unshift(111);
            led1.yellow();
            car1.off();
        }
        break;

    case Light1_Yellow:
        Serial.println("case 111");
        if(timer1.Delay(1000)){
            led1.red();
            light1 = Light1_Red;
            queue.shift();
        }
        break;

    case Car_Waiting_at_2:
        led1.red();
        led2.red();
        Serial.println("case 2");
        if(timer2.Delay(500)){
            led2.green();
            light2 = Light2_Green;
            // queue.shift();
            // queue.unshift(22);
        }
        break;

    case Light2_Green:
        Serial.println("case 22");
        if(timer2.Delay(3000)){
            light2 = Light2_Yellow;
            // queue.shift();
            // queue.unshift(222);
            led2.yellow();
            car2.off();
        }
        break;
    case Light2_Yellow:
        Serial.println("case 222");
        if(timer2.Delay(1000)){
            light2 = Light2_Red;
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

