#include <Arduino.h>
  int layer[4]={A3,A2,A1,A0}; //initializing and declaring led layers
  int column[16]={13,12,11,10,9,8,7,6,5,4,3,2,1,0,A5,A4}; //initializing and declaring led rows
  int time = 250;

  
 
void setup()
{
  
  for(int i = 0; i<16; i++)   
  {
    pinMode(column[i], OUTPUT);  //setting rows to ouput
  }
  
  for(int i = 0; i<4; i++)
  {
    pinMode(layer[i], OUTPUT);  //setting layers to output
  }
  
  randomSeed(analogRead(10));  //seeding random for random pattern
}

void loop()
{
    turnEverythingOff();
    digitalWrite(column[0],0);
    digitalWrite(column[2],0);
    digitalWrite(column[5],0);
    digitalWrite(column[7],0);
    digitalWrite(column[8],0);
    digitalWrite(column[10],0);
    digitalWrite(column[13],0);
    digitalWrite(column[15],0);
    digitalWrite(layer[0],1);
    digitalWrite(layer[2],1);
    turnEverythingOff();
    digitalWrite(column[1],0);
    digitalWrite(column[3],0);
    digitalWrite(column[4],0);
    digitalWrite(column[6],0);
    digitalWrite(column[9],0);
    digitalWrite(column[11],0);
    digitalWrite(column[12],0);
    digitalWrite(column[14],0);
    digitalWrite(layer[1],1);
    digitalWrite(layer[3],1);
    turnEverythingOff();
    digitalWrite(column[0],0);
    digitalWrite(column[2],0);
    digitalWrite(column[5],0);
    digitalWrite(column[7],0);
    digitalWrite(column[8],0);
    digitalWrite(column[10],0);
    digitalWrite(column[13],0);
    digitalWrite(column[15],0);
    digitalWrite(layer[1],1);
    digitalWrite(layer[3],1);
    turnEverythingOff();
    digitalWrite(column[1],0);
    digitalWrite(column[3],0);
    digitalWrite(column[4],0);
    digitalWrite(column[6],0);
    digitalWrite(column[9],0);
    digitalWrite(column[11],0);
    digitalWrite(column[12],0);
    digitalWrite(column[14],0);
    digitalWrite(layer[0],1);
    digitalWrite(layer[2],1);
  }
  
//turn all off
void turnEverythingOff()
 {
   for(int i = 0; i<16; i++)
   {
     digitalWrite(column[i], 1);
   }
   for(int i = 0; i<4; i++)
   {
     digitalWrite(layer[i], 0);
   }
 }
 
//turn all on
void turnEverythingOn()
{
  for(int i = 0; i<16; i++)
  {
    digitalWrite(column[i], 0);
  }
  //turning on layers
  for(int i = 0; i<4; i++)
  {
    digitalWrite(layer[i], 1);
  }
}
//turn even on
void turnEvenOn()
{
  for(int i = 1; i<16; i+2)
  {
    digitalWrite(column[i], 0);
  }
  //turning on layers
  for(int i = 1; i<4; i+2)
  {
    digitalWrite(layer[i], 1);
  }
}
//turn columns off
void turnColumnsOff()
{
  for(int i = 0; i<16; i++)
  {
    digitalWrite(column[i], 1);
  }
}

void flickerOn()
{
  int i = 150;
  while(i != 0)
  {
    turnEverythingOn();
    delay(i);
    turnEverythingOff();
    delay(i);
    i-= 5;
  }
}

void flickerOff()
{
  turnEverythingOn();
  for(int i = 0; i!= 150; i+=5)
  {
    turnEverythingOff();
    delay(i+50);
    turnEverythingOn();
    delay(i);
  }
}