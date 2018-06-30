using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    class Elevador
    {
        class Elevador
    {
        public int TotAndar;
        public int AndarAtual;
        public int QtdMax;
        public int QtdAtual;



        public void Entra()
        {
            Console.WriteLine("Informe a quantidade de passageiros a ser adicionada:");
            int resp2 = int.Parse(Console.ReadLine());

            if (QtdAtual + resp2 <= QtdMax)
            {
                QtdAtual = QtdAtual + resp2;
                Console.WriteLine("A Quantidade de passageiros no elevador é de: {0}", QtdAtual);

            }

         }
        
                
              

            

         public void Sai()
         {
            Console.WriteLine("Informe a quantidade de passsageiros a ser retirada:");
            int resp4 = int.Parse(Console.ReadLine());

            if (QtdAtual - resp4 > 0)
            {
                QtdAtual = QtdAtual - resp4;
                Console.WriteLine("A quantidade atual de passageiros é de: {0}", QtdAtual);          
            }
                 
         }



         public void Vai()
         {
             Console.WriteLine("Informe o andar que gostaria de ir:");
             int resp5 = int.Parse(Console.ReadLine());

             if (resp5 >= 0 && resp5 <= TotAndar)
             {
                 AndarAtual = resp5;
                 Console.WriteLine("O andar atual é: {0}", AndarAtual);
             }

         }

             public void Emergencia()
             {
                 Console.WriteLine("Ligando para o Corpo de Bombeiros (193)");
                 Console.Beep();
                 Console.Beep();
                 Console.Beep();
             }



             }
    }


       
 class Elevador
    {
        public int TotAndar;
        public int AndarAtual;
        public int QtdMax;
        public int QtdAtual;



        public void Entra()
        {
            Console.WriteLine("Informe a quantidade de passageiros a ser adicionada:");
            int resp2 = int.Parse(Console.ReadLine());

            if (QtdAtual + resp2 <= QtdMax)
            {
                QtdAtual = QtdAtual + resp2;
                Console.WriteLine("A Quantidade de passageiros no elevador é de: {0}", QtdAtual);

            }

         }
        
                
              

            

         public void Sai()
         {
            Console.WriteLine("Informe a quantidade de passsageiros a ser retirada:");
            int resp4 = int.Parse(Console.ReadLine());

            if (QtdAtual - resp4 > 0)
            {
                QtdAtual = QtdAtual - resp4;
                Console.WriteLine("A quantidade atual de passageiros é de: {0}", QtdAtual);          
            }
                 
         }



         public void Vai()
         {
             Console.WriteLine("Informe o andar que gostaria de ir:");
             int resp5 = int.Parse(Console.ReadLine());

             if (resp5 >= 0 && resp5 <= TotAndar)
             {
                 AndarAtual = resp5;
                 Console.WriteLine("O andar atual é: {0}", AndarAtual);
             }

         }

             public void Emergencia()
             {
                 Console.WriteLine("Ligando para o Corpo de Bombeiros (193)");
                 Console.Beep();
                 Console.Beep();
                 Console.Beep();
             }



             }
    }
    

