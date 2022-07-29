int ledA=13;
int ledB=12;
int tempo=500;
boolean msg=false;
boolean Pisca_Esq=false;
boolean Pisca_Dir=false;
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
  Serial.println("E PISCA ALERTA PARA ESQUERDA");
  Serial.println("D PISCA ALERTA PARA DIREITA");
  Serial.println("C PISCA ALERTA DUPLO");
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
    Pisca_Esq=false;
    Pisca_Dir=false;  
  }
  //APAGA O LED A
  if (letra=='g'){
    digitalWrite(ledA, LOW);
    Serial.println("ledA APAGADO");
    Pisca_Esq=false;
    Pisca_Dir=false;  
  }
  //ACENDE O LED B
   if (letra=='h'){
    //saida de dados
    digitalWrite(ledB, HIGH);
    Serial.println("ledB ACESO");
    Pisca_Esq=false;
    Pisca_Dir=false;  
  }
  //APAGA O LED B
  if (letra=='j'){
    digitalWrite(ledB, LOW);
    Serial.println("ledB APAGADO");
    Pisca_Esq=false;
    Pisca_Dir=false;  
  }
  //ACENDE O LED A e B
  if (letra=='k'){
    //saida de dados
    digitalWrite(ledA, HIGH);
    digitalWrite(ledB, HIGH);
    Serial.println("ledA e ledB ACESOS");
    Pisca_Esq=false;
    Pisca_Dir=false;  
  }
   //APAGA O LED A e B
  if (letra=='l'){
    digitalWrite(ledA, LOW);
    digitalWrite(ledB, LOW);
    Serial.println("ledA e ledB APAGADOS");
    Pisca_Esq=false;
    Pisca_Dir=false;  
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
    Pisca_Esq=false;
    Pisca_Dir=false;  
  }
   //SETA PARA ESQUERDA
    if (letra=='x'){
    Serial.println("Seta Para Esquerda Ligada");
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
    Pisca_Esq=false;
    Pisca_Dir=false;  
  }
  
  //SETA PARA ESQUERDA
  if(letra=='e'){
    Pisca_Esq=true;
    Pisca_Dir=false;
  }
  
  if ((Pisca_Esq==true)&&(Pisca_Dir==false)){
    Serial.println("Seta Para Esquerda Ligada");
    digitalWrite(ledA, LOW);
    digitalWrite(ledB, LOW);
    delay(tempo);
    digitalWrite(ledA, HIGH);
    digitalWrite(ledB, LOW);
    delay(tempo);
    msg=true;
  }
  
  //SETA PARA DIREITA
  if(letra=='d'){
    Pisca_Esq=false;
    Pisca_Dir=true;  
  }
  
  if ((Pisca_Esq==false)&&(Pisca_Dir==true)){
    Serial.println("Seta Para Direita Ligada");
    digitalWrite(ledA, LOW);
    digitalWrite(ledB, LOW);
    delay(tempo);
    digitalWrite(ledA, LOW);
    digitalWrite(ledB, HIGH);
    delay(tempo);
    msg=true;
  }

  //SETA PARA ESQUERDA E DIREITA   
  if(letra=='c'){
    Pisca_Esq=true;
    Pisca_Dir=true;  
  }

  if ((Pisca_Esq==true)&&(Pisca_Dir==true)){
    Serial.println("Setas Esquerda e Direita Ligadas");
    digitalWrite(ledA, LOW);
    digitalWrite(ledB, LOW);
    delay(tempo);
    digitalWrite(ledA, HIGH);
    digitalWrite(ledB, HIGH);
    delay(tempo);
    msg=true;
  }
  
  if ((Pisca_Esq==false)&&(Pisca_Dir==false)){
    if(msg==true){
      Serial.println("Setas Esquerda e Direita Desligadas");
      msg=false;
    }
    digitalWrite(ledA, LOW);
    digitalWrite(ledB, LOW);    
  }

}
