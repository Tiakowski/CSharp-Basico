using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ficha:" + "\n");
        int idade = 22;
        int ano = 22;
        int nascimento = ano - idade;

        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Ano atual: " + ano);
        Console.WriteLine("Ano de nascimento: " + nascimento + "\n");

        double salario;
        salario = 800.50;
        Console.WriteLine("Salario: " + salario);

        Console.ReadLine();
    }
}