using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero inteiro: ");
            int num = int.Parse(Console.ReadLine());

            if(num % 2 == 0)
            {
                Console.WriteLine("Você digitou um numero PAR!");
            }
            else
            {
                Console.WriteLine("Você digitou um numero IMPAR!");
            }
        }
    }
}
