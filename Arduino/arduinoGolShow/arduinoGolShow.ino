int alternativaA = 10;
int alternativaB = 9;
int alternativaC = 6;
int alternativaD = 5;
int alternativaE = 3;

void setup()
{
  Serial.begin(9600);
  pinMode(alternativaA, INPUT_PULLUP);
  pinMode(alternativaB, INPUT_PULLUP);
  pinMode(alternativaC, INPUT_PULLUP);
  pinMode(alternativaD, INPUT_PULLUP);
  pinMode(alternativaE, INPUT_PULLUP);
}

void loop()
{
  if (digitalRead(alternativaA) == LOW)
  {
    Serial.write("A");
      delay(400);
  }
  
  else if (digitalRead(alternativaB) == LOW)
  {
    Serial.write("B");
      delay(400);
  }
  
  else if (digitalRead(alternativaC) == LOW)
  {
    Serial.write("C");
        delay(400);
  }
  
  else if (digitalRead(alternativaD) == LOW)
  {
    Serial.write("D");
      delay(400);
  }
  
  else if (digitalRead(alternativaE) == LOW)
  {
    Serial.write("E");
      delay(400);
  }
}
