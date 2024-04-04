using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Exercicio05
    {
        static void Main(string[] args)
        {
            int cont = 1;
            int n1 = 1;
            int n2 = 0;
            int soma;

            Console.WriteLine("Informe a quantidade de números que deve ter a sequência: ");
            var number = int.Parse(Console.ReadLine());

            Console.WriteLine(n2);

            while (cont <= number)
            {
                soma = n1 + n2; 
                n2 = n1; 
                n1 = soma; 
                Console.WriteLine(soma);
                cont++;
            }
            Console.ReadLine();
        }
    }
}
