using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string Sexo;

            Console.WriteLine("digite o sexo M para Masculino F para feminino ");
            Sexo = Console.ReadLine();


            while (Sexo != "F" && Sexo != "M")
            {
                Console.WriteLine("Resposta invalida digite M/F para uma resposta valida");
                Sexo= Console.ReadLine();
            }

                if (Sexo == "F")
            
                {
                Console.WriteLine("Sexo Feminio selecionado");
                 
                 }


                else 
                {

                Console.WriteLine("Sexo Masculino Selecionado");
                
                }


            }
        }
    }

