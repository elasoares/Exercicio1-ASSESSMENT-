namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número, abaixo mostrará a quantidade de números" +
               " digitado, e então, exibirá os primeiros números da sequência de Fibonacci.: ");
            int numeroDigitado = int.Parse(Console.ReadLine());

           Fibonacci  exercicio1 = new Fibonacci();
            int n1 = exercicio1.N1 = 0;
            int n2 = exercicio1.N2 = 1;
            Console.WriteLine("Sequência de Fibonacci: " + n1);
            Console.WriteLine("Sequência de Fibonacci: " + n2);
            exercicio1.calcularFibonacci(numeroDigitado);
        }
    }
}
