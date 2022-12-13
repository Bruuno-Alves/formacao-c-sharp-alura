using bytebank.Contas;
using bytebank.Titular;
using System.Runtime.CompilerServices;

namespace bytebank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ContaCorrente contaDoBruno = new();
            //contaDoBruno.numeroAgencia = 123;
            //contaDoBruno.conta = "10253-X";
            //contaDoBruno.titular = "Bruno Alves";
            //contaDoBruno.saldo = 100;

            //ContaCorrente contaDoBruno2 = new();
            //contaDoBruno2.numeroAgencia = 123;
            //contaDoBruno2.conta = "10253-X";
            //contaDoBruno2.titular = "Bruno Alves";
            //contaDoBruno2.saldo = 100;

            //contaDoBruno2 = contaDoBruno;

            //Console.WriteLine(contaDoBruno == contaDoBruno2);

            //Console.WriteLine($"Saldo da conta do Bruno: R$ {contaDoBruno.saldo}.");

            //ContaCorrente contaDaAna = new();
            //contaDaAna.titular = "Ana Mendes";
            //contaDaAna.numeroAgencia = 123;
            //contaDaAna.conta = "15326-0";
            //contaDaAna.saldo = 100;

            //Console.WriteLine($"Saldo da conta da Ana: R$ {contaDaAna.saldo}.");

            //contaDoBruno.Transferir(50, contaDaAna);

            //Console.WriteLine($"Saldo do Bruno: R$ {contaDoBruno.saldo}");
            //Console.WriteLine($"Saldo da Ana: R$ {contaDaAna.saldo}");

            //ContaCorrente contaDoPedro = new();
            //contaDoPedro.titular = "Pedro Silva";
            //contaDoPedro.ExibirInformacoes();

            //Cliente bruno = new();
            //bruno.nome = "Bruno Alves";
            //bruno.cpf = "123456789";
            //bruno.profissao = "Desenvolvedor";

            //ContaCorrente contaDoBruno = new();
            //contaDoBruno.titular = bruno;
            //contaDoBruno.numeroAgencia = 123;
            //contaDoBruno.conta = "1235-7";
            //contaDoBruno.saldo = 100;

            //contaDoBruno.ExibirInformacoes();
            //bruno.ExibirInformacoes();

            //ContaCorrente conta2 = new();
            //conta2.titular = new();
            //conta2.titular.nome = "José Souza";
            //conta2.titular.profissao = "Tester";
            //conta2.titular.cpf = "987456321";
            //conta2.conta = "5555-X";
            //conta2.numeroAgencia = 18;
            //conta2.saldo = 500;

            //ContaCorrente conta3 = new();
            //conta3.NumeroAgencia = 38;
            //conta3.Conta = "1011-H";
            //conta3.SetSaldo(200);
            //Console.WriteLine(conta3.GetSaldo()); ;
            //Console.WriteLine(conta3.NumeroAgencia);
            //Console.WriteLine(conta3.Conta);

            //ContaCorrente conta4 = new(23, "4596-G");
            //conta4.SetSaldo(500);
            //conta4.Titular = new Cliente();
            //Console.WriteLine(conta4.GetSaldo());
            //Console.WriteLine(conta4.NumeroAgencia);

            ContaCorrente conta5 = new(253, "585236-X");
            Console.WriteLine($"Total de contas criadas: {ContaCorrente.TotalContasCriadas}.");

            ContaCorrente conta6 = new(556, "584632-Y");
            Console.WriteLine($"Total de contas criadas: {ContaCorrente.TotalContasCriadas}.");

            ContaCorrente conta7 = new(652, "854669-Z");
            Console.WriteLine($"Total de contas criadas: {ContaCorrente.TotalContasCriadas}.");

            Cliente cliente1 = new();
            Cliente cliente2 = new();
            Cliente cliente3 = new();
            Console.WriteLine($"Total de clientes criados: {Cliente.TotalDeClientes}.");



        }
    }
}