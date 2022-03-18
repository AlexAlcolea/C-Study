using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course8
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas;

            Console.WriteLine("Digite que horas são: ");
            horas = int.Parse(Console.ReadLine());

            if(horas < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if(horas >= 12 && horas < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Boa noite!");
            }

            Console.WriteLine("-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-");

            int num;

            Console.WriteLine("Digite um numero inteiro: ");
            num = int.Parse(Console.ReadLine());

            if(num % 2 == 0)
            {
                Console.WriteLine($"O numero {num} é PAR!");
            }
            else
            {
                Console.WriteLine($"O numero {num} é IMPAR!");
            }
        }
    }
}
