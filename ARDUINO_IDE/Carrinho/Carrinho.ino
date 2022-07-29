int motorA1 =6;
int motorA2 =7;
int motorB1 =9;
int motorB2 =8;

void setup (){
 pinMode(motorA1,OUTPUT); 
 pinMode(motorA2,OUTPUT);
 pinMode(motorB1,OUTPUT);
 pinMode(motorB2,OUTPUT);
}


void loop(){
  //Para Frente
 delay(5000);
 digitalWrite(motorA1,LOW);
 digitalWrite(motorA2,HIGH);
 digitalWrite(motorB1,HIGH);
 digitalWrite(motorB2,LOW);
  delay(10000);
  //Tras
 digitalWrite(motorA1,HIGH);
 digitalWrite(motorA2,LOW);
 digitalWrite(motorB1,LOW);
 digitalWrite(motorB2,HIGH); 
 
 //Desliga
 delay(10000);
 digitalWrite(motorA1,HIGH);
 digitalWrite(motorA2,HIGH);
 digitalWrite(motorB1,HIGH);
 digitalWrite(motorB2,HIGH);
 
 //Para Frente
 delay(5000);
 digitalWrite(motorA1,LOW);
 digitalWrite(motorA2,HIGH);
 digitalWrite(motorB1,HIGH);
 digitalWrite(motorB2,LOW);
  delay(1000);
  
 //Tras
 digitalWrite(motorA1,HIGH);
 digitalWrite(motorA2,LOW);
 digitalWrite(motorB1,LOW);
 digitalWrite(motorB2,HIGH); 
  delay(1000); 
//Para Frente
 digitalWrite(motorA1,LOW);
 digitalWrite(motorA2,HIGH);
 digitalWrite(motorB1,HIGH);
 digitalWrite(motorB2,LOW);
}
