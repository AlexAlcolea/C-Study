using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu codigo de funcionario: ");
            int cod = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu total de horas trabalhadas: ");
            int horaTrab = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o quanto ganha por hora: ");
            float salHora = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            float total = salHora * horaTrab;

            Console.Write("NUMBER = "+cod);
            Console.Write("\n");
            Console.Write("SALARY = U$ " + total.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("\n");
        }
    }
}
