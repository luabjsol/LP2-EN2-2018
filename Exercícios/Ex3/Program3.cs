using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            Data d1 = new Data();

            Console.WriteLine("Informe o dia");
            d1.dia = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o mes");
            d1.mes = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o ano");
            d1.ano = int.Parse(Console.ReadLine());

            
            d1.porExtenso();
            d1.emTexto();
        }
    }
}
