namespace DesafioConstrutorPersonalizado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livro cleanCode = new("Clean Code", "978-0132350884");
            Livro cleanArchitecture = new("Clean Architecture", "978-0134494166");

            Console.WriteLine(cleanCode);
            Console.WriteLine(cleanArchitecture);
        }
    }
}