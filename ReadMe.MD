[1 - Perguntas te�ricas de introdu��o]

1.1 - Em quais linguagens o C# foi inspirado?
Resposta: C# foi baseada na linguagem C++ e tamb�m possui alguns elementos do Object Pascal e Java.

1.2 - Inicialmente o C# foi criado para qual finalidade?
Resposta: O C# foi criado para o .NET. O objetivo era desprender o .NET de outras linguagens que limitavam o desenvolvimento da plataforma. A linguagem foi desenvolvida com o nome Cool, mas no lan�amento do .NET mudaram o nome para C#.

1.3 - Quais os principais motivos para a Microsoft ter migrado para o Core?
Resposta: 
- Permitir maior quantidade de ecossistemas para seus produtos: Windows, macOS e Linux;
- Concorrer com o Java;
- Busca constante pela evolu��o.

1.4 - Cite as principais diferen�as entre .Net Full Framework e .Net Core.
Resposta: 
- Core conta com a ajuda da comunidade;
- Core � modular (recursos s�o adicionados com pacotes - nuget);
- Core possibilita portabilidade para qualquer SO (Windows, Linux, Mac);
- Core � um framework simplificado para web, microservi�os e containers;
- N�o se pode desenvolver tudo o que existe no full no core, ele � mais "enxuto";
- Core n�o necessita de uma IDE espec�fica.

[2 - Trabalhando no Console]

Observa��es gerais:
- A solu��o foi desenvolvida no Microsoft Visual Studio Community 2019;
- Foi criado um projeto para cada exerc�cio e tamb�m um projeto adicional LibConsole no qual foi centralizado o c�digo de valida��o de input de dados e tamb�m de c�lculos (na classe est�tica Calculadora) que s�o utilizados, por exemplo, nos exerc�cios 1, 3 e 5.

2.1 - Desenvolvido o Exercicio1-Calculadora.csproj na pasta "01-TrabalhandoNoConsole". Ao executar o console, ser�o questionados os valores A e B e logo ap�s ser� exibido um menu com todas as op��es dispon�veis ao usu�rio. Pelo menu, o usu�rio poder� executar as opera��es matem�ticas, verificar a paridade e tamb�m sair. Ao sair do menu, ser� questionado se o usu�rio deseja informar novos n�meros e todo o processo se repetir�.

2.2 - Desenvolvido o Exercicio2-Salarios.csproj na pasta "01-TrabalhandoNoConsole". Ao executar o console, ser� questionada a quantidade de funcion�rios e na sequencia os nomes e sal�rios de cada um. Por fim, ser� exibido o menor e maior sal�rio com o respectivo nome do funcion�rio. Desenvolvida uma solu��o adicional utilizando linq.

2.3 - Desenvolvido o Exercicio3-Multiplos3.csproj na pasta "01-TrabalhandoNoConsole". Ao executar o console, ser� exibida a lista dos m�ltiplos de 3.

2.4 - Desenvolvido o Exercicio4-NotasAlunos.csproj na pasta "01-TrabalhandoNoConsole". Ao executar o console, ser� questionada a lista de alunos com suas respectivas notas e ao final ser�o exibidos os alunos com notas superiores a 7. Tamb�m foi implementada uma solu��o adicional usando linq.
Obs: Como no enunciado do exerc�cio havia a afirma��o "Imprima todos os alunos com m�dias superiores a 7", caso o aluno tenha nota 7 o mesmo n�o � exibido.

2.5 - Desenvolvido o Exercicio5-Bhaskara.csproj na pasta "01-TrabalhandoNoConsole". Ao executar o console, ser�o questionados os valores dos coeficientes a, b e c e as ra�zes ser�o informadas como resultado. Caso o delta calculado seja menor que zero, n�o ser�o exibidas ra�zes; se for igual a zero, ser� exibida apenas uma ra�z e se for maior que zero ser�o exibidas duas ra�zes.

