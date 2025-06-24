using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desenvolvimento.Models
{
    public class ExerciciosBasicos2
    {
        // 2-Maior de Dois: Peça dois números e diga qual deles é o maior.

        public static void atividade2()
        {
            Console.WriteLine("Digite um número:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite outro número:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
            Console.WriteLine($"O {num1} e {num2} são iguais");
            }
            else if (num1 > num2)
            {
            Console.WriteLine($"Os número {num1} é maior que {num2}");
            }
            else
            {
            Console.WriteLine($"O número {num1} é menor que {num2}");
            }
        }
    }
}