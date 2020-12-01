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
            SetNumero(numero);
            SetTitular(titular);
            _saldo = 0.0;
        }

        public void SetNumero(int numero)
        {
            bool loop = true;
            do
            {
                if (numero > 0)
                {
                    _numero = numero;
                    loop = false;
                }
                else
                {
                    Console.Write(Environment.NewLine
                        + "O identificador da conta deve ser um número maior que zero."
                        + Environment.NewLine
                        + "Atribua um novo número identificador da conta: ");
                    numero = int.Parse(Console.ReadLine());
                }
            } while (loop);
        }

        public void SetTitular(string titular)
        {
            bool loop = true;
            do
            {
                if (titular == "" || titular.Length < 4)
                {
                    Console.Write(Environment.NewLine
                        + "O nome do titular deve ter pelo menos 5 caracteres."
                        + Environment.NewLine
                        + "Digite o nome do titular da conta da conta: ");
                    titular = Console.ReadLine();
                }
                else
                {
                    _titular = titular;
                    loop = false;
                }
            } while (loop);
        }


        public void Deposito(double valor)
        {
            bool loop = true;

            do
            {
                if (valor > 0.0)
                {
                    _saldo += valor;
                    loop = false;
                }
                else
                {
                    Console.Write(Environment.NewLine
                        + "O valor do depósito deve ser maior que zero."
                        + Environment.NewLine
                        + "Digite um valor de depósito: R$ ");
                    valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
            } while (loop);
        }

        public void Saque(double valor)
        {
            bool loop = true;

            do
            {
                if (valor > 0.0)
                {
                    _saldo -= (valor + taxaSaque);
                    loop = false;
                }
                else
                {
                    Console.Write(Environment.NewLine
                        + "O valor do saque deve ser maior que zero."
                        + Environment.NewLine
                        + "Digite um valor do saque: R$ ");
                    valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
            } while (loop);
        }
        
        public override string ToString()
        {
            return "Conta "
                + _numero
                + ", Titular: "
                + _titular
                + ", Saldo: R$ "
                + _saldo;

        }


    }
}
