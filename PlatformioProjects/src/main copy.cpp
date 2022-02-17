// #include <Arduino.h>
// #include <BasicClassUtils/LedControl/Led.h>
// #include <BasicClassUtils/RGBLed/RGBLed.h>

// Led led1(2);
// Led led2(4);
// Led led3(7);
// RGBLed rgbLed(3,5,6);

// String inputString = "";
// bool commandComplete = false;
// String commandString = "";
// String commandToken = ""; 
// String paramToken = "";


// void serialEvent(){//get the serial input and converts to usable command string
//     while(Serial.available()){
//         char inChar = (char)Serial.read();
//         inputString += inChar;
//         if (inChar == '%'){
//             commandComplete = true;
//         }
//     }
//     if(sizeof(inputString)>0)
//     { 
//         if(!inputString.startsWith("#")){
//             commandComplete = false;//cancel command if it doens's start with #
//             inputString = "";
//         }
//         // Serial.print("commandComplete:");
//         // Serial.println(commandComplete);
//         // Serial.print("inputString:");
//         // Serial.println(inputString);
//         commandString = inputString.substring(1,inputString.length()-1);  //removes # and %
//         // Serial.print("commandString:");
//         // Serial.println(commandString);
//     }    
// }

// void setup(){
//     Serial.begin(9600);
//     led1.setup();
//     led2.setup();
//     led3.setup();
//     rgbLed.setup();
// }

// void loop(){
//     if(commandComplete){//if there is a complete command execute the code
//         commandComplete = false;
//         int commandIndex = commandString.indexOf(":");
//         commandToken = commandString.substring(0,commandIndex);
//         paramToken = commandString.substring(commandIndex+1);
//         // Serial.print("commandToken:");
//         // Serial.println(commandToken);
//         // Serial.print("ParamToken:");
//         // Serial.println(paramToken);
//         if(commandToken == "SET_LED_1"){//"SET_LED_1:ON/OFF"
//             if(paramToken == "ON"){
//                 led1.on();
//                 Serial.println("Led 1 on");
//                 inputString = "";//reset inputstring
//             }
//             else if(paramToken == "OFF"){
//                 led1.off();
//                 Serial.println("Led 1 off");
//                 inputString = "";//reset inputstring
//             }
//         }
//         else if(commandToken == "SET_LED_2"){//"SET_LED_2:ON/OFF"
//             if(paramToken == "ON"){
//                 led2.on();
//                 Serial.println("Led 2 on");
//                 inputString = "";//reset inputstring
//             }
//             else if(paramToken == "OFF"){
//                 led2.off();
//                 Serial.println("Led 2 off");
//                 inputString = "";//reset inputstring
//             }
//         }
//         else if(commandToken == "SET_LED_3"){//"SET_LED_3:ON/OFF"
//             if(paramToken == "ON"){
//                 led3.on();
//                 Serial.println("Led 3 on");
//                 inputString = "";//reset inputstring
//             }
//             else if(paramToken == "OFF"){
//                 led3.off();
//                 Serial.println("Led 3 off");
//                 inputString = "";//reset inputstring
//             }
//         }
//         else if(commandToken == "SET_RGB_LED"){//"SET_RGB_LED:OFF/RGB:{R},{G},{B}"
            
//             if(paramToken == "OFF"){
//                 rgbLed.off();
//                 Serial.println("RGBLed 3 off");
//                 inputString = "";//reset inputstring
//             }
//             int paramIndex = commandString.lastIndexOf(":");
//             paramToken = commandString.substring(commandIndex+1,paramIndex);
//             if(paramToken == "RGB"){
//                 int firstIndex = commandString.indexOf(",");
//                 int R = commandString.substring(paramIndex+1,firstIndex).toInt();
//                 int secondIndex = commandString.lastIndexOf(",");
//                 int G = commandString.substring(firstIndex+1,secondIndex).toInt();
//                 int B = commandString.substring(secondIndex+1).toInt();
//                 // Serial.println(R);
//                 // Serial.println(G);
//                 // Serial.println(B);
//                 rgbLed.rgb(R,G,B);
//                 Serial.println("RGB Colour Updated");
//                 inputString = "";//reset inputstring
//             }
//         }
//         else Serial.println("#Unkown_command_received%");
//     }
// }