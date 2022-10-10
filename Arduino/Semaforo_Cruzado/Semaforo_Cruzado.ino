
int led = 13;
int led2 = 12;
int led3 = 11;
int led4 = 10;
int led5 = 9;
int led6 = 8;
int semaforo= 0;
int tempoVerde = 5000;
int tempoAmarelo = 2000;
int tempoVermelho = 3000;
// the setup routine runs once when you press reset:
void setup() {                
  // initialize the digital pin as an output.
  Serial.begin(9600);
  pinMode(led, OUTPUT); 
  pinMode(led2, OUTPUT); 
  pinMode(led3, OUTPUT); 
  pinMode(led4, OUTPUT); 
  pinMode(led5, OUTPUT); 
  pinMode(led6, OUTPUT); 
}


// the loop routine runs over and over again forever:
void loop() {
  semaforo=semaforo+1;
  if (semaforo== 1){
    //Led Verde
    digitalWrite(led, HIGH);
    digitalWrite(led4, LOW);
    
    //Led Amarelo
    digitalWrite(led2, LOW);
    digitalWrite(led5, LOW);
    
    //Led Vermelho
    digitalWrite(led3, LOW);
    digitalWrite(led6, HIGH);
    delay(tempoVerde);
  }
  else if (semaforo== 2){
    //Led Verde
    digitalWrite(led, LOW);
    digitalWrite(led4, LOW);
    
    //Led Amarelo
    digitalWrite(led2, HIGH);
    digitalWrite(led5, LOW);
    
    //Led Vermelho
    digitalWrite(led3, LOW);
    digitalWrite(led6, HIGH);
    delay(tempoAmarelo);
  }
  else if (semaforo== 3){
    //Led Verde
    digitalWrite(led, LOW);
    digitalWrite(led4, HIGH);
    //Led Amarelo
    digitalWrite(led2, LOW);
    digitalWrite(led5, LOW);
    
    //Led Vermelho
    digitalWrite(led3, HIGH);
    digitalWrite(led6, LOW);
    delay(tempoVermelho);
  }
  else if (semaforo== 4){
    //Led Verde
    digitalWrite(led, LOW);
    digitalWrite(led4, LOW);
    
    //Led Amarelo
    digitalWrite(led2, LOW);
    digitalWrite(led5, HIGH);
    
    //Led Vermelho
    digitalWrite(led3, HIGH);
    digitalWrite(led6, LOW);
    delay(tempoAmarelo);
  }
  else {
    semaforo=0;
  }
    
    
}
