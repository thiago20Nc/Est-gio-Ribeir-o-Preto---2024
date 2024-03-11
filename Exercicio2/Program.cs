using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número para verificar se ele pertence à sequência de Fibonacci: ");
            int numero = int.Parse(Console.ReadLine());

            if (PertenceSequenciaFibonacci(numero))
            {
                Console.WriteLine($"{numero} Pertence à sequência.");
            }
            else
            {
                Console.WriteLine($"{numero} Não pertence à sequência.");
            }
        }
        static bool PertenceSequenciaFibonacci(int numero)
        {
            int x = 0, y = 1;

            while (y < numero)
            {
                int tf = x;
                x = y;
                y = tf + y;
            }

            return y == numero;
        }
    }
}
