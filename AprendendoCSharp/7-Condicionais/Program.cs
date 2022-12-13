namespace _7_Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - Condicionais");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("Pode entrar!");
            }
            else if (quantidadePessoas > 1)
            {
                Console.WriteLine("Ele está acompanhado. Pode Entrar!");
            }
            else
            {
                Console.WriteLine("Não pode entrar!");
            }

            Console.WriteLine("Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}