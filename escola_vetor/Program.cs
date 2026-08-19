/*Exercício 2 — Verificação de notas

Crie um programa que peça a nota de 5 alunos e armazene essas notas em um vetor.

Depois, percorra o vetor e mostre:

A nota de cada aluno.
Se o aluno foi aprovado ou reprovado.
Um aluno é aprovado se a nota for maior ou igual a 6.*/

//Dica: use um vetor double[] e um while para preencher e outro while para verificar.


double[] nota = new double[5];
int i = 0; 
int a = 0;



while (i < 5) //laço de repetição de permitir armazenar as notas no vetor
{
    Console.WriteLine("Nota do aluno: ");
    nota[i] = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine($"Nota: {nota[i]}");
  
    i++;
}



Console.Write("########## RESULTADO ##########\n");
//criar outro laço que percorra as notas para ver quem passou
i= 0; //zero meu laço de repetição i para inicializalo novamente
while (i < 5)
{
    if (nota[i] >= 6)
    {
        Console.WriteLine($"Aluno: {i} Aprovado, nota: {nota[i]}");
        a++;
    }

    else
    {
        Console.WriteLine($"Aluno:{i} Reprovado, nota {nota[i]}");
    }

    i++;
}

Console.WriteLine("#######################################3");