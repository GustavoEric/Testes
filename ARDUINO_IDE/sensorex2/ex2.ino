//Carrega a biblioteca do sensor ultrassonico
#include <Ultrasonic.h>
 
int led=13;

//Define os pinos para o trigger e echo
#define pino_trigger 4
#define pino_echo 5
 
//Inicializa o sensor nos pinos definidos acima
Ultrasonic ultrasonic(pino_trigger, pino_echo);
 
void setup()
{
  pinMode(led, OUTPUT);
  Serial.begin(9600);
  Serial.println("Lendo dados do sensor...");
}
 
void loop()
{
  //Le as informacoes do sensor, em cm e pol
  float cmMsec;
  long microsec = ultrasonic.timing();
  cmMsec = ultrasonic.convert(microsec, Ultrasonic::CM);
  
  if(cmMsec>20){
    digitalWrite(led, HIGH);
    Serial.println("1");
    delay(1000); 
  }
  if((cmMsec>10) || (cmMsec<20)){
    digitalWrite(led, LOW);
        Serial.println("2");
    delay(500);
  }
   if((cmMsec>5) || (cmMsec<10)){
    digitalWrite(led, LOW);
        Serial.println("3");
    delay(300);
  }
 // >20 1
  //10 e 20 0.5
  //5 e 10  0.3
  
  //Exibe informacoes no serial monitor
  //Serial.print("Distancia em cm: ");
  Serial.println(cmMsec);

} 

