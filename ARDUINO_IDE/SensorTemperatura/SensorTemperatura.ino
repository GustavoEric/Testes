//Declaracao de variaveis
int led=13;
int sensorPin = A0;
float valorAnalog=0;
float tensao=0;
float temperatura=0;
float maiortm,tm;
void setup() {
  Serial.begin(9600);
  pinMode(led,OUTPUT);

}

void loop() {
  valorAnalog = analogRead(sensorPin);
  tensao=(valorAnalog*5)/1023;
  temperatura=tensao/0.010;
  
  Serial.print(temperatura);
  delay(100);
  
  if(temperatura<25.90){
    digitalWrite(led,HIGH);
  }
  else{ 
    digitalWrite(led,LOW);
  }
}
