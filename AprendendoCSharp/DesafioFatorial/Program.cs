﻿namespace DesafioFatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando desafio Fatorial");

            int fatorial = 1;

            for(int i = 1; i <= 10; i++)
            {
                fatorial *= i;
                Console.WriteLine("Fatorial de " + i + " = " + fatorial);
            }

        }
    }
}