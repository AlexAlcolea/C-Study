using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace InputData_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?: ");
            int qntQuartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu ultimo nome, idade e altura: ");
            string[] infos = Console.ReadLine().Split(' ');

            double alt = (double.Parse(infos[2], CultureInfo.InvariantCulture));

            Console.WriteLine("--------------------------------");
            Console.WriteLine(nome);
            Console.WriteLine(qntQuartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(infos[0]);
            Console.WriteLine(infos[1]);
            Console.WriteLine(alt.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
