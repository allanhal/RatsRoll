unsigned long waitUntil=0;

double raioConst=2.032;


//******** VariÃ¡veis do rolo 1 *********
int rolo_1 = 2;
unsigned int contador_1 = 0;
unsigned long tempoAnterior_1 =1;
unsigned long tempoAtual_1 =1;
double deltaT1 =0;
float distancia_1 = 0;
double velocidade_1=1;
boolean repetido1=0;
//**************************************

//******** VariÃ¡veis do rolo 2 *********
int rolo_2 = 4;
unsigned int contador_2 = 0;
unsigned long tempoAnterior_2 =1;
unsigned long tempoAtual_2 =1;
double deltaT2 =0;
float distancia_2 = 0;
double velocidade_2=1;
boolean repetido2=0;
//**************************************

// the setup routine runs once when you press reset:
void setup() {
  // initialize serial communication at 9600 bits per second:
  Serial.begin(9600);

  pinMode(rolo_1, INPUT);
  pinMode(rolo_2, INPUT);
}

// the loop routine runs over and over again forever:
void loop() {
  

  //************* Teste do rolo 1 ******************************************************************************************************************
  if(digitalRead(rolo_1)==0&&repetido1==0){
    tempoAnterior_1=tempoAtual_1;
    tempoAtual_1=millis();
    contador_1 = contador_1+1;
    repetido1=1;
  }
  if(digitalRead(rolo_1)==1){repetido1=0;}
  //************************************************************************************************************************************************
  
  
  //************* Teste do rolo 2 ******************************************************************************************************************
  if(digitalRead(rolo_2)==0&&repetido2==0){
    tempoAnterior_2=tempoAtual_2;
    tempoAtual_2=millis();
    contador_2 = contador_2+1;
    repetido2=1;
  }
  if(digitalRead(rolo_2)==1){repetido2=0;}
  //*************************************************************************************************************************************************

  
  if ((unsigned long)(millis() - waitUntil) >= 500) {
      waitUntil = millis();
      deltaT1 =(tempoAtual_1-tempoAnterior_1)/1000.0; 
      deltaT2 =(tempoAtual_2-tempoAnterior_2)/1000.0;  
      distancia_1=contador_1*raioConst;
      distancia_2=contador_2*raioConst;
      velocidade_1=((raioConst)/(deltaT1))*3.6;
      velocidade_2=((raioConst)/(deltaT2))*3.6;
      
      if(deltaT1==0){velocidade_1=0;}
      if(deltaT2==0){velocidade_2=0;}
      if((millis()-tempoAnterior_1)>1000){velocidade_1=0;}
      if((millis()-tempoAnterior_2)>1000){velocidade_2=0;}
      Serial.print(distancia_1);
      Serial.print("w");
      Serial.print(velocidade_1);
      Serial.print("x");
      Serial.print(distancia_2);
      Serial.print("y");
      Serial.print(velocidade_2);
      Serial.println("z");
      //Serial.print(" == Contador 1: ");
      //Serial.print(contador_1);
      //Serial.print(" ==");
      //Serial.print(" == Delta T1: ");
      //Serial.print(deltaT1);
      //Serial.println(" ==");
  } 
}

