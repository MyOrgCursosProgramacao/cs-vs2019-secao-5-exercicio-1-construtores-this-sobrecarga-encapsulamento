using System;
using System.Globalization;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Resolução do Exercício proposto 1 da Seção 5" + Environment.NewLine);
            Console.WriteLine("Entre com os dados da conta bancária.");

            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Nome do titular da conta: ");
            string titular = Console.ReadLine();
            ContaBancaria contaBancaria = new ContaBancaria(numero, titular);


            Console.Write(Environment.NewLine + "Deseja fazer um depósito inicial (s/n): ");
            if ('s' == char.Parse(Console.ReadLine()))
            {
                Console.Write(Environment.NewLine
                    + "Digite um valor de depósito: R$ ");
                contaBancaria.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine(Environment.NewLine + contaBancaria.ToString());
            }

            Console.Write(Environment.NewLine + "Entre um valor para depósito: R$ ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.Deposito(valor);

            Console.Write(Environment.NewLine + "Entre um valor para saque: R$ ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.Saque(valor);
        }
    }
}
