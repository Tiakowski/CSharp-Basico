using System;
class Programa
{
    static void Main(string[] args)
    {
        int idadeJoao = 16;
        int numeroPessoas = 2;
        bool acompanhado = numeroPessoas > 1;

        if (idadeJoao > 17 || acompanhado)
        {
            Console.WriteLine("Pode entrar! \n");
        } else {
            Console.WriteLine("Nao pode entrar! \n");
        }

        Console.WriteLine("Tecle ENTER para fechar ...");
        Console.ReadLine();
    }
}
