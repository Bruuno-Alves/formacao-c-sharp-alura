namespace _6_AtribuicaoDeVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 6 - Atribuição de Variáveis");
            int idade = 32;
            int idadeBruno = idade;
            Console.WriteLine(idadeBruno);

            idade = 25;
            Console.WriteLine(idadeBruno);

            Console.WriteLine("Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}