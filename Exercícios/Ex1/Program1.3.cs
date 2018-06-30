using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parte_3
{
    class Program
    {
        static void Main(string[] args)
        
             {
            
            string novo = VerificarNovo();
            string potencia = VerificarPotencia();

            Console.Write("{0}" , novo);
            Console.WriteLine("");
            Console.Write("{0}", potencia);
            Console.WriteLine("");
            Console.WriteLine("");
        }

            static string VerificarNovo()

            {
            string Modelo;
            int Quilometragem;

            Console.WriteLine("Informe a QUILOMETRAGEM");
            Quilometragem = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o MODELO");
            Modelo = Console.ReadLine();


            {
                if (Quilometragem >= 0 && Quilometragem <= 5000)
                   return ("O carro e novo");

                else if (Quilometragem > 5000 && Quilometragem <= 25000)
                    return("O carro é seminovo");

                else
                    return ("O carro é velho");
            }

      }

            static string VerificarPotencia()
            {
            int Potencia;
              Console.WriteLine("Informe a POTENCIA");
              Potencia = int.Parse(Console.ReadLine());
               { 
                    if (Potencia > 170)
                    return ("O carro é potente");

                    else if (Potencia >= 80 && Potencia <= 170)
                    return ("O carro é MEDIO");

                    else
                    return("O carro é FRACO");
               }
          }
        }
    }

