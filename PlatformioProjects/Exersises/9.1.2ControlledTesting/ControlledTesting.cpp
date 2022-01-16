#include <Arduino.h>
#include <BasicClassUtils/TimingControl/Timer.h>

Timer timeoutTimer;
char* inputString = "";
bool commandComplete = false;
char* commandString = "";
bool testComplete = false;
char* commandTokens; 
char* testResult;

char* TestDigitalPin(int testPin,int testerPin){
    char* result = "#"; //result, bool input, bool output
    //testpin INPUT
    pinMode(testPin,INPUT);
    pinMode(testerPin,OUTPUT);
    digitalWrite(testerPin,HIGH);
    strcat(result,digitalRead(testPin) == HIGH ? "True" : "False");
    strcat(result,",");
    //testpin OUTPUT
    pinMode(testPin,OUTPUT);
    pinMode(testerPin,INPUT);
    digitalWrite(testPin,HIGH);
    strcat(result,digitalRead(testerPin) == HIGH ? "True%" : "False%");
    return result;
}

char* TestAnalogPin(int testPin,int testerPin){//TODO add check for digital in too
     char* result = "#";
     timeoutTimer.Delay(120000);//start timoutTimer
     bool passedTest = true;
    pinMode(testPin,INPUT);
    pinMode(testerPin,OUTPUT);
    while(analogRead(testPin > 50)){//first set potentiometer to 0
         if(timeoutTimer.Delay(120000)){//timout of 2min if something is not working 
                passedTest = false;
                break;
            };
        };
    for (size_t i = 16; i < 1024; i+16)
    {   
        while(analogRead(testPin) <= i && passedTest){//skips this if test has failed and so quickly ending for loop
            if(timeoutTimer.Delay(120000)){//timout of 2min if something is not working 
                passedTest = false;
                break;
            };
        }//only passes if it is able to increase from 0-1024 in increments of 16
    }
    timeoutTimer.ResetDelay();
    strcat(result,passedTest? "True":"False");//concatonate True if "passedTest" is still true, otherwise False
    //testpin digital OUTPUT
    pinMode(testPin,OUTPUT);
    pinMode(testerPin,INPUT);
    digitalWrite(testPin,HIGH);
    strcat(result,digitalRead(testerPin) == HIGH ? "True%" : "False%");
    return result;
}


void serialEvent(){//get the serial input and converts to usable command string
    inputString = "";//reset inputstring
    while(Serial.available()){
        char inChar = Serial.read();
        if(sizeof(inputString) == 1 && inChar != '#') break;//check if first char is # identifier
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
}

void loop(){
    if(commandComplete){//if there is a complete command execute the code
        commandComplete = false;
        commandTokens = strtok(commandString,":,");
        if(strcmp(commandTokens,"Test_Pins:")){//"Test_Pins:0,1"
            Serial.println("#Pin_Test_Starting%");
            testResult = TestDigitalPin(atoi(strtok(NULL,",")),atoi(strtok(NULL,",")));
            Serial.println(testResult);//example #True,True%
        }
        if(strcmp(commandTokens,"Test_Analog_Pins:")){//"Test_Pins:A0,A1"
            Serial.println("#Analog_Pin_Test_Starting%");
            testResult = TestAnalogPin(atoi(strtok(NULL,",")),atoi(strtok(NULL,",")));
            Serial.println(testResult);//example #True,True%
        }
        else Serial.println("Unkown_command_received");
    }
}