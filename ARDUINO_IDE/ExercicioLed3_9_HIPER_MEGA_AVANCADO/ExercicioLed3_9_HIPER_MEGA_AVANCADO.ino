int L4 = 12;
int L3 = 11;
int L2 = 10;
int L1 = 9;
int Velocidade=50;
int Velocidade2=50;
int Velocidade3=1000;

void setup() {                
  pinMode(L1, OUTPUT);     
  pinMode(L2, OUTPUT);     
  pinMode(L3, OUTPUT);     
  pinMode(L4, OUTPUT);     
}

void loop() {
  delay(Velocidade2);
  
  digitalWrite(L1, HIGH); 
  delay(Velocidade);            
  digitalWrite(L2, HIGH); 
  delay(Velocidade);            
  digitalWrite(L3, HIGH); 
  delay(Velocidade);            
  digitalWrite(L4, HIGH); 
  delay(Velocidade);            
  digitalWrite(L1, LOW);   
  delay(Velocidade);            
  digitalWrite(L2, LOW);  
  delay(Velocidade);            
  digitalWrite(L3, LOW);  
  delay(Velocidade);           
  digitalWrite(L4, LOW);   
  delay(Velocidade);                     
  Velocidade2+=50;
  
  delay(Velocidade3);
  
  digitalWrite(L4, HIGH);   
  delay(Velocidade);   
  digitalWrite(L3, HIGH); 
  delay(Velocidade);            
  digitalWrite(L2, HIGH); 
  delay(Velocidade);            
  digitalWrite(L1, HIGH); 
  delay(Velocidade);            
  digitalWrite(L4, LOW);   
  delay(Velocidade);            
  digitalWrite(L3, LOW);  
  delay(Velocidade);            
  digitalWrite(L2, LOW);  
  delay(Velocidade);            
  digitalWrite(L1, LOW);   
  delay(Velocidade);   
  
  if(Velocidade3<=0)
  {
    Velocidade3=1000;
  }
  else
  {
    Velocidade3-=50;
  }
  
  /*
   digitalWrite(L1, HIGH); 
  delay(150);            
  digitalWrite(L2, HIGH); 
  delay(150);            
  digitalWrite(L3, HIGH); 
  delay(150);            
  digitalWrite(L4, HIGH); 
  delay(150);            
  digitalWrite(L1, LOW);   
  delay(150);            
  digitalWrite(L2, LOW);  
  delay(150);            
  digitalWrite(L3, LOW);  
  delay(150);           
  digitalWrite(L4, LOW);   
  delay(150);                     
  
  digitalWrite(L4, HIGH);   
  delay(150); 
  
  digitalWrite(L3, HIGH); 
  delay(150);            
  digitalWrite(L2, HIGH); 
  delay(150);            
  digitalWrite(L1, HIGH); 
  delay(150);            
  digitalWrite(L4, LOW);   
  delay(150);            
  digitalWrite(L3, LOW);  
  delay(150);            
  digitalWrite(L2, LOW);  
  delay(150);            
  digitalWrite(L1, LOW);   
  delay(150);   
  */
}