2.6 - Desenvolvido o Exercicio6-RefOut.csproj na pasta "01-TrabalhandoNoConsole". Ao executar o console, ser�o questionados os valores de sal�rio bruto, valor do INSS e valor do IR. O console ent�o ir� chamar o m�todo DescontarInss passando por refer�ncia a vari�vel "salario" e, ao deduzir o INSS, a vari�vel ser� automaticamente atualizada. Na sequencia � chamado o m�todo DescontarIr passando por par�metro o sal�rio (que j� foi atualizado no passo anterior) e este m�todo deduz o IR e retorna o valor final num par�metro out (exclusivo para sa�da).

2.7 - Desenvolvido o Exercicio7-SomaPares na pasta "01-TrabalhandoNoConsole". Ao executar o console, ser�o questionados os 4 inteiros e exibida a soma daqueles que s�o pares. Tamb�m foi implementada uma solu��o adicional usando linq.

2.8 - Desenvolvido o Exercicio8-DecimaisCrescenteDecrescente na pasta "01-TrabalhandoNoConsole". Ao executar o console, ser�o questionados os valores decimais e ent�o a lista ser� impressa de forma crescente e decrescente. Foram implementadas duas solu��es (estrat�gias) para a ordena��o da lista, uma utilizando o m�todo Sort e outra implementando o algoritmo BubbleSort. Foi implementado o padr�o strategy para realizar os dois tipos de ordena��o.

2.9 - Desenvolvido o Exercicio9-Linq na pasta "01-TrabalhandoNoConsole". Ao executar o console, ser�o questionados os valores e realizadas todas as opera��es propostas utilizando linq. Por�m, n�o consegui entender qual proposta teria o texto "Retorne apenas o n�mero informado" do enunciado, ficou um pouco vago, mas para n�o ficar sem faz�-lo, eu implementei duas solu��es de poss�veis interpreta��es: uma que retorna qual o n�mero est� em determinada posi��o (m�todo RetornarNumeroDaPosicaoInformada) e outra que verifica que a lista de n�meros cont�m determinado valor (m�todo VerificarListaContemNumeroInformado).

[3-Utilizando POO]

3.1 - Responda e demonstre no c�digo os itens abaixo:

- O que � POO?
Resposta: POO � Programa��o orientada a objetos, um paradigma que a maioria das linguagens d�o suporte e nos permite mapear os problemas do mundo real em aproxima��es ou abstra��es utilizando conceitos de objetos, atributos, m�todos etc.

- O que � polimorfismo?
Resposta: Um objeto pode assumir uma forma diferente em algumas ocasi�es. No exercicio "Exercicio3-ContaBancaria", na classe Program, foi criado o m�todo Depositar que recebe um par�metro da classe base ContaBancaria. Em algumas ocasi�es este m�todo � chamado passando um objeto da classe filha ContaCorrente e em outras de outra classe filha ContaEspecial e quando � realizada a chamada "conta.Depositar" no interior do m�todo � executado exatamente o c�digo espec�fico da classe correspondente. Isto � polimorfismo.

- O que � abstra��o?
Resposta: Declarar classes bases com atributos e m�todos que s�o comuns � uma forma de abstrair a solu��o. No exercicio "Exercicio3-ContaBancaria", por exemplo, foi realizada uma abstra��o na classe ContaBancaria centralizando nela o que � comum para quaiquer tipos de contas como os atributos "n�mero da conta" e "saldo" e m�todos "depositar" e "sacar".

- O que � encapsulamento?
Resposta: O encapsulamento � esconder do mundo externo a l�gica para resolver determinado problema e tamb�m proteger atributos para que c�digos externos n�o o modifiquem de forma n�o segura. A propriedade Saldo da classe "ContaBancaria", por exemplo, s� pode sofrer uma escrita direta por classes herdadas (protected), outras classes n�o podem escrever diretamente no saldo da conta.

