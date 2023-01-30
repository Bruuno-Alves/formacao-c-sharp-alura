using bytebank_ADM.Funcionarios;
using bytebank_ADM.Parceria;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Utilitario;

namespace bytebank_ADM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //Funcionario bruno = new("456987123-5", 3000);
            //bruno.Nome = "Bruno Alves";

            //Console.WriteLine(bruno.Nome);
            //Console.WriteLine(bruno.GetBonificacao());

            //Diretor rebecca = new("569445853-9", 8000);
            //rebecca.Nome = "Rebecca Faria";

            //Console.WriteLine(rebecca.Nome);
            //Console.WriteLine(rebecca.GetBonificacao());

            //GerenciadorDeBonificacao gerenciador = new();
            //gerenciador.Registrar(bruno);
            //gerenciador.Registrar(rebecca);

            //Console.WriteLine($"O total de bonificações é: {gerenciador.Bonificacoes}.");
            //Console.WriteLine($"O total de funcionários criados é: {Funcionario.TotalDeFuncionarios}.");

            //bruno.AumentarSalario();
            //rebecca.AumentarSalario();

            //Console.WriteLine($"Novo salário do Bruno é: {bruno.Salario}.");
            //Console.WriteLine($"Novo salário da Rebecca é: {rebecca.Salario}.");
            #endregion

            CalcularBonificacao();
            UsarSistema();

            void CalcularBonificacao()
            {
                GerenciadorDeBonificacao gerenciador = new();

                Designer ulisses = new("456852369-7");
                ulisses.Nome = "Ulisses Almeida";

                Diretor paula = new("715996258-2");
                paula.Nome = "Paula Rambolli";

                Auxiliar igor = new("636885123-5");
                igor.Nome = "Igor Vasconcelos";

                GerenteDeContas camila = new("852123789 - 5");
                camila.Nome = "Camila Milanesi";

                gerenciador.Registrar(ulisses);
                gerenciador.Registrar(paula);
                gerenciador.Registrar(igor);
                gerenciador.Registrar(camila);

                Console.WriteLine($"O total de bonificações é {gerenciador.Bonificacoes}.");
            }

            void UsarSistema()
            {
                SistemaInterno.SistemaInterno sistema = new();

                Diretor ingrid = new("852369112-3");
                ingrid.Nome = "Ingrid Novares";
                ingrid.Senha = "123";

                GerenteDeContas nataly = new("789225963-9");
                nataly.Nome = "Nataly Vieira";
                nataly.Senha = "885";

                ParceiroComercial caio = new();
                caio.Senha = "555";

                sistema.Logar(ingrid, "123");
                sistema.Logar(nataly, "552");
                sistema.Logar(caio, "555");

            }

        }
    }
}
