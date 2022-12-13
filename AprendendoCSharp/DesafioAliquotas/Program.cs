namespace DesafioAliquotas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando desafio Alíquotas");

            double salario = 4300.0;

            if(salario >= 1900.0 && salario <= 2800.0)
            {
                Console.WriteLine("IR é de 7.5% e pode deduzir na declaração o valor de R$ 142");
            }
            else if(salario <= 3751.0)
            {
                Console.WriteLine("IR é de 15% e pode deduzir na declaração o valor de R$ 350");
            }
            else if(salario <= 4664.0)
            {
                Console.WriteLine("IR é de 22.5% e pode deduzir na declaração o valor de R$ 636");
            }

            Console.WriteLine("Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}