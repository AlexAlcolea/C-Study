using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a hora inicial e a hora final: ");
            string[] valores = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(valores[0]);
            int horaFinal = int.Parse(valores[1]);

            int totalHoras = 0;

            if(horaInicial > horaFinal)
            {
                totalHoras = (24 - horaInicial) + horaFinal;
            }
            else if(horaInicial == horaFinal)
            {
                totalHoras = 24;
            }
            else
            {
                totalHoras = horaFinal - horaInicial;
            }

            Console.WriteLine($"O JOGO DUROU {totalHoras} HORA(S)");
        }
    }
}
