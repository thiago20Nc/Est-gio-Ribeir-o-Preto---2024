using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira uma string para ser invertida: ");
            string SEntrada = Console.ReadLine();
            Console.WriteLine($"Você digitou: {SEntrada}");
            string reverterString = InverteAString(SEntrada);

            Console.WriteLine($"String invertida: {reverterString}");
        }

        static string InverteAString(string input)
        {
            string reverter = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reverter += input[i];
            }

            return reverter;
        }
    }
}
