using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desenvolvimento.Models
{
    public class ExerciciosBasicos4
    {
        // 4-Aprovado ou Reprovado: Peça a nota de um aluno. 
        // Se a nota for maior ou igual a 7, imprima "Aprovado", caso contrário, imprima "Reprovado".
        public static void atividade4()
        {
            Console.WriteLine("Diga a nota do aluno:");
            double nota = Convert.ToDouble(Console.ReadLine());

            if (nota >= 7)
            {
                Console.WriteLine("O aluno foi aprovado!");
            }
            else
            {
                Console.WriteLine("O aluno foi reprovado!");
            }
        }
    }
}