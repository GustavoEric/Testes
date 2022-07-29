//variavel para um contador simples 
int contador;
int led13=13;

void setup(){
  pinMode(led13,OUTPUT);
  Serial.begin(9600);
  }
  
void loop(){
  contador=contador+1;
  digitalWrite(led13,HIGH);
  Serial.println(contador);
  delay(1000);
  digitalWrite(led13,LOW);
  }
