/*Exercício 2 — Verificação de notas

Crie um programa que peça a nota de 5 alunos e armazene essas notas em um vetor.

Depois, percorra o vetor e mostre:

A nota de cada aluno.
Se o aluno foi aprovado ou reprovado.
Um aluno é aprovado se a nota for maior ou igual a 6.*/

//Dica: use um vetor double[] e um while para preencher e outro while para verificar.


double[] nota = new double[5];
int i = 1;


while (i < 6)
{
    Console.WriteLine("Nota do aluno: ");
    nota[i] = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine($"Nota: {nota[i]}");
  
    i++;
}

Console.WriteLine($"Nota {i} foi {nota[i]}");

