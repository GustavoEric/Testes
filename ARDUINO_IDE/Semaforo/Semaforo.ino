
int led = 13;
int led2 = 12;
int led3 = 11;
int semaforo= 0;
// the setup routine runs once when you press reset:
void setup() {                
  // initialize the digital pin as an output.
  pinMode(led, OUTPUT); 
  pinMode(led2, OUTPUT); 
  pinMode(led3, OUTPUT); 
}


// the loop routine runs over and over again forever:
void loop() {
  semaforo=semaforo+1;
  if (semaforo== 1){
    digitalWrite(led, HIGH);
    digitalWrite(led2, LOW);
    digitalWrite(led3, LOW);
    delay(2000);
  }
  else if (semaforo== 2){
    digitalWrite(led, LOW);
    digitalWrite(led2, HIGH);
    digitalWrite(led3, LOW);
    delay(2000);
  }
  else if (semaforo== 3){
    digitalWrite(led, LOW);
    digitalWrite(led2, LOW);
    digitalWrite(led3, HIGH);
    delay(2000);
  }
  else {
    semaforo=0;
  }
    
    
}
