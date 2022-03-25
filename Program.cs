using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int item, qnt;
            double total = 0;
            Console.WriteLine("Digite o codigo do item: ");
            item = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade do item: ");
            qnt = int.Parse(Console.ReadLine());
            switch (item)
            {
                case 1:
                    total = qnt * 4.00;
                    break;
                case 2:
                    total = qnt * 4.50;
                    break;
                case 3:
                    total = qnt * 5.00;
                    break;
                case 4:
                    total = qnt * 2.00;
                    break;
                case 5:
                    total = qnt * 1.50;
                    break;
                default:
                    Console.WriteLine("Você digitou um codigo de item invalido");
                    break;
            }
            //Console.WriteLine(total);
            Console.WriteLine("Total: R$ " + total.ToString("F2"));
        }
    }
}