- Quando usar uma classe abstrata e quando devo usar uma interface?
Resposta: Uma interface � utilizada como um contrato, fazemos inje��o, por exemplo, por meio delas. Interfaces n�o cont�m nenhum c�digo mas a partir do momento que uma classe implementa uma interface, todos os m�todos devem ser implementados. Classes abstratas podem conter alguma l�gica como na classe ContaBancaria que � abstrata e possui algumas valida��es que s�o utilizadas nas subclasses.

- O que faz as interfaces IDisposable, IComparable, ICloneable e IEnumerable?
Reposta:
- IDisposable: Faz com que uma classe seja obrigada a implementar o Dispose(), �til para libera��o de recursos quando o objeto perde seu escopo;
- IComparable: Faz com que uma classe seja obrigada a implementar o CompareTo() para que seja poss�vel classificar suas inst�ncias (uso do m�todo Sort em uma cole��o de instancias);
- ICloneable: Faz com que uma classe seja obrigada a implementar o Clone() que permite retornar uma c�pia da instancia atual do objeto;
- IEnumerable: Faz com que uma classe seja obrigada a implementar o GetEnumerator() que permite que a cole��o seja iter�vel.

- Existe heran�a m�ltipla (de classes) em C#?
Resposta: N�o, por�m uma classe pode implementar mais de uma interface simulando uma heran�a m�ltipla.

3.2 - Desenvolvido o Exerccicio2-Pessoa na pasta "02-Utilizando POO". Ao executar o console, ser�o questionados os dados da pessoa e o objeto com os respectivos dados ser� instanciado. Os setters da classe de pessoa validam as entradas informadas. Ao final os dados s�o impressos com uma formata��o determinada. 

3.3 - Desenvolvido o Exercicio3-ContaBancaria na pasta "02-Utilizando POO". Optei por criar os m�todos Sacar e Depositar como virtuais na classe ContaBancaria para poder implementar uma valida��o de valor negativo j� nesta classe base evitando duplicidade de c�digo nas subclasses. O console ir� realizar uma simula��o primeiramente na conta corrente demonstrando todas as valida��es criadas e na sequencia far� o mesmo para a conta especial.

3.4 - Desenvolvido o Exercicio4-ControleRemoto na pasta "02-Utilizando POO". Utilizei o padr�o "bridge" para realizar a integra��o entre o controle remoto (abstra��o) e a televis�o (implementa��o). O console ir� realizar a simula��o de todas as valida��es implementadas.

[3 - Trabalhando com testes]

3.1 - Quais os principais frameworks que podemos usar no desenvolvimento de testes?
Resposta: Seguem abaixo os principais e suas particularidades:
- MSTest: Come�ou como uma ferramenta integrada ao VS de testes unit�rios para .NET.
- NUnit: Foi uma esp�cie de portabilidade do JUnit (Java) para o .NET.
- xUnit: Criado pelos antigos desenvolvedores do NUnit com intuito de modernizar e facilitar a cria��o dos testes.

3.2 - Desenvolvidos dois projetos de teste em xUnit na pasta "03-Trabalhando com testes":
- Calculadora.xUnit.Test: Realiza os testes unit�rios refente ao projeto do exerc�cio 1 da se��o "Trabalhando no Console";
- CalculoSalario.xUnit.Test: Realiza os testes unit�rios refente ao projeto do exerc�cio 2 da se��o "Trabalhando no Console";
E mais dois projetos em NUnit:
- CalculoBhaskara.NUnit.Test: Realiza os testes unit�rios refente ao projeto do exerc�cio 5 da se��o "Trabalhando no Console";
- ContaBancaria.NUnit.Test: Realiza os testes unit�rios refente ao projeto do exerc�cio 3 da se��o "Utilizando POO";

[Exercicio bonus]
O passo a passo foi evidenciado na pasta "Bonus-ExecutandoNoLinux".