namespace _4_ConversoesEOutrosTipos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float pontoFlutuante = 3.14f;

            double salario = 3000.15;
            Console.WriteLine(salario);

            int salarioInteiro = (int)salario;
            Console.WriteLine(salarioInteiro);

            double valor1 = 0.1;
            double valor2 = 0.2;
            double total = valor1 + valor2;
            Console.WriteLine(total);

            //O long é uma variável de tipo inteiro com 64 bits
            long x = 200000000000000000;
            Console.WriteLine(x);

            short y = 15000;
            Console.WriteLine(y);

            float altura = 1.73f;
            Console.WriteLine(altura);

            Console.WriteLine("Tecle ener para fechar...");
            Console.ReadLine();
        }
    }
}