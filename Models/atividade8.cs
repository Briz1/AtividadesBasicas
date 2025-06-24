using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desenvolvimento.Models
{
    public class ExerciciosBasicos8
    {
        // 8-Conversão de Temperatura: Peça a temperatura em Celsius e converta para Fahrenheit.
        //  Se a temperatura em Fahrenheit for maior que 80, imprima "Temperatura alta".Fórmula: F=C×1.8+32.

        public static void atividade8()
        {
            Console.WriteLine("Diga a temperatura em celsius:");
            double temperatura = Convert.ToDouble(Console.ReadLine());
            double tempFahren = temperatura * 1.8 + 32;

            if (tempFahren >= 80)
            {
                Console.WriteLine($"A temperatura em Fahrenheit está F{tempFahren:0.#}, a temperatura está alta.");
            }
            else
            {
                Console.WriteLine($"A temperatura em Fahrenheit é {tempFahren:0.#}");
            }
        }
    }
}