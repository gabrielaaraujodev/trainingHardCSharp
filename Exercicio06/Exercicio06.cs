using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06
{
    internal class Exercicio06
    {
        static void Main(string[] args)
        {
            double cont = 1;
            double n1 = 0;
            double soma = 0;

            Console.WriteLine("Informe o valor de n : ");
            var n = int.Parse(Console.ReadLine());

            while (cont <= n)
            {
                soma = soma + 1/cont;
                Console.WriteLine(soma);
                cont++;
            }
            Console.ReadLine();
        }
    }
}
