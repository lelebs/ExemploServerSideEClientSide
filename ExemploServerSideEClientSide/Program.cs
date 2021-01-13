
using SharedOperations;
using System;
using System.Collections.Generic;

namespace ExemploServerSideEClientSide
{


    class Program
    {

        static void Main(string[] args)
        {        
            IDictionary<int, Func<int, int, int>> DicionarioDeOperacoes = new Dictionary<int, Func<int, int, int>>()
            {
                { 1, BasicOperations.Add },
                { 2, BasicOperations.Sub },
                { 3, BasicOperations.Mult },
                { 4, BasicOperations.Div },
            };

            Console.WriteLine("Digite o número correspondente a operação:");
            Console.WriteLine("************    1 - Adição  **************");
            Console.WriteLine("************    2 - Subtração ************");
            Console.WriteLine("************    3 - Multiplicação  *******");
            Console.WriteLine("************    4 - Divisão  *************");

            int operacao, valorUm, valorDois;
            var entrada = Console.ReadLine();
            int.TryParse(entrada, out operacao);


            Console.WriteLine("Digite o primeiro número:");
            var primeiroValor = Console.ReadLine();

            Console.WriteLine("Digite o segundo número:");
            var segundoValor = Console.ReadLine();

            int.TryParse(primeiroValor, out valorUm);
            int.TryParse(segundoValor, out valorDois);

            Console.WriteLine($"Resultado: {DicionarioDeOperacoes[operacao]?.Invoke(valorUm, valorDois)}");
        }
    }
}
