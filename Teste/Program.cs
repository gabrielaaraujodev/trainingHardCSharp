using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n; int support = 1; int fatorial = 1;

            for (n = 1; n<=10; n++)
            {
                Console.WriteLine("Informe um número: ");
                var number = int.Parse(Console.ReadLine());

                while (fatorial <= number)
                {
                    support = support * fatorial++;
                    Console.WriteLine(support);
                }
            }
            Console.ReadLine();
        }
    }
}
