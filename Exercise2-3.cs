using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 2 numeros: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int resul = 0;

            if(a > b)
            {
                resul = a % b;
            }
            else
            {
                resul = b % a;
            }

            if(resul == 0)
            {
                Console.WriteLine("São Multiplos");
            }
            else
            {
                Console.WriteLine("Não são Multiplos");
            }


        }
    }
}
