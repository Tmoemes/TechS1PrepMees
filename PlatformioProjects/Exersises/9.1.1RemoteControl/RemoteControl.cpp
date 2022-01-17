#include <Arduino.h>
#include <BasicClassUtils/LedControl/Led.h>
#include <BasicClassUtils/RGBLed/RGBLed.h>

Led led1(2);
Led led2(4);
Led led3(7);
RGBLed rgbLed(3,5,6);

char* inputString = "";
bool commandComplete = false;
char* commandString = "";
char* commandToken; 


void serialEvent(){//get the serial input and converts to usable command string
    inputString = {};//reset inputstring
    while(Serial.available()){
        char inChar = Serial.read();
        if(sizeof(inputString) == 0 && inChar != '#') break;//check if first char is # identifier
        inputString += inChar;
        if (inChar == '%'){
            commandComplete = true;
        }
    }
    if(sizeof(inputString)>0)
    { 
        commandString = strtok(inputString,"#%");  //removes # and %
    }
}

void setup(){
    Serial.begin(9600);
    led1.setup();
    led2.setup();
    led3.setup();
    rgbLed.setup();
}

void loop(){
    if(commandComplete){//if there is a complete command execute the code
        commandComplete = false;
        commandToken = strtok(commandString,":,");
        if(strcmp(commandToken,"SET_LED_1")){//"SET_LED_1:ON/OFF"
            commandToken = strtok(NULL,":,");
            if(strcmp(commandToken,"ON")){
                led1.on();
            }
            else if(strcmp(commandToken,"OFF")){
                led1.off();
            }
        }
        if(strcmp(commandToken,"SET_LED_2")){//"SET_LED_2:ON/OFF"
            commandToken = strtok(NULL,":,");
            if(strcmp(commandToken,"ON")){
                led2.on();
            }
            else if(strcmp(commandToken,"OFF")){
                led2.off();
            }
        }
        if(strcmp(commandToken,"SET_LED_3")){//"SET_LED_3:ON/OFF"
            commandToken = strtok(NULL,":,");
            if(strcmp(commandToken,"ON")){
                led3.on();
            }
            else if(strcmp(commandToken,"OFF")){
                led3.off();
            }
        }
        if(strcmp(commandToken,"SET_RGB_LED")){//"SET_RGB_LED:OFF/RGB:{R},{G},{B}"
            commandToken = strtok(NULL,":,");
            if(strcmp(commandToken,"OFF")){
                led3.off();
            }
            else if(strcmp(commandToken,"RGB")){
                rgbLed.rgb(atoi(strtok(NULL,":,")),atoi(strtok(NULL,":,")),atoi(strtok(NULL,":,")));
            }
        }
        else Serial.println("Unkown_command_received");
    }
}