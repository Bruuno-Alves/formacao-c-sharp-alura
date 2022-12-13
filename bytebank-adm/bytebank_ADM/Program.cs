using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;

namespace bytebank_ADM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario bruno = new();
            bruno.Nome = "Bruno Alves";
            bruno.Cpf = "456987123-5";
            bruno.Salario = 3000;

            Console.WriteLine(bruno.Nome);
            Console.WriteLine(bruno.GetBonificacao());

            Diretor rebecca = new();
            rebecca.Nome = "Rebecca Faria";
            rebecca.Cpf = "569445853-9";
            rebecca.Salario = 8000;

            Console.WriteLine(rebecca.Nome);
            Console.WriteLine(rebecca.GetBonificacao());

            GerenciadorDeBonificacao gerenciador = new();
            gerenciador.Registrar(bruno);
            gerenciador.Registrar(rebecca);

            Console.WriteLine($"O total de bonificações é: {gerenciador.Bonificacoes}");

        }
    }
}
