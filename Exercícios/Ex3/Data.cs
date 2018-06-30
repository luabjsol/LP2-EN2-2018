using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Data
    {
        public int dia;
        public int mes;
        public int ano;
      

        public bool validar()
        {
                if (ano >= 0) { 
                    if ((mes >= 1) && (mes <= 12)) {
                        if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12){
                            if (dia >= 1 && dia <= 31)
                                return true;
                            else
                                return false;
                        }
                        else if (mes == 4 || mes == 6 || mes == 9 || mes == 11){
                            if (dia >= 1 && dia <= 30)
                                return true;
                            else
                                return false;
                        }
                        else{
                            //Mês de fevereiro
                            if (ano % 4 != 0){
                                if (dia >= 1 && dia <= 28)
                                    return true;
                                else
                                    return false;
                            }
                            else if (ano % 4 == 0){//Ano pode ser bissexto

                                if (ano % 100 != 0){ //Ano bissexto

                                    if (dia >= 1 && dia <= 29)
                                        return true;
                                    else
                                        return false;
                                }
                                else{

                                    if (ano % 400 == 0)
                                        return true;
                                    else
                                        return false;
                                }
                            }
                        }
                    }
                    else
                        return false;
                }
                else
                    return false;
                return true;
            

        } //fiz so pra ver se uma data existe, pode ignorar

        public void emTexto()
        {
            if (validar())
            {
                Console.WriteLine(this.dia + "/" + this.mes + "/" + this.ano);
            }
            else
            {
                Console.WriteLine("Data não é válida.");
            }
        }

        public void porExtenso() {
            if (this.mes == 1)
                Console.WriteLine("{0} de janeiro de {1}", this.dia, this.ano);
            if (this.mes == 2)
                Console.WriteLine("{0} de fevereiro de {1}", this.dia, this.ano);
            if (this.mes == 3)
                Console.WriteLine("{0} de março de {1}", this.dia, this.ano);
            if (this.mes == 4)
                Console.WriteLine("{0} de abril de {1}", this.dia, this.ano);
            if (this.mes == 5)
                Console.WriteLine("{0} de maio de {1}", this.dia, this.ano);
            if (this.mes == 6)
                Console.WriteLine("{0} de junho de {1}", this.dia, this.ano);
            if (this.mes == 7)
                Console.WriteLine("{0} de julho de {1}", this.dia, this.ano);
            if (this.mes == 8)
                Console.WriteLine("{0} de agosto de {1}", this.dia, this.ano);
            if (this.mes == 9)
                Console.WriteLine("{0} de setembro de {1}", this.dia, this.ano);
            if (this.mes == 10)
                Console.WriteLine("{0} de outubro de {1}", this.dia, this.ano);
            if (this.mes == 11)
                Console.WriteLine("{0} de novembro de {1}", this.dia, this.ano);
            if (this.mes == 12)
                Console.WriteLine("{0} de dezembro de {1}", this.dia, this.ano);
        }

        public void amanha() {

            if (this.dia == 31 && (this.mes == 1 || this.mes == 3 || this.mes == 5 || this.mes == 7 || this.mes == 8 || this.mes == 10))
            {
                this.dia = 1;
                this.mes += 1;
            }
            else if (this.dia == 30 && (this.mes == 4 || this.mes == 6 || this.mes == 9 || this.mes == 11))
            {
                this.dia = 1;
                this.mes += 1;
            }
            else if (this.dia == 31 && this.mes == 12)
            {
                this.dia = 1;
                this.mes = 1;
                this.ano += 1;
            }
            else if ((this.dia == 28) && (this.mes == 2) && (this.ano % 4 != 0))
            {
                this.dia = 1;
                this.mes += 1;
            }
            else if ((this.dia == 28) && (this.mes == 2) && (this.ano % 4 == 0))
            {
                this.dia += 1;
            }
            else if ((this.dia == 29) && (this.mes == 2) && (this.ano % 4 == 0))
            {
                this.dia = 1;
                this.mes += 1;
            }
            else
                this.dia += 1;
            Console.WriteLine("Amanha: " + this.dia + "/" + this.mes + "/" + this.ano);
        }
        
        public void ontem()
        {
            if (this.dia == 1 && this.mes == 1)
            {
                this.dia = 32;
                this.mes = 12;
                this.ano -= 1;
            }
            if (this.dia == 1 && (this.mes == 5 || this.mes == 7))
            {
                this.dia = 30;
                this.mes -= 1;
            }
            else if (this.dia == 1 && (this.mes== 2 || this.mes == 4 || this.mes == 6 || this.mes == 9 || this.mes == 11))
            {
                this.dia = 31;
                this.mes -= 1;
            }

            else if (this.dia == 1 && (this.mes == 3) && (this.ano % 4 != 0))
            {
                this.dia = 28;
                this.mes = 2;
            }
            else if (this.dia == 1 && (this.mes == 3) && (this.ano % 4 == 0))
            {
                this.dia = 29;
                this.mes = 2;
            }
            else
                this.dia -= 1;
            Console.WriteLine("Ontem: " + this.dia + "/" + this.mes + "/" + this.ano);


        }
    }
}
    