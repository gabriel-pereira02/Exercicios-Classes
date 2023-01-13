using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06
{
    class ContaBancaria
    {
        private double SaldoConta;
        public int NumContaBancaria { get; private set; }
        public string NomeTitular { get; set; }

        public ContaBancaria(int numContaBancaria , string nomeTitular)
        {
            NumContaBancaria = numContaBancaria;
            NomeTitular = nomeTitular;
            SaldoConta = 0;
        }

        public ContaBancaria(int numContaBancaria, string nomeTitular, double saldoConta) : this(numContaBancaria, nomeTitular)
        {
            SaldoConta = saldoConta;
        }


        public void Depositar(double valorDepositado)
        {
            SaldoConta += valorDepositado;
            Console.WriteLine($"Conta: {NumContaBancaria}, Nome do Titular: {NomeTitular}, Saldo da Conta: R${SaldoConta}");
        }

        public void Sacar(double valorSaque)
        {
            SaldoConta -= (valorSaque+5);
            Console.WriteLine($"Conta: {NumContaBancaria}, Nome do Titular: {NomeTitular}, Saldo da Conta: R${SaldoConta}");
        }

        public override string ToString()
        {
            return $"Conta: {NumContaBancaria}, Nome do Titular: {NomeTitular}, Saldo da Conta: R${SaldoConta}";
        }
    }
}
