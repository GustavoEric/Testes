#include <IRremote.h>
 
IRrecv receptor(10);
 
decode_results resultado;

int led=13;
 
void setup()
{
  Serial.begin(9600);
  receptor.enableIRIn();
  pinMode(led,OUTPUT);
}
void loop() 
{
  if (receptor.decode(&resultado)) 
  {
    Serial.println(resultado.value, HEX);
    //Verifica o codigo que foi recebido 
    
    receptor.resume(); 
  }
  delay(100);
  
  if (resultado.value==0xF7C03F){
    digitalWrite(led,HIGH);
  }
  else if (resultado.value==0xF740BF){
    digitalWrite(led,LOW);
  //off F740BF
  }
  else if (resultado.value==0xF7C837){
     digitalWrite(led,HIGH);
     delay(100);
     digitalWrite(led,LOW);
  }
}
