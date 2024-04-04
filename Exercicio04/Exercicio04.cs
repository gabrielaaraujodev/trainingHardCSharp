using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    internal class Exercicio04
    {
        static void Main(string[] args)
        {
             int n = 3;

            while (n < 999) 
            { 
                if (n % 2 != 0)
                {
                    Console.WriteLine(n);
                    n++;
                } else
                {
                    Console.WriteLine("");
                    n++;
                }
            }
            Console.ReadLine();
        }
    }
}
