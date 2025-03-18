namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("        Calculadora");
            Console.WriteLine("----------------------------");

            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            string opcao = Console.ReadLine();

            // Somar dois valores
            Console.Write("Digite o primeiro número: ");

            int primeiroNumero = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int segundoNumero = Convert.ToInt32(Console.ReadLine());

            int resultado = 0;

            if (opcao == "1")
            {
                resultado = primeiroNumero + segundoNumero;
            }
            else if (opcao == "2")
            {
                resultado = primeiroNumero - segundoNumero;
            }

            Console.WriteLine($"Resultado: {resultado}");

        }
    }
}
