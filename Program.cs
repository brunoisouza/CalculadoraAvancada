using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAvancada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Crie um programa que solicite 2 números, e a operação desejada(+, -, /, *). 
                Ao final o programa deve mostrar o resultado com a operação escolhida.
            */

            // Boas Vindas
            Console.WriteLine("--------------------");
            Console.WriteLine("CALCULADORA AVANÇADA");
            Console.WriteLine("--------------------");

            // verificar a senha do usuário
            Console.WriteLine("Informe a senha para continuar: ");
            string senha = Console.ReadLine();

           if (senha != "abacaxi1")
            {
                Console.WriteLine("Senha Incorreta!");
                Console.ReadKey();
                Environment.Exit(0);
            }

            // Limpar a tela
            Console.Clear();

            // Solicitar os 2 números
            Console.Write("Infome o primeiro número:");
            decimal primeiroNumero = decimal.Parse(Console.ReadLine());

            Console.Write("Infome o segundo número:");
            decimal segundoNumero = decimal.Parse(Console.ReadLine());

            // Limpar a tela
            Console.Clear();

            // Solicitar a operação desejada
            Console.Write("Infome a operação desejada: (+, -, /, *)");
            string operacao = Console.ReadLine();

            // Verificar  operação escolhida e efetuar o cálculo

            decimal resultado;

            if (operacao == "+")
                resultado = primeiroNumero + segundoNumero;
            else if (operacao == "-")
                resultado = primeiroNumero - segundoNumero;
            else if (operacao == "*")
                resultado = primeiroNumero * segundoNumero;
            else 
                resultado = primeiroNumero / segundoNumero;

            // Limpar a tela
            Console.Clear();

            // Mostrar o resultado
            Console.WriteLine($"O resultado da operação {primeiroNumero} {operacao} {segundoNumero} é: {resultado}");

            // Aguardar o usuário encerrar o programa
            Console.ReadKey();

        }
    }
}
