[1 - Perguntas teóricas de introdução]

1.1 - Em quais linguagens o C# foi inspirado?
1.2 - Inicialmente o C# foi criado para qual finalidade?
1.3 - Quais os principais motivos para a Microsoft ter migrado para o Core?
1.4 - Cite as principais diferenças entre .Net Full Framework e .Net Core.

[2 - Trabalhando no Console]

Observações gerais:
- A solução foi desenvolvida no Microsoft Visual Studio Community 2019;
- Foi criado um projeto para cada exercício e também um projeto adicional LibConsole no qual foi centralizado o código de validação de input de dados e também de cálculos (na classe estática Calculadora) que são utilizados nos exercícios 1, 3, 5...

2.1 - Desenvolvido o Exercicio1-Calculadora.csproj na pasta "01-TrabalhandoNoConsole". Ao executar o console, serão questionados os valores A e B e logo após será exibido um menu com todas as opções disponíveis ao usuário. Pelo menu, o usuário poderá executar as operações matemáticas, verificar a paridade e também sair. Ao sair do menu, será questionado se o usuário deseja informar novos números e todo o processo se repetirá.

2.2 - Desenvolvido o Exercicio2-Salarios.csproj na pasta "01-TrabalhandoNoConsole". Ao executar o console, será questionada a quantidade de funcionários e na sequencia os nomes e salários de cada um. Por fim, será exibido o menor e maior salário com o respectivo nome do funcionário. Desenvolvida uma solução adicional utilizando linq.

2.3 - Desenvolvido o Exercicio3-Multiplos3.csproj na pasta "01-TrabalhandoNoConsole". Ao executar o console, será exibida a lista dos múltiplos de 3.

2.4 - Desenvolvido o Exercicio4-NotasAlunos.csproj na pasta "01-TrabalhandoNoConsole". Ao executar o console, será questionada a lista de alunos com suas respectivas notas e ao final serão exibidos os alunos com notas superiores a 7. Também foi implementada uma solução adicional usando linq.
Obs: Como no enunciado do exercício havia a afirmação "Imprima todos os alunos com médias superiores a 7", caso o aluno tenha nota 7 o mesmo não é exibido.

2.5 - Desenvolvido o Exercicio5-Bhaskara.csproj na pasta "01-TrabalhandoNoConsole". Ao executar o console, serão questionados os valores dos coeficientes a, b e c e as raízes serão informadas como resultado. Caso o delta calculado seja menor que zero, não serão exibidas raízes; se for igual a zero, será exibida apenas uma raíz e se for maior que zero serão exibidas duas raízes.

2.6 - Desenvolvido o Exercicio6-RefOut.csproj na pasta "01-TrabalhandoNoConsole". Ao executar o console, serão questionados os valores de salário bruto, valor do INSS e valor do IR. O console então irá chamar o método DescontarInss passando por referência a variável "salario" e, ao deduzir o INSS, a variável será automaticamente atualizada. Na sequencia é chamado o método DescontarIr passando por parâmetro o salário (que já foi atualizado no passo anterior) e este método deduz o IR e retorna o valor final num parâmetro out (exclusivo para saída).

2.7 - Desenvolvido o Exercicio7-SomaPares na pasta "01-TrabalhandoNoConsole". Ao executar o console, serão questionados os 4 inteiros e exibida a soma daqueles que são pares. Também foi implementada uma solução adicional usando linq.

2.8 - Desenvolvido o Exercicio8-DecimaisCrescenteDecrescente na pasta "01-TrabalhandoNoConsole". Ao executar o console, serão questionados os valores decimais e então a lista será impressa de forma crescente e decrescente. Foram implementadas duas soluções (estratégias) para a ordenação da lista, uma utilizando o método Sort e outra implementando o algoritmo BubbleSort. Foi implementado o padrão strategy para realizar os dois tipos de ordenação.

2.9 - Desenvolvido o Exercicio9-Linq na pasta "01-TrabalhandoNoConsole". Ao executar o console, serão questionados os valores e realizadas todas as operações propostas utilizando linq. Porém, não consegui entender qual proposta teria o texto "Retorne apenas o número informado" do enunciado, ficou um pouco vago, mas para não ficar sem fazê-lo, eu implementei duas soluções de possíveis interpretações: uma que retorna qual o número está em determinada posição (método RetornarNumeroDaPosicaoInformada) e outra que verifica que a lista de números contém determinado valor (método VerificarListaContemNumeroInformado).

[3-Utilizando POO]

3.1 - Responda e demonstre no código os itens abaixo:

- O que é POO?
- O que é polimorfismo?
- O que é abstração?
- O que é encapsulamento?
- Quando usar uma classe abstrata e quando devo usar uma interface?
- O que faz as interfaces IDisposable, IComparable, ICloneable e IEnumerable?
- Existe herança múltipla (de classes) em C#?

3.2 - Desenvolvido o Exerccicio2-Pessoa na pasta "02-Utilizando POO". Ao executar o console, serão questionados os dados da pessoa e o objeto com os respectivos dados será instanciado. Os setters da classe de pessoa validam as entradas informadas. Ao final os dados são impressos com uma formatação determinada. 

3.3 - Desenvolvido o Exercicio3-ContaBancaria na pasta "02-Utilizando POO". Optei por criar os métodos Sacar e Depositar como virtuais na classe ContaBancaria para poder implementar uma validação de valor negativo já nesta classe base evitando duplicidade de código nas subclasses. O console irá realizar uma simulação primeiramente na conta corrente demonstrando todas as validações criadas e na sequencia fará o mesmo para a conta especial.

3.4 - Desenvolvido o Exercicio4-ControleRemoto na pasta "02-Utilizando POO". Utilizei o padrão "bridge" para realizar a integração entre o controle remoto (abstração) e a televisão (implementação). O console irá realizar a simulação de todas as validações implementadas.

[3 - Trabalhando com testes]

3.1 - Quais os principais frameworks que podemos usar no desenvolvimento de testes?
Resposta: Seguem abaixo os principais e suas particularidades:
- MSTest: Começou como uma ferramenta integrada ao VS de testes unitários para .NET.
- NUnit: Foi uma espécie de portabilidade do JUnit (Java) para o .NET.
- xUnit: Criado pelos antigos desenvolvedores do NUnit com intuito de modernizar e facilitar a criação dos testes.

3.2 - Desenvolvidos dois projetos de teste em xUnit na pasta "03-Trabalhando com testes":
- Calculadora.xUnit.Test: Realiza os testes unitários refente ao projeto do exercício 1 da seção "Trabalhando no Console";
- CalculoSalario.xUnit.Test: Realiza os testes unitários refente ao projeto do exercício 2 da seção "Trabalhando no Console";
E mais dois projetos em NUnit:
- CalculoBhaskara.NUnit.Test: Realiza os testes unitários refente ao projeto do exercício 5 da seção "Trabalhando no Console";
- ContaBancaria.NUnit.Test: Realiza os testes unitários refente ao projeto do exercício 3 da seção "Utilizando POO";