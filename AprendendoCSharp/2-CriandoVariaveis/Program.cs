﻿using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 2 - Criando variáveis");

        int idade = 32;
        Console.WriteLine($"Minha idade é {idade} anos.");

        idade = 27 - 5;
        Console.WriteLine(idade);

        idade = 5 * 2 - 6;
        Console.WriteLine(idade);

        idade = (5 - 2) * 3;
        Console.WriteLine(idade);

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}
