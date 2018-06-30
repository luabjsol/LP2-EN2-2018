using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Modelo;
            int Quilometragem;
            int Potencia;

            Console.WriteLine("Informe a QUILOMETRAGEM");
            Quilometragem = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o MODELO");
            Modelo = Console.ReadLine();

            Console.WriteLine("Informe a POTENCIA");
            Potencia = int.Parse(Console.ReadLine());

            {
                if (Quilometragem >= 0 && Quilometragem <= 5000)
                    Console.Write("O carro e novo");

                else if (Quilometragem > 5000 && Quilometragem <= 25000)
                    Console.Write("O carro é seminovo");

                else
                    Console.Write("O carro é velho");
            }

            Console.WriteLine("");

            if (Potencia > 170)
                Console.Write("O carro é potente");

            else if (Potencia >= 80 && Potencia <= 170)
                Console.Write("O carro é MEDIO");

            else
                Console.Write("O carro é FRACO");

            Console.WriteLine("");
        }
    }
}
