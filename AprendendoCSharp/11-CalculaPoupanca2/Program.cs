﻿namespace _11_CalculaPoupanca2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando programa 11 - Calcula Poupança 2");

            double investimento = 1000;

            for(int mes = 1; mes <= 12; mes++)
            {
                investimento *= 1.005;
                Console.WriteLine($"Investimento no mês {mes} vale R$ {investimento}");
            }

            Console.WriteLine("Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}