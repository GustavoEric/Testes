int L4 = 12;
int L3 = 11;
int L2 = 10;
int L1 = 9;
int Velocidade=500;

void setup() {                
  pinMode(L1, OUTPUT);     
  pinMode(L2, OUTPUT);     
  pinMode(L3, OUTPUT);     
  pinMode(L4, OUTPUT);     
}

void loop() {
  
  //0 0000
  digitalWrite(L1, LOW); 
  digitalWrite(L2, LOW);  
  digitalWrite(L3, LOW); 
  digitalWrite(L4, LOW);  

  delay(Velocidade);            
  
  //1 0001
  digitalWrite(L1, LOW); 
  digitalWrite(L2, LOW);        
  digitalWrite(L3, LOW); 
  digitalWrite(L4, HIGH); 

  delay(Velocidade);       
  
  digitalWrite(L1, LOW); 
  digitalWrite(L2, LOW); 
  digitalWrite(L3, LOW); 
  digitalWrite(L4, LOW); 

  delay(Velocidade);
  
  //2 0010
  digitalWrite(L1, LOW);      
  digitalWrite(L2, LOW);        
  digitalWrite(L3, HIGH);        
  digitalWrite(L4, LOW); 
  
  delay(Velocidade);       
  
  digitalWrite(L1, LOW); 
  digitalWrite(L2, LOW);        
  digitalWrite(L3, LOW); 
  digitalWrite(L4, LOW); 
  
  delay(Velocidade);
  
  //3 0011
  digitalWrite(L1, LOW); 
  digitalWrite(L2, LOW);        
  digitalWrite(L3, HIGH);        
  digitalWrite(L4, HIGH); 
  
  delay(Velocidade);       
  
  digitalWrite(L1, LOW);        
  digitalWrite(L2, LOW);        
  digitalWrite(L3, LOW);        
  digitalWrite(L4, LOW); 
  
  delay(Velocidade);
  
  //4 0100
  digitalWrite(L1, LOW); 
  digitalWrite(L2, HIGH);        
  digitalWrite(L3, LOW);       
  digitalWrite(L4, LOW); 
  
  delay(Velocidade);       
  
  digitalWrite(L1, LOW); 
  digitalWrite(L2, LOW);        
  digitalWrite(L3, LOW); 
  digitalWrite(L4, LOW); 
  
  delay(Velocidade);
  
  //5 0101
  digitalWrite(L1, LOW); 
  digitalWrite(L2, HIGH);        
  digitalWrite(L3, LOW);      
  digitalWrite(L4, HIGH); 
  
  delay(Velocidade);       
  
  digitalWrite(L1, LOW);        
  digitalWrite(L2, LOW);        
  digitalWrite(L3, LOW); 
  digitalWrite(L4, LOW); 
  
  delay(Velocidade);
  
  //6 0110
  digitalWrite(L1, LOW); 
  digitalWrite(L2, HIGH);        
  digitalWrite(L3, HIGH);       
  digitalWrite(L4, LOW); 
  
  delay(Velocidade);       
  
  digitalWrite(L1, LOW); 
  digitalWrite(L2, LOW);        
  digitalWrite(L3, LOW);        
  digitalWrite(L4, LOW); 
  
  delay(Velocidade);
  
  //7 0111
  digitalWrite(L1, LOW); 
  digitalWrite(L2, HIGH);        
  digitalWrite(L3, HIGH);       
  digitalWrite(L4, HIGH); 
  
  delay(Velocidade);       
  
  digitalWrite(L1, LOW); 
  digitalWrite(L2, LOW);        
  digitalWrite(L3, LOW);        
  digitalWrite(L4, LOW); 
  
  delay(Velocidade);
  
  //8 1000
  digitalWrite(L1, HIGH);   
  digitalWrite(L2, LOW);      
  digitalWrite(L3, LOW);       
  digitalWrite(L4, LOW);  
  
  delay(Velocidade);           
  
  digitalWrite(L1, LOW); 
  digitalWrite(L2, LOW); 
  digitalWrite(L3, LOW);        
  digitalWrite(L4, LOW); 
  
  delay(Velocidade);
  
  //9 1001
  digitalWrite(L1, HIGH); 
  digitalWrite(L2, LOW);       
  digitalWrite(L3, LOW);        
  digitalWrite(L4, HIGH);
  
  delay(Velocidade);       
  
  digitalWrite(L1, LOW); 
  digitalWrite(L2, LOW); 
  digitalWrite(L3, LOW);        
  digitalWrite(L4, LOW); 
  
  delay(Velocidade);
  
  //10 1010
  digitalWrite(L1, HIGH); 
  digitalWrite(L2, LOW);      
  digitalWrite(L3, HIGH);        
  digitalWrite(L4, LOW); 
  
  delay(Velocidade);       
  
  digitalWrite(L1, LOW); 
  digitalWrite(L2, LOW);        
  digitalWrite(L3, LOW);        
  digitalWrite(L4, LOW); 
  
  delay(Velocidade);
  
  //11 1011
  digitalWrite(L1, HIGH); 
  digitalWrite(L2, LOW);       
  digitalWrite(L3, HIGH);        
  digitalWrite(L4, HIGH); 
  
  delay(Velocidade); 
  
  digitalWrite(L1, LOW); 
  digitalWrite(L2, LOW);       
  digitalWrite(L3, LOW); 
  digitalWrite(L4, LOW); 
  
  delay(Velocidade);
  
  //12 1100
  digitalWrite(L1, HIGH); 
  digitalWrite(L2, HIGH);       
  digitalWrite(L3, LOW);       
  digitalWrite(L4, LOW); 
  
  delay(Velocidade); 
  
  digitalWrite(L1, LOW); 
  digitalWrite(L2, LOW);        
  digitalWrite(L3, LOW);        
  digitalWrite(L4, LOW); 
  
  delay(Velocidade);
  
  //13 1101
  digitalWrite(L1, HIGH); 
  digitalWrite(L2, HIGH);       
  digitalWrite(L3, LOW); 
  digitalWrite(L4, HIGH);
  
  delay(Velocidade); 
  
  digitalWrite(L1, LOW); 
  digitalWrite(L2, LOW);        
  digitalWrite(L3, LOW);        
  digitalWrite(L4, LOW); 
  
  delay(Velocidade);
  
  //14 1110
  digitalWrite(L1, HIGH); 
  digitalWrite(L2, HIGH);       
  digitalWrite(L3, HIGH);       
  digitalWrite(L4, LOW); 
  
  delay(Velocidade); 
  
  digitalWrite(L1, LOW); 
  digitalWrite(L2, LOW);        
  digitalWrite(L3, LOW);        
  digitalWrite(L4, LOW); 
  
  delay(Velocidade);
  
  //15 1111
  digitalWrite(L1, HIGH); 
  digitalWrite(L2, HIGH);       
  digitalWrite(L3, HIGH); 
  digitalWrite(L4, HIGH); 
  
  delay(Velocidade); 
  
}
