[1 - Respostas das perguntas teóricas]
1.1 - Em quais linguagens o C# foi inspirado?
1.2 - Inicialmente o C# foi criado para qual finalidade?
1.3 - Quais os principais motivos para a Microsoft ter migrado para o Core?
1.4 - Cite as principais diferenças entre .Net Full Framework e .Net Core.

[2 - Trabalhando no Console]

Observação geral: Foi criado um projeto para cada exercício e também um projeto adicional LibConsole no qual foi centralizado o código de validação de input de dados e também de cálculos (na classe estática Calculadora) que são utilizados nos exercícios 1, 3, 5...

2.1 - Desenvolvido o Exercicio1-Calculadora.csproj na pasta "TrabalhandoNoConsole". Ao executar o console, serão questionados os valores A e B e logo após será exibido um menu com todas as opções disponíveis ao usuário. Pelo menu, o usuário poderá executar as operações matemáticas, verificar a paridade e também sair. Ao sair do menu, será questionado se o usuário deseja informar novos números e todo o processo se repetirá.

2.2 - Desenvolvido o Exercicio2-Salarios.csproj na pasta "TrabalhandoNoConsole". Ao executar o console, será questionada a quantidade de funcionários e na sequencia os nomes e salários de cada um. Por fim, será exibido o menor e maior salário com o respectivo nome do funcionário. Desenvolvida uma solução adicional utilizando linq.

2.3 - Desenvolvido o Exercicio3-Multiplos3.csproj na pasta "TrabalhandoNoConsole". Ao executar o console, será exibida a lista dos múltiplos de 3.

2.4 - Desenvolvido o Exercicio4-NotasAlunos.csproj na pasta "TrabalhandoNoConsole". Ao executar o console, será questionada a lista de alunos com suas respectivas notas e ao final serão exibidos os alunos com notas superiores a 7.
Obs: Como no enunciado do exercício havia a afirmação "Imprima todos os alunos com médias superiores a 7", caso o aluno tenha nota 7 o mesmo não é exibido.

2.5 - Desenvolvido o Exercicio5-Bhaskara.csproj na pasta "TrabalhandoNoConsole". Ao executar o console, serão questionados os valores dos coeficientes a, b e c e as raízes serão informadas como resultado. Caso o delta calculado seja menor que zero, não serão exibidas raízes; se for igual a zero, será exibida apenas uma raíz e se for maior que zero serão exibidas duas raízes.

2.6 - Desenvolvido o Exercicio6-RefOut.csproj na pasta "TrabalhandoNoConsole". Ao executar o console, serão questionados os valores de salário bruto, valor do INSS e valor do IR. O console então irá chamar o método DescontarInss passando por referência a variável "salario" e, ao deduzir o INSS, a variável será automaticamente atualizada. Na sequencia é chamado o método DescontarIr passando por parâmetro o salário (que já foi atualizado no passo anterior) e este método deduz o IR e retorna o valor final num parâmetro out (exclusivo para saída).