#include "Keyboard.h"

const int botao1 = 7;
const int botao2 = 6;
const int botao3 = 5;
const int botao4 = 4;
const int luz = 13;



void setup() {
  pinMode(botao1, INPUT_PULLUP);
  pinMode(botao2, INPUT_PULLUP);
  pinMode(botao3, INPUT_PULLUP);
  pinMode(botao4, INPUT_PULLUP);
  Keyboard.begin();

  Serial.begin(9600);
}

void loop() {

  if(digitalRead(botao1) == LOW){
    Keyboard.press('A');
    digitalWrite(luz, HIGH);
    Serial.println()("Botão 1 funcionando");// excluir linha depois de fazer teste
    delay(50);
  }

  if(digitalRead(botao2) == LOW){
    Keyboard.press('B');
    digitalWrite(luz, HIGH);
    Serial.println()("Botão 2 funcionando");// excluir linha depois de fazer teste
    delay(50);
  }

  if(digitalRead(botao3) == LOW){
    Keyboard.press('C');
    digitalWrite(luz, HIGH);
    Serial.println("Botão 3 funcionando");// excluir linha depois de fazer teste
    delay(50);
  }

  if(digitalRead(botao4) == LOW){
    Keyboard.press('D');
    digitalWrite(luz, HIGH);
    Serial.println("Botão 4 funcionando");// excluir linha depois de fazer teste
    delay(50);
  }

//arranja uma forma de resetar todos os botões quando acabar as condicionais.
  
  
}