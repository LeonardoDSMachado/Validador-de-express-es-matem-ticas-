# Validador-de-expressoes-matematicas-

Este codigo foi realizado por mim para resolver o exercicio abaixo;

Implemente um programa que verifica se uma expressão matemática contém parênteses
balanceados seguindo os seguintes passos:
1. Crie uma variável do tipo Stack<char> para armazenar os parênteses abertos.
2. Percorra cada caractere da expressão matemática.
3. Se o caractere for um parêntese aberto adicione-o à pilha.
4. Se o caractere for um parêntese fechado verifique se a pilha não está vazia e se o último
parêntese aberto adicionado na pilha corresponde ao parêntese fechado atual. Se sim, remova o
último parêntese aberto da pilha. Caso contrário, a expressão matemática não contém parênteses
balanceados.
5. Após percorrer todos os caracteres da expressão matemática, verifique se a pilha está vazia. Se estiver
vazia, a expressão matemática contém parênteses balanceados. Caso contrário, a expressão não é
balanceada.
