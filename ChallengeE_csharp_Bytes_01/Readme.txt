### Desafio Técnico com Byte

##Task 01 - Quantidade de Valores do Tipo Byte

Considere os valores [10, 300, "bbb", 20,30, "--", "/", 50, 1000]  passado em tempo real pelo usuário. Ao finalizar o programa ele retorna:
a quantidade de valores que são do tipo byte.
No nosso exemplo teríamos como saída: 4

Cenários de Testes de Exemplos
Teste [01]
  Entrada: [10, 300, "bbb", 20,30, "--", "/", 50, 1000] 
  Saída: 4
Teste [02]
  Entrada: ["reg", ">", 299]
  Saída: 0
Teste [03]
  Entrada: [1,2,3,4,5,6]
  Saída: 6

Para verificação de sua solução implemente a solução no método getQuantidade e use o projeto de Teste para verificar sua resposta.


##Task 02 - Quantidade de Valores com Formato incompatíveis com Bytes

Considere os valores [10, 300, "bbb", 20,30, "--", "/", 50, 1000]  passado em tempo real pelo usuário. Ao finalizar o programa ele retorna:
a quantidade de valores que não são compatíveis com o byte (Fora de formato).

Cenários de Testes de Exemplos
Teste [01]
  Entrada: [10, 300, "bbb", 20,30, "--", "/", 50, 1000] 
  Saída: 3
Teste [02]
  Entrada: ["reg", ">", 299]
  Saída: 2
Teste [03]
  Entrada: [1,2,3,4,5,6]
  Saída: 0

Para verificação de sua solução implemente a solução no método getQuantidadeFormato e use o projeto de Teste para verificar sua resposta.



##Task 03 - Quantidade de Valores com Fora da Faixa de Bytes

Considere os valores [10, 300, "bbb", 20,30, "--", "/", 50, 1000]  passado em tempo real pelo usuário. Ao finalizar o programa ele retorna:
a quantidade de valores que não são compativeis com o byte (Fora de formato).

Cenários de Testes de Exemplos
Teste [01]
  Entrada: [10, 300, "bbb", 20,30, "--", "/", 50, 1000] 
  Saída: 2
Teste [02]
  Entrada: ["reg", ">", 299]
  Saída: 1
Teste [03]
  Entrada: [1,2,3,4,5,6]
  Saída: 0

Para verificação de sua solução implemente a solução no método getQuantidadeForaDafaixa e use o projeto de Teste para verificar sua resposta.
