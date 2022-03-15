using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputData
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de Escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.00;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("PRODUTOS:");
            Console.WriteLine($"{produto1}, cujo preço é $ {preco1:F2}");
            Console.WriteLine($"{produto2}, cujo preço é $ {preco2:F2}");
            Console.Write("\n");
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");
            Console.Write("\n");
            Console.WriteLine($"Medida com 8 casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondado (3 casas decimais): {medida:F3}");
            Console.WriteLine("Separador decimal Invariant Culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
