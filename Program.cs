using System;

namespace CalculadoraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Calculadora Avançada SENAI ---");
           
            Console.Write("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escolha a operação: (+, -, *, /)");
            string operacao = Console.ReadLine();

            double resultado = 0;

            // Estrutura de decisão para selecionar a operação
            switch (operacao)
            {
                case "+": resultado = num1 + num2; break;
                case "-": resultado = num1 - num2; break;
                case "*": resultado = num1 * num2; break;
                case "/":
                    // Verificação de segurança: divisão por zero
                    resultado = num2 != 0 ? num1 / num2 : 0;
                    if(num2 == 0) Console.WriteLine("Erro: Divisão por zero!");
                    break;
                default:
                    Console.WriteLine("Operação inválida!");
                    return;
            }

            Console.WriteLine($"O resultado de {num1} {operacao} {num2} é: {resultado}");
        }
    }
}