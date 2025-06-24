using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desenvolvimento.Models
{
    public class ExerciciosBasicos6
    {
        //6-Idade para Votar: Peça a idade do usuário.
        //Diga se ele já pode votar (idade maior ou igual a 16).

        public static void atividade6()
        {
            Console.WriteLine("Digite sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            if (idade >= 16)
            {
                Console.WriteLine("Você já possuí idade para votar!");
            }
            else
            {
                Console.WriteLine("Você ainda não possuí idade para votar.");
            }
        }
    }
}