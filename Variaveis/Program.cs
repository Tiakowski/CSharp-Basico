using System;
class Programa
{
    static void Main(string[] args)
    {
        int idade;
        int ano;
        int nascimento;

        idade = 22;
        ano = 2022;
        nascimento = ano - idade;

        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Ano atual: " + ano);
        Console.WriteLine("Ano de nascimento: " + nascimento);
        Console.ReadLine();
    }
}