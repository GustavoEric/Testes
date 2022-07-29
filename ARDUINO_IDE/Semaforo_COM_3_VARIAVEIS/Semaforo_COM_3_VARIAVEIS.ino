int led_verde =13;
int led_amarelo =12;
int led_vermelho =11;
boolean seg_verde =true;
boolean seg_amarelo =false;
boolean seg_vermelho =false;
int sinal_verde=8;
int sinal_amarelo=4;
int sinal_vermelho=6;

void setup() {

  Serial.println("LED VERDE");
  pinMode (led_verde, OUTPUT);
  pinMode (led_amarelo, OUTPUT);
  pinMode (led_vermelho, OUTPUT);
  Serial.begin(9600);
  Serial.println(" P DIMINUI O TEMPO DO SINAL ");
}
void loop() {
  char letra = Serial.read();
  if ((seg_verde==true)and(sinal_verde>0)){
  digitalWrite (led_verde, HIGH);
  digitalWrite (led_amarelo, LOW);
  digitalWrite (led_vermelho, LOW);
  Serial.println(sinal_verde);
  sinal_verde=sinal_verde-1;
  sinal_vermelho=6;
  delay(1000);
  }

  if (sinal_verde==0){
    seg_amarelo=true;
    seg_verde=false;
  }
  if ((seg_amarelo==true)and(sinal_amarelo>0)){
    sinal_verde=8;
    Serial.println("LED AMARELO");
    Serial.println(sinal_amarelo);
    sinal_amarelo=sinal_amarelo-1;
    digitalWrite (led_verde, LOW);
    digitalWrite (led_amarelo, HIGH);
    digitalWrite (led_vermelho, LOW);
    delay(1000);
  }

   if (sinal_amarelo==0){
    seg_amarelo=false;
    seg_vermelho=true;
  }
    if((seg_vermelho==true)and(sinal_vermelho)){
    sinal_amarelo=4;
    Serial.println("LED VEMELHO");
    Serial.println(sinal_vermelho);
    sinal_vermelho=sinal_vermelho-1;
    digitalWrite (led_verde, LOW);
    digitalWrite (led_amarelo, LOW);
    digitalWrite (led_vermelho, HIGH);
    delay(1000);
  }
  if (sinal_vermelho==0){
    seg_verde=true;
    seg_vermelho=false;
    
  }
   if (letra=='p'){
    sinal_verde=sinal_verde-1;
    delay(1000);
}
}
