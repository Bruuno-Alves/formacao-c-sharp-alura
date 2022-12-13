using System;

namespace _10_CalculaPoupanca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - Calcula Poupança");

            double investimento = 1000;

            //rendimento de 0.5% (0.005) ao mês

            //mês 1
            //investimento = investimento + investimento * 0.005;
            //mês 2
            //investimento = investimento + investimento * 0.005;
            //mês 3
            //investimento = investimento + investimento * 0.005;

            //Console.WriteLine(investimento);

            int mes = 1;

            while(mes <= 12)
            {
                investimento += investimento * 0.005;
                Console.WriteLine($"Investimento no mês {mes} vale R$ {investimento}");
                mes++;
            }
        }
    }
}