int led = 12;
int led2 = 11;
int led3 = 10;
char letra;

// the setup routine runs once when you press reset:
void setup() {                
  // initialize the digital pin as an output.
  pinMode(led, OUTPUT); 
  pinMode(led2, OUTPUT); 
  pinMode(led3, OUTPUT);
  Serial.begin(9600);  
}
void loop(){
  letra=Serial.read();
  if (letra=='a'){
    digitalWrite(led,HIGH);
    digitalWrite(led2,LOW);
    digitalWrite(led3,LOW);
  }
   else if (letra=='s'){
    digitalWrite(led,LOW);
    digitalWrite(led2,HIGH);
    digitalWrite(led3,LOW);
  }
  if (letra=='d'){
    digitalWrite(led,LOW);
    digitalWrite(led2,LOW);
    digitalWrite(led3,HIGH);
  }
   else if (letra=='f'){
    digitalWrite(led,LOW);
    digitalWrite(led2,LOW);
    digitalWrite(led3,LOW);
  }
}

