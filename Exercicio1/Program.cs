using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int indice = 13;
            int soma = 0;
            int K = 0;  

            while(K < indice) 
            { 
                K = K + 1;
                soma = soma + K;
            }
            Console.WriteLine(soma);
        }
    }
}
