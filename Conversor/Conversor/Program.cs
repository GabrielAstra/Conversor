///Escreva um programa que solicite ao usuário um valor em metros e o converta em centímetros ou milímetros, 
/// dependendo da opção selecionada pelo usuário. O programa deve exibir o resultado da conversão na tela.



using System;

namespace Conversor
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite aqui o valor em metros:");
            double metros = double.Parse(Console.ReadLine());


            Console.WriteLine("Digite 'c' para converter em centímetros, ou digite 'm' para converter em milímetros");
            string opcao = Console.ReadLine();


            double resultado;

            if (opcao == "c")
            {
                resultado = metros * 100;
                Console.WriteLine("{0} metros equivale a {1} centímetros", metros, resultado);
            }

            else if (opcao == "m")
            {
                resultado = metros * 1000;
                Console.WriteLine("{0} metros equivale a {1} milimetros", metros, resultado);
            }

            else
            {
                Console.WriteLine("Opção inválida");
            }
        }
    }
}
