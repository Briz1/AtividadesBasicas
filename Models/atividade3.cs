using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desenvolvimento.Models
{
    public class ExerciciosBasicos3
    {
        // 3-Positivo, Negativo ou Zero: Peça um número e diga se ele é positivo, negativo ou zero.
        public static void atividade3()
        {
            Console.WriteLine("Digite um número:");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero == 0)
            {
                Console.WriteLine("Você digitou um numero sem valor");
            }
            else if (numero < 0)
            {
                Console.WriteLine("Você digitou um número negativo");
            }
            else 
            {
                Console.WriteLine("Você digitou um valor positivo");
            }
        }
    }
}