int ledA=13;
int ledB=12;
int tempo=500;
char parar;

void setup(){
  Serial.begin(9600);
  pinMode(ledA,OUTPUT);
  pinMode(ledB,OUTPUT);
  Serial.println("F ACENDE O LED A");
  Serial.println("G APAGA O LED A");
  Serial.println("H ACENDE O LED B");
  Serial.println("J APAGA O LED B");
  Serial.println("K ACENDE O LED A e B");
  Serial.println("L APAGA O LED A e B");
  Serial.println("Z SETA PARA DIREITA");
  Serial.println("X SETA PARA ESQUERDA");
}

void loop(){
  parar = ' ';
  
  //entrada de dados
  char letra = Serial.read();
  //verifica a letra que foi digitada
  if (letra=='f'){
    //saida de dados
   //ACENDE O LED A
    digitalWrite(ledA, HIGH);
    Serial.println("ledA ACESO");
  }
  //APAGA O LED A
  if (letra=='g'){
    digitalWrite(ledA, LOW);
    Serial.println("ledA APAGADO");
  }
  //ACENDE O LED B
   if (letra=='h'){
    //saida de dados
    digitalWrite(ledB, HIGH);
    Serial.println("ledB ACESO");
  }
  //APAGA O LED B
  if (letra=='j'){
    digitalWrite(ledB, LOW);
    Serial.println("ledB APAGADO");
  }
  //ACENDE O LED A e B
  if (letra=='k'){
    //saida de dados
    digitalWrite(ledA, HIGH);
    digitalWrite(ledB, HIGH);
    Serial.println("ledA e ledB ACESOS");
  }
   //APAGA O LED A e B
  if (letra=='l'){
    digitalWrite(ledA, LOW);
    digitalWrite(ledB, LOW);
    Serial.println("ledA e ledB APAGADOS");
  }
   //SETA PARA DIREITA
  if (letra=='z'){
    Serial.println("Seta Para Direita Ligada");
    digitalWrite(ledA, LOW);
    digitalWrite(ledB, LOW);
    delay(tempo);
    digitalWrite(ledA, HIGH);
    digitalWrite(ledB, LOW);
    delay(tempo);
    digitalWrite(ledA, LOW);
    digitalWrite(ledB, LOW);
    delay(tempo);
    digitalWrite(ledA, LOW);
    digitalWrite(ledB, HIGH);
    delay(tempo);
    digitalWrite(ledA, LOW);
    digitalWrite(ledB, LOW);
  }
   //SETA PARA ESQUERDA
    if (letra=='x'){
    Serial.println("Seta Para Esqueda Ligada");
    digitalWrite(ledA, LOW);
    digitalWrite(ledB, LOW);
    delay(tempo);
    digitalWrite(ledA, LOW);
    digitalWrite(ledB, HIGH);
    delay(tempo);
    digitalWrite(ledA, LOW);
    digitalWrite(ledB, LOW);
    delay(tempo);
    digitalWrite(ledA, LOW);
    digitalWrite(ledB, HIGH);
    delay(tempo);
    digitalWrite(ledA, LOW);
    digitalWrite(ledB, LOW);
  }
}
