using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desenvolvimento.Models
{
    public class ExerciciosBasicos1
    {
        // 1- Par ou Ímpar: Peça ao usuário para digitar um número e diga se ele é par ou ímpar.

        public static void atividade1()
        {
            Console.WriteLine("Digite um numero");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite um número: ");


            int resultado = numero % 2;

            if (resultado == 0)
            {
                Console.WriteLine("O número que você digitou é Par!");
            }
            else
            {
                Console.WriteLine("O número que você digitou é ímpar!");
            }

        }
    }    
}