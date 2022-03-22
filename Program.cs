using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero inteiro: ");
            int num = int.Parse(Console.ReadLine());

            if(num > 0)
            {
                Console.WriteLine("POSITIVO");
            }
            else if(num == 0)
            {
                Console.WriteLine("VOCÊ DIGITIOU 0");
            }
            else
            {
                Console.WriteLine("NEGATIVO");
            }
        }
    }
}
