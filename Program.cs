using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o codigo da 1ª peça: ");
            int cod1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de peças: ");
            int qnt1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor UN. da peça: ");
            float val1 = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o codigo da 2ª peça: ");
            int cod2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de peças: ");
            int qnt2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor UN. da peça: ");
            float val2 = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            float total = (qnt1 * val1) + (qnt2 * val2);

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
