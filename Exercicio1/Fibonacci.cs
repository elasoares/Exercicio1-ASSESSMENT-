using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    internal class Fibonacci
    {
        private int _n1;
        private int _n2;
        private int _contador;

        public int N1 { get => _n1; set => _n1 = value; }
        public int N2 { get => _n2; set => _n2 = value; }
        public int Contador { get => _contador; set => _contador = value; }

        public int calcularFibonacci(int numeroDigitado)
        {
            int n1 = 0, n2 = 1, contador = 0;
            for (int i = n2; i < numeroDigitado; i++)
            {
                contador = n1 + n2;
                n1 = n2;
                n2 = contador;

                Console.WriteLine("Sequência de Fibonacci: " + contador);
            }
            return contador;

        }
    }
}