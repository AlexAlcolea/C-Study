using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: ");
            double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double area = (Math.Pow(raio, 2)) * 3.14159;

            Console.WriteLine("A area do raio do numero digitado é: " + area.ToString("F4",CultureInfo.InvariantCulture));
        }
    }
}
