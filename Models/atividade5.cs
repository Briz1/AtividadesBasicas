using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desenvolvimento.Models
{
    public class ExerciciosBasicos5
    {
        // 5-Comparação de Strings: Peça duas palavras ao usuário. 
        // Diga se elas são iguais ou diferentes.
        public static void atividade5()
        {
            Console.WriteLine("Diga a primeira palavra:");
            string palavra1 = Console.ReadLine()!;
            Console.WriteLine("Diga a segunda palavra:");
            string palavra2 = Console.ReadLine()!;

            if (palavra1 == palavra2)
            {
                Console.WriteLine($"A palavra {palavra1} e {palavra2} são iguais");
            }
            else
            {
                Console.WriteLine($"A palavra {palavra1} e {palavra2} são diferentes");
            }
        }
    }
}