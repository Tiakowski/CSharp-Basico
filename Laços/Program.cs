using System;
class Programa
{
    static void Main(string[] args)
    {
        /*
        double investimento = 1000;
        // rendimento de 0.5% ao mes (0,005)

        int mes = 1;
        while (mes <= 12)
        { 
            investimento += investimento * 0.005;
            Console.WriteLine("Mes: " + mes + " - Investimento: R$ " + investimento);
            mes++;
        }

        Console.WriteLine("Tecle ENTER para fechar ...");
        Console.ReadLine();
        */

        double fatorInvestimento = 1.005;
        double investimento = 1000;

        for(int ano = 1; ano <= 5; ano++)
        {
            for (int mes = 1; mes <= 12; mes++)
            {
                investimento *= fatorInvestimento;     
            }
            fatorInvestimento += 0.001;
            Console.WriteLine("Ano: " + ano + " - Rendimento: R$ " + Math.Round(investimento,2));
        }
        Console.WriteLine("\nDepois de 5 anos: "+ Math.Round(investimento,2));
        Console.WriteLine("\nTecle ENTER para fechar ...");
        Console.ReadLine();
    }
}

