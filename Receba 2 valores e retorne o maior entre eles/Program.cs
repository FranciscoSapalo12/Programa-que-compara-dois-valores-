using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receba_2_valores_e_retorne_o_maior_entre_eles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Enunciado===========================================================
            /*1. Faça um programa que receba 2 valores e retorne o maior entre eles.
             * 
             */
            //Estrutura de dados==================================================
            int n1, n2;


            //Algaritimo=====================================================
            Console.WriteLine("Insira o primeiro número");
            n1 = int.Parse(Console.ReadLine());


            Console.WriteLine("Insira o segundo número");
            n2 = int.Parse(Console.ReadLine());


            if (n1 > n2)
                Console.WriteLine("O maior é o  :" + n1);
            else if (n1 < n2)
                Console.WriteLine("O maior é o :" + n2);
            else
                Console.WriteLine("São ambos iguais: " + n1);
            Console.ReadLine();

        }
    }
}
