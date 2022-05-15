using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o seu nome");
            string nomePessoa = Console.ReadLine();
            

            Console.Write("Qual é a sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Meu nome é: " + nomePessoa + " e minha idade é " + idade);
            
        }
    }
}