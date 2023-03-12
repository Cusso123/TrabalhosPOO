using Disciplina;

//Nesse trabalho a diferença do 1 e 2, foi apenas adicionada uma lista para colocar a quantidade de alunos e suas notas.

Console.WriteLine("Digite a quantidade de alunos a serem cadastrados: ");
int quantidadeAlunos = int.Parse(Console.ReadLine());

    List<Aluno> listaAlunos = new List<Aluno>();
    for (int i = 0; i < quantidadeAlunos; i++)
    {
    Console.WriteLine("\nDigite numero de alunos {0}", i + 1);

    Aluno aluno = new Aluno();
    aluno.ReceberDados();
    aluno.CalcularMedia();
    listaAlunos.Add(aluno);

    }

    Console.WriteLine("\n Notas Finais são: ");
    foreach (Aluno aluno in listaAlunos)
    {
    aluno.CalcularNotaFinal();
    aluno.ImprimirNotaFinal();
    }

    Console.ReadLine();


    Calculadora calculadora = new Calculadora();
    calculadora.ExecutarCalculadora();