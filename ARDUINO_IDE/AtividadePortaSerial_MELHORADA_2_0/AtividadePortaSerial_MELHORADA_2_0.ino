int ledA=13;
int ledB=12;
int ledC=11;
int tempo=1000;
boolean seta_direita=false;
boolean seta_esquerda=false;
boolean pisca_alerta=false;

void setup(){
  Serial.begin(9600);
  pinMode(ledA,OUTPUT);
  pinMode(ledB,OUTPUT);
  pinMode(ledC,OUTPUT);
  Serial.println("F ACENDE O LED A");
  Serial.println("G APAGA O LED A");
  Serial.println("H ACENDE O LED B");
  Serial.println("J APAGA O LED B");
  Serial.println("K ACENDE O LED A e B");
  Serial.println("L APAGA O LED A e B");
  Serial.println("Z SETA PARA DIREITA");
  Serial.println("X SETA PARA ESQUERDA");
  Serial.println("C PARAR SETA PARA DIREITA");
  Serial.println("V PARAR SETA PARA ESQUERDA");
  Serial.println("B LIGAR PISCA ALERTA");
  Serial.println("N PARAR PISCA ALERTA");
}

void loop(){
  
  char letra = Serial.read();
  //verifica a letra que foi digitada
  if ((letra=='f')||(letra=='F')){
   //ACENDE O LED A
    digitalWrite(ledA, HIGH);
    Serial.println("ledA ACESO");
  }
  //APAGA O LED A
  if ((letra=='g')||(letra=='G')){
    digitalWrite(ledA, LOW);
    Serial.println("ledA APAGADO");
  }
  //ACENDE O LED B
   if ((letra=='h')||(letra=='H')){
    //saida de dados
    digitalWrite(ledB, HIGH);
    Serial.println("ledB ACESO");
  }
  //APAGA O LED B
  if ((letra=='j')||(letra=='J')){
    digitalWrite(ledB, LOW);
    Serial.println("ledB APAGADO");
  }
  //ACENDE O LED A e B
  if ((letra=='k')||(letra=='K')){
    //saida de dados
    digitalWrite(ledA, HIGH);
    digitalWrite(ledB, HIGH);
    Serial.println("ledA e ledB ACESOS");
  }
   //APAGA O LED A e B
  if ((letra=='l')||(letra=='L')){
    digitalWrite(ledA, LOW);
    digitalWrite(ledB, LOW);
    Serial.println("ledA e ledB APAGADOS");
  }
   //SETA PARA DIREITA
  if ((letra=='z')||(letra=='Z')){
    seta_direita=true;
  }
    if (seta_direita==true){;
    seta_esquerda=false;
    Serial.println("Seta Para Direita Ligada");
    digitalWrite(ledA, LOW);
    digitalWrite(ledB, LOW);
    delay(tempo);
    digitalWrite(ledA, HIGH);
    digitalWrite(ledB, LOW);
  }
  //PARAR SETA PARA DIREITA
  if ((letra=='c')||(letra=='C')){
    seta_direita=false;
    Serial.println("Seta Para Direita Desligada");
  }
   //SETA PARA ESQUERDA
    if ((letra=='x')||(letra=='X')){
    seta_esquerda=true;
    }
    if (seta_esquerda==true){
    seta_direita=false;
    Serial.println("Seta Para Esqueda Ligada");
    digitalWrite(ledA, LOW);
    digitalWrite(ledB, LOW);
    delay(tempo);
    digitalWrite(ledA, LOW);
    digitalWrite(ledB, HIGH);
  }
   //PARAR SETA PARA ESQUERDA
  if ((letra=='v')||(letra=='V')){
    seta_esquerda=false;
    Serial.println("Seta Para Esquerda Desligada");
  }
  //LIGAR PISCA ALERTA
  if ((letra=='b')||(letra=='B')){
    pisca_alerta=true;
  }
    if (pisca_alerta==true){
    Serial.println("Pisca Alerta Ligado");
    delay(tempo);
    digitalWrite(ledA, LOW);
    digitalWrite(ledB, LOW);
    delay(tempo);
    digitalWrite(ledA, HIGH);
    digitalWrite(ledB, HIGH);  
}
//DESLIGAR PISCA ALERTA
  if ((letra=='n')||(letra=='N')){
    pisca_alerta=false;
    Serial.println("Pisca Alerta Desligado");
}
 
}  
