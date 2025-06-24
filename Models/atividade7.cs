using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desenvolvimento.Models
{
    public class ExerciciosBasicos7
    {
        // 7-Desconto na Compra: Peça o valor de uma compra.
        //  Se o valor for maior que R$ 100, aplique um desconto de 10% e mostre o novo valor.


        public static void atividade7()
        {
            Console.WriteLine("Qual o valor da compra?");
            decimal preco = Convert.ToDecimal(Console.ReadLine());
            decimal desconto = preco / 10;
            decimal novopreco = preco - desconto;



            if (preco >= 100)
            {
                Console.WriteLine($"O preço que você digitou é {preco} sem o desconto, e com o desconto de 10% ficará {Math.Round(novopreco, 2)}");
            }
            else
            {
                Console.WriteLine($"O preço que você digitou de {preco} é um valor abaixo de R$ 100, então não aplicará o desconto.");
            }
        }
    }
}