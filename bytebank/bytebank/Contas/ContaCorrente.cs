using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank.Titular;

namespace bytebank.Contas
{
    public class ContaCorrente
    {
        public static int TotalContasCriadas { get; private set; }
        private int numeroAgencia;
        public int NumeroAgencia
        {
            get { return this.numeroAgencia; }
            private set { if (value > 0)
                {
                    this.numeroAgencia = value;
                } }
        }
        public string Conta { get; set; }
        public Cliente Titular { get; set; }
        private double saldo = 100;

        public ContaCorrente(int numeroAgencia, string conta)
        {
            this.NumeroAgencia = numeroAgencia;
            this.Conta = conta;
            TotalContasCriadas++;
        }

        public ContaCorrente(int numeroAgencia, string conta, Cliente titular, double saldo)
        {
            this.NumeroAgencia = numeroAgencia;
            this.Conta = conta;
            this.Titular = titular;
            this.saldo = saldo;
            TotalContasCriadas++;
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (Sacar(valor))
            {
                destino.Depositar(valor);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SetSaldo(double valor)
        {
            if (valor < 0)
            {
                return;
            }
            else
            {
                this.saldo = valor;
            }
        }

        public double GetSaldo()
        {
            return this.saldo;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Informacoes da conta do {Titular.Nome}: Agencia: {numeroAgencia}, Número: {Conta}, Saldo: R$ {string.Format("{0:0.00}", saldo)}");
        }
    }
}
