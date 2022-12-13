namespace _12_InvestimentoALongoPrazo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 12 - Investimento a Longo Prazo");

            double fatorInvestimento = 1.005;
            double investimento = 1000;

            for(int ano = 1; ano <= 5; ano++)
            {
                for(int mes = 1; mes <= 12; mes++)
                {
                    investimento *= fatorInvestimento;
                }

                fatorInvestimento += 0.001;
            }

            Console.WriteLine($"Depois de 5 anos você terá R$ {investimento}");

            Console.WriteLine("Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}