#include <Ultrasonic.h>
 
//Define os pinos para o trigger e echo
#define pino_trigger 4
#define pino_echo 5

//Inicializa o sensor nos pinos definidos acima
Ultrasonic ultrasonic(pino_trigger, pino_echo);
 

int motorA1 =6;
int motorA2 =7;
int motorB1 =9;
int motorB2 =8;
boolean parado=false;
boolean esq=false;
boolean dir=false;

void setup (){
 pinMode(motorA1,OUTPUT); 
 pinMode(motorA2,OUTPUT);
 pinMode(motorB1,OUTPUT);
 pinMode(motorB2,OUTPUT);
  Serial.begin(9600);
  Serial.println("Lendo dados do sensor...");
}
void loop(){
  
//Codigo Sensor

//Le as informacoes do sensor, em cm e pol
  float cmMsec;
  long microsec = ultrasonic.timing();
  cmMsec = ultrasonic.convert(microsec, Ultrasonic::CM);
  Serial.print("Distancia em cm: ");
  Serial.println(cmMsec);
  
  //parar os motores com uma distancia de 20cm
  
  if (cmMsec<25){
    dir=false;
    esq=false;
   digitalWrite(motorA1,HIGH);
   digitalWrite(motorA2,HIGH);
   digitalWrite(motorB1,HIGH);
   digitalWrite(motorB2,HIGH);
  Serial.println("Parado ");
  parado=true;
  esq=true;
  }
else{
  parado=false;
   //Tras/Frente
  Serial.println("Andando ");
  digitalWrite(motorA1,HIGH);
  digitalWrite(motorA2,LOW);
  digitalWrite(motorB1,LOW);
  digitalWrite(motorB2,HIGH); 

    
  }
if (parado==true && esq==true){
   digitalWrite(motorA1,HIGH);
   digitalWrite(motorA2,LOW);
   digitalWrite(motorB1,LOW);
   digitalWrite(motorB2,LOW);
   delay(500);
   parado=false;
   esq=true;
  if (esq==true) {
      if(cmMsec>=25){
         dir=false;
         parado=false;
         digitalWrite(motorA1,HIGH);
         digitalWrite(motorA2,LOW);
         digitalWrite(motorB1,LOW);
         digitalWrite(motorB2,LOW);
         esq=false;
    }
       else{
         parado=true;
         dir=true;
         esq=false;
         digitalWrite(motorA1,HIGH);
         digitalWrite(motorA2,HIGH);
         digitalWrite(motorB1,HIGH);
         digitalWrite(motorB2,HIGH);
         Serial.println("Parado ");
     }
  }
  
if ((parado==true) && (dir ==true)){
   digitalWrite(motorA1,LOW);
   digitalWrite(motorA2,LOW);
   digitalWrite(motorB1,LOW);
   digitalWrite(motorB2,HIGH);
   parado=false;
   dir=true;
 
    if (dir==true) {
      if(cmMsec>=25){
       parado=false;
       digitalWrite(motorA1,LOW);
       digitalWrite(motorA2,LOW);
       digitalWrite(motorB1,LOW);
       digitalWrite(motorB2,HIGH);
       delay(500);
       dir=false;
    }
     else{
       
       
       digitalWrite(motorA1,HIGH);
       digitalWrite(motorA2,HIGH);
       digitalWrite(motorB1,HIGH);
       digitalWrite(motorB2,HIGH);
       Serial.println("Parado ");
       parado=true;
     }
  }
  }
}
  
  
  
  
  //else{
  //if (esq==false && cmMsec<25){
  // parado=false;
  // digitalWrite(motorA1,LOW);
   //digitalWrite(motorA2,LOW);
   //digitalWrite(motorB1,LOW);
   //digitalWrite(motorB2,HIGH);
  //}
 


//A1 e B2 Controla o Carrinho Para Frente 

  
  //Para Frente
 //digitalWrite(motorA1,LOW);
 //digitalWrite(motorA2,HIGH);
 //digitalWrite(motorB1,HIGH);
 //digitalWrite(motorB2,LOW);

 
}
