using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    internal class Exercicio03
    {
        static void Main(string[] args)
        {
            int support = 1;
            int div2 = 0;
            int div3 = 0;
            int div5 = 0;
            int div6 = 0;

            while (support > 0)
            {
                Console.WriteLine("Informe um número: ");
                var number = double.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    div2++;            
                }

                if (number % 3 == 0)
                {
                    div3++;  
                }

                if (number % 5 == 0)
                {
                    div5++;     
                }

                if (number % 6 == 0)
                {
                    div6++;    
                }

                if (number % 2 != 0 && number % 3 != 0 && number % 5 != 0 && number % 6 != 0)
                {
                    Console.WriteLine("Número não é divisível pelos valores");
                }

                if (number == 0)
                {
                    support = 0;
                    Console.ReadLine();
                }

                Console.WriteLine("Quantidade de números divisíveis por 2: " + div2);
                Console.WriteLine("Quantidade de números divisíveis por 3: " + div3);
                Console.WriteLine("Quantidade de números divisíveis por 5: " + div5);
                Console.WriteLine("Quantidade de números divisíveis por 6: " + div6);
            }
            
        }
    }
}
