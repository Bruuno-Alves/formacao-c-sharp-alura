namespace _13_EncadeandoFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 13 - Encadeando For");

            //*
            //**
            //***
            //****
            //*****

            //com break
            for(int contLinhas = 0; contLinhas < 10; contLinhas++)
            {
                for(int contColunas = 0; contColunas < 10; contColunas++)
                {
                    Console.Write("* ");
                    if (contColunas >= contLinhas)
                    {
                        break;
                    }
                }
                Console.WriteLine();
            }

            //sem break
            for (int contLinhas = 0; contLinhas < 10; contLinhas++)
            {
                for (int contColunas = 0; contColunas < contLinhas; contColunas++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}