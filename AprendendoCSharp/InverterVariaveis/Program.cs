namespace InverterVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 10;
            int B = 20;
            int aux = 0;

            Console.WriteLine("Antes da inversão, a variável A vale " + A + ", e a variável B vale " + B);

            aux = A;
            A = B;
            B = aux;

            Console.WriteLine("Após a inversão, a variável A vale " + A + ", e a variável B vale " + B);
        }
    }
}