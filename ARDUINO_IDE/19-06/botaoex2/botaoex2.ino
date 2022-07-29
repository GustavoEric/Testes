boolean ledAtivo=false;
int led=13;
int pin_envia_sinal=12;
int pin_recebe_sinal=8;

void setup()
{
  pinMode(led,OUTPUT);
  pinMode(pin_envia_sinal,OUTPUT);
  pinMode(pin_recebe_sinal,INPUT);
  Serial.begin(9600);
  //envia um sinal continuo
  digitalWrite(pin_envia_sinal,HIGH);
  
}

void loop()
{
  //variavel temporaria que recebe o sinal
  int recebe_sinal=digitalRead(pin_recebe_sinal);
  Serial.println(recebe_sinal);
  
  if(recebe_sinal==1){
    ledAtivo=true;
  
    if(ledAtivo==true){  
      digitalWrite(led,HIGH);
      ledAtivo=false;
    }  
    else{
       digitalWrite(led,LOW);
       ledAtivo=true;
    }
  }
}

  
