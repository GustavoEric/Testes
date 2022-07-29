int L4 = 12;
int L3 = 11;
int L2 = 10;
int L1 = 9;


void setup() {                
  pinMode(L1, OUTPUT);     
  pinMode(L2, OUTPUT);     
  pinMode(L3, OUTPUT);     
  pinMode(L4, OUTPUT);     
}

void loop() {
  digitalWrite(L1, HIGH); 
  delay(50);            
  digitalWrite(L2, HIGH); 
  delay(50);            
  digitalWrite(L3, HIGH); 
  delay(50);            
  digitalWrite(L4, HIGH); 
  delay(50);            
  digitalWrite(L4, LOW);   
  delay(50);            
  digitalWrite(L3, LOW);  
  delay(50);            
  digitalWrite(L2, LOW);  
  delay(50);            
  digitalWrite(L1, LOW);   
  delay(50);                     
  
}
