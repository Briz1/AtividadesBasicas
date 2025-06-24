using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desenvolvimento.Models
{
    public class ExerciciosBasicos10
    {
        // 10-Categoria por Idade: Peça a idade de uma pessoa e classifique-a em "Criança" (até 12 anos),
        //  "Adolescente" (13 a 17 anos) ou "Adulto" (18 anos ou mais).

        public static void atividade10()
        {
            Console.WriteLine("Qual é a sua idade?");
            int idade = Convert.ToInt32(Console.ReadLine());


            if (idade >= 1 && idade <= 12)
            {
                Console.WriteLine($"Você tem {idade} anos, logo você é criança.");
            }
            else if (idade >= 13 && idade <= 17)
            {
                Console.WriteLine($"Você tem {idade} anos, logo você é adolescente.");
            }
            else if (idade <= 0)
            {
                Console.WriteLine("Idade inválida.");
            }
            else
            {
                Console.WriteLine($"Você tem {idade} anos, logo você já é um adulto.");
            }
        }        
    }
}