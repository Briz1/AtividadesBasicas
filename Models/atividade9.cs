using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desenvolvimento.Models
{
    public class ExerciciosBasicos9
    {

        // 9-Login Simples: Peça um nome de usuário e uma senha.
        //  Se o nome for "admin" e a senha for "123", imprima "Login bem-sucedido".
        public static void atividade9()
        {

            Console.WriteLine("Digite o Usúario:");
            string user = Console.ReadLine()!;
            Console.WriteLine("Digite a Senha:");
            string senha = Console.ReadLine()!;

            if (user == "admin" && senha == "123")
            {
                Console.WriteLine("Login bem-sucedido!");
            }
            else
            {
                Console.WriteLine("Usúario ou senha errado.");
            }

        }
    }
}