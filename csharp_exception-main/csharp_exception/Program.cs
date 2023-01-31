using csharp_exception.Titular;
using csharp_exception.Contas;
using csharp_exception;



using(LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt"))
{
    leitor.LerProximaLinha();
    leitor.LerProximaLinha();
    leitor.LerProximaLinha();
}

/*
try
{
    leitor.LerProximaLinha();
    leitor.LerProximaLinha();
}
catch (IOException ex)
{
    Console.WriteLine("Leitura de arquivo interrompida");
}
finally
{
    leitor.Fechar();
}
*/

/*
try
{
    ContaCorrente conta1 = new ContaCorrente(2, "1234-X");
    
    conta1.Sacar(50);
    Console.WriteLine(conta1.GetSaldo());
    conta1.Sacar(150);
    Console.WriteLine(conta1.GetSaldo());
    
}
catch(ArgumentException ex)
{
    Console.WriteLine($"Parâmetro com erro {ex.ParamName}");
    Console.WriteLine("Não é possível criar uma conta com o número de agência menor ou igual a zero!");
    Console.WriteLine(ex.StackTrace);
    Console.WriteLine(ex.Message);
}
catch(SaldoInsuficienteException ex)
{
    Console.WriteLine("Operação Negada! Saldo insuficiente");
    Console.WriteLine(ex.Message);
}
*/

