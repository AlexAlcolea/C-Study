using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 valores: ");
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double triangulo = a * c / 2.0;
            double circulo = Math.Pow(c, 2) * 3.14159;
            double trapezio = (a + b) / 2.0 * c;
            double quadrado = Math.Pow(b, 2);
            double retangulo = a * b;

            Console.WriteLine("TRIANGULO: "+triangulo.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: "+circulo.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: "+trapezio.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " +quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " +retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
