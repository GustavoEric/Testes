
int led = 13;
int led2 = 12;
int led3 = 11;
int seg= 8;
int seg2= 4;


// the setup routine runs once when you press reset:
void setup() { 
  Serial.begin(9600);  
  // initialize the digital pin as an output.
  pinMode(led, OUTPUT); 
  pinMode(led2, OUTPUT); 
  pinMode(led3, OUTPUT);
  digitalWrite(led, HIGH); 
}


// the loop routine runs over and over again forever:
void loop() {
  Serial.println(seg);
  seg=seg-1;
  delay(1000);
  

  if (seg==0){
    Serial.println(seg2);
    seg2=seg-1;
    digitalWrite(led, LOW);
    digitalWrite(led2, HIGH);
    digitalWrite(led3, LOW);
    delay(1000);
  }else if (seg2== 0){
    seg2=7;
    seg=seg-1;
    Serial.println(seg2);
    digitalWrite(led, LOW);
    digitalWrite(led2, LOW);
    digitalWrite(led3, HIGH);
    delay(1000);
  }else (seg2==1){
    seg2=4;
  }
  
  
}
