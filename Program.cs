using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2º numero: ");
            int y = int.Parse(Console.ReadLine());

            int total = y + x;

            Console.WriteLine($"A soma de {y} + {x} é {total}");
        }
    }
}
