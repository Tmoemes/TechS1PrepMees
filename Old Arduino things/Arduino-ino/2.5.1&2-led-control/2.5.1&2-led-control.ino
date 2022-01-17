int dLed = 2;
int aLed = 3;
int dIn = 4;
int aIn = A0;

void setup(){

    //preparing needed pins: 
    pinMode(dLed,OUTPUT);//digital
    pinMode(aLed,OUTPUT);//digital pwm
    pinMode(dIn,INPUT);//digital in
    pinMode(aIn,INPUT);//analog in

}

void loop(){
    analogWrite(aLed,analogRead(aIn)/4);
    digitalWrite(dLed,digitalRead(dIn));
}