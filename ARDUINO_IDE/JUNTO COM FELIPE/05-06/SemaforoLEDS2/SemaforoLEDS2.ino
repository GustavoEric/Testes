int ledVermelho = 13;
int ledAma = 12;
int ledVer = 11;


int segundo=1000;
int tempo=8;
boolean red=false;
boolean green=true;
boolean yellow=false;

void setup() {                
  Serial.begin(9600);
  pinMode(ledVermelho, OUTPUT);     
  pinMode(ledAma, OUTPUT);     
  pinMode(ledVer, OUTPUT);     
}

void loop() {
  
  
  //tempo -  8 vermelho, 4 amarelo, 6 verde

  if(tempo>=0){
    
    if(red==true){
      digitalWrite(ledVermelho, HIGH);        
      digitalWrite(ledAma, LOW);      
      digitalWrite(ledVer, LOW);    
      delay(8*segundo);              
      red=false;
      green=true;
      yellow=false;
    }

    if(green==true){
      digitalWrite(ledVermelho, LOW);                      
      digitalWrite(ledAma, LOW);      
      digitalWrite(ledVer, HIGH);    
      delay(6*segundo);
      red=false;
      green=false;
      yellow=true;
    }
    
    if(yellow==true){
      digitalWrite(ledVermelho, LOW);                   
      digitalWrite(ledAma, HIGH);      
      digitalWrite(ledVer, LOW);    
      delay(4*segundo);  
      red=true;
      green=false;
      yellow=false;
    }
    tempo--;
  }
  else{
    if(red==true){
      tempo=8;
    }
    if(yellow==true){
      tempo=4;
    }
    if(green==true){
      tempo=6;
    }
  }

}
