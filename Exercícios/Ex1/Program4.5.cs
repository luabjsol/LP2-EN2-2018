﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parte_4_e_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();

            Console.Write("Insira a quantidade de veículos");
            qtd = int.Parse(Console.ReadLine());
            string[] vetor = new string[qtd];

            for (int i = 0; i < qtd; i++)
            {


                Console.Write("Insira o modelo do veículo");
                carro.Modelo = Console.ReadLine();
                Console.Write("Insira a quilometragem do veículo");
                carro.Quilometragem = double.Parse(Console.ReadLine());
                Console.Write("Insira a potencia do veículo");
                carro.Potencia = int.Parse(Console.ReadLine());




                vetor[i] = Classificar(carro);
            }
            for (int i = 0; i < qtd; i++)
            {

                Console.WriteLine(vetor[i]);
            }
        }
        public static string Classificar(Carro carro)
        {

            string Est = "";
            string Pot = "";






            if (carro.Quilometragem > 25000)
            {
                Est = "velho -";
            }
            else if (carro.Quilometragem <= 500)
            {
                Est = "Novo -";
            }
            else
            {
                Est = ("seminovo - ");
            }

            if (carro.Potencia > 170)
            {
                Pot = "Potente";
            }

            else if (carro.Potencia < 90)
            {
                Pot = "Popular";
            }
            else
            {
                Pot = "Médio";
            }

            return String.Format("{0} - {1} - {2}", carro.Modelo, Est, Pot);
        }
    }
}
