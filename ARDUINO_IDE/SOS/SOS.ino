int led1=13;
int led2=12;
int led3=11;
int tempo_pausa=2000;
int tempo_rapido=500;
int tempo_lento=1000;
boolean leds_on=false;

void setup() {
 Serial.begin(9600);
  pinMode(led1,OUTPUT);
  pinMode(led2,OUTPUT);
  pinMode(led3,OUTPUT);
  Serial.println("LETRA S LIGA SOS");
  Serial.println("LETRA P PARA O SOS");
}

void loop() {
char letra = Serial.read();
    if ((letra=='s')||(letra=='S')){
    leds_on=true;
      }
    if (leds_on==true){
     //LETRA S
    //Piscada Rápida
    digitalWrite(led1,HIGH);
    digitalWrite(led2,HIGH);
    digitalWrite(led3,HIGH);
    delay(tempo_rapido);
    digitalWrite(led1,LOW);
    digitalWrite(led2,LOW);
    digitalWrite(led3,LOW);
    delay(tempo_rapido);
    //Piscada Rápida
    digitalWrite(led1,HIGH);
    digitalWrite(led2,HIGH);
    digitalWrite(led3,HIGH);
    delay(tempo_rapido);
    digitalWrite(led1,LOW);
    digitalWrite(led2,LOW);
    digitalWrite(led3,LOW);
    delay(tempo_rapido);
    //Piscada Rápida
    digitalWrite(led1,HIGH);
    digitalWrite(led2,HIGH);
    digitalWrite(led3,HIGH);
    delay(tempo_rapido);
    digitalWrite(led1,LOW);
    digitalWrite(led2,LOW);
    digitalWrite(led3,LOW);
    delay(tempo_pausa);
     //LETRA O
    //Piscada Lenta
    digitalWrite(led1,HIGH);
    digitalWrite(led2,HIGH);
    digitalWrite(led3,HIGH);
    delay(tempo_lento);
    digitalWrite(led1,LOW);
    digitalWrite(led2,LOW);
    digitalWrite(led3,LOW);
    delay(tempo_rapido);
     //Piscada Lenta
    digitalWrite(led1,HIGH);
    digitalWrite(led2,HIGH);
    digitalWrite(led3,HIGH);
    delay(tempo_lento);
    digitalWrite(led1,LOW);
    digitalWrite(led2,LOW);
    digitalWrite(led3,LOW);
    delay(tempo_rapido);
     //Piscada Lenta
    digitalWrite(led1,HIGH);
    digitalWrite(led2,HIGH);
    digitalWrite(led3,HIGH);
    delay(tempo_lento);
    digitalWrite(led1,LOW);
    digitalWrite(led2,LOW);
    digitalWrite(led3,LOW);
    delay(tempo_pausa);
     //LETRA S
    //Piscada Rápida
    digitalWrite(led1,HIGH);
    digitalWrite(led2,HIGH);
    digitalWrite(led3,HIGH);
    delay(tempo_rapido);
    digitalWrite(led1,LOW);
    digitalWrite(led2,LOW);
    digitalWrite(led3,LOW);
    delay(tempo_rapido);
    //Piscada Rápida
    digitalWrite(led1,HIGH);
    digitalWrite(led2,HIGH);
    digitalWrite(led3,HIGH);
    delay(tempo_rapido);
    digitalWrite(led1,LOW);
    digitalWrite(led2,LOW);
    digitalWrite(led3,LOW);
    delay(tempo_rapido);
    //Piscada Rápida
    digitalWrite(led1,HIGH);
    digitalWrite(led2,HIGH);
    digitalWrite(led3,HIGH);
    delay(tempo_rapido);
    digitalWrite(led1,LOW);
    digitalWrite(led2,LOW);
    digitalWrite(led3,LOW);
    delay(tempo_pausa);
    }
    if ((letra=='p')||(letra=='P')){
    leds_on=false;
}
}
