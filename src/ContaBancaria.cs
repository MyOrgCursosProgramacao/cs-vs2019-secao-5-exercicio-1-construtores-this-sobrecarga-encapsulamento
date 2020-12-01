using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace src
{
    class ContaBancaria
    {
        public int _numero { get; private set; }
        public string _titular { get; set; }
        public double _saldo { get; private set; }

        double taxaSaque = 5.0;

        public ContaBancaria()
        {
        }

        

        public ContaBancaria(int numero, string titular)
        {
            bool sair = false;

            do
            {
                if (numero > 0)
                {
                    _numero = numero;
                    sair = true;
                }
                else
                {
                    Console.Write(Environment.NewLine
                        + "O identificador da conta deve ser um número maior que zero."
                        + Environment.NewLine
                        + "Atribua um novo número identificador da conta: ");
                    numero = int.Parse(Console.ReadLine());
                }
            } while (sair);
            sair = false;

            do
            {
                if (titular == "null")
                {
                    Console.Write(Environment.NewLine
                        + "O nome do titular não pode ser um campo vazio."
                        + Environment.NewLine
                        + "Digite o nome do titular da conta da conta: ");
                    titular = Console.ReadLine();
                }
                else
                {
                    _titular = titular;
                    sair = true;
                }
            } while (sair);

            Console.Write("Deseja fazer um depósito inicial (s/n): ");
            if('s' == char.Parse(Console.ReadLine()))
            {
                Console.Write(Environment.NewLine
                    + "Digite um valor de depósito: R$ ");
                Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            }
        }



        public void Deposito(double valor)
        {
            bool sair = false;

            do
            {
                if (valor > 0.0)
                {
                    _saldo += valor;
                    sair = true;
                }
                else
                {
                    Console.Write(Environment.NewLine
                        + "O valor do depósito deve ser maior que zero."
                        + Environment.NewLine
                        + "Digite um valor de depósito: R$ ");
                    valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
            } while (sair);
        }

        public void Saque(double valor)
        {
            bool sair = false;

            do
            {
                if (valor > 0.0)
                {
                    _saldo -= valor;
                    sair = true;
                }
                else
                {
                    Console.Write(Environment.NewLine
                        + "O valor do saque deve ser maior que zero."
                        + Environment.NewLine
                        + "Digite um valor do saque: R$ ");
                    valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
            } while (sair);
        }



    }
}
