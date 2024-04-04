using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    internal class Exercicio02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Converter de centímetros para metros");
            Console.WriteLine("2 - Converter de metros para centímetros");
            Console.WriteLine("3 - Converter de milímetros para metros");
            Console.WriteLine("4 - Converter de metros para milímetros");
            var option = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o primeiro valor: ");
            var value = double.Parse(Console.ReadLine());

            switch (option)
            {
                case 0:
                    Console.WriteLine("Este valor em metros é: " + value / 100);
                    break;

                case 1:
                    Console.WriteLine("Este valor em centímetros é: " + value * 100);
                    break;

                case 2:
                    Console.WriteLine("Este valor em metros é: " + value / 1000);
                    break;

                case 3:
                    Console.WriteLine("Este valor em milímetro é: " + value*1000);
                    break; 

                default:
                    Console.WriteLine("Opção Inválida !");
                    break;
            }
        }
    }
}
