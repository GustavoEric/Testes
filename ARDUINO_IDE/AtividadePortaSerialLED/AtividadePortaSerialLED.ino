int ledA=13;
int ledB=12;
char  mem=' ';

void setup(){
  Serial.begin(9600);
  pinMode(ledA,OUTPUT);
  pinMode(ledB,OUTPUT);
}

void loop(){
  
  //entrada de dados
  char letra = Serial.read();  
  
  //verifica a letra que foi digitada
  if (letra=='f'){
    //saida de dados
    digitalWrite(ledA, HIGH);
  }
  if (letra=='g'){
    digitalWrite(ledA, LOW);
  }
   if (letra=='h'){
    //saida de dados
    digitalWrite(ledB, HIGH);
  }
  if (letra=='j'){
    digitalWrite(ledB, LOW);
  }
  
  if (letra=='k'){
    //saida de dados
    digitalWrite(ledA, HIGH);
    digitalWrite(ledB, HIGH);
  }
  if (letra=='l'){
    digitalWrite(ledA, LOW);
    digitalWrite(ledB, LOW);
  }
  
  if (letra=='z'){
    digitalWrite(ledA, HIGH);
    digitalWrite(ledB, LOW);
  }
  
  if (letra=='x'){
    digitalWrite(ledA, LOW);
    digitalWrite(ledB, HIGH);
  }
  
  if (letra=='c'){
    digitalWrite(ledA, LOW);
    digitalWrite(ledB, HIGH);
    
    delay(500);
    digitalWrite(ledA, HIGH);
    digitalWrite(ledB, LOW);
    delay(500);
  }
  
  if (letra=='v'){
    digitalWrite(ledA, LOW);
    digitalWrite(ledB, HIGH);
    
    delay(500);
    digitalWrite(ledA, HIGH);
    digitalWrite(ledB, LOW);
    delay(500);
  }
  
  if (letra=='b'){
    digitalWrite(ledA, HIGH);
    digitalWrite(ledB, HIGH);
    
    delay(500);
    digitalWrite(ledA, LOW);
    digitalWrite(ledB, LOW);
    delay(500);
  }
}

//f
//g
