using System;
using System.ComponentModel;

namespace Banco
{
    public abstract class Conta : Container
    {
        public int Numero { get; internal set; }
        public double Saldo { get; protected set; }
        public Cliente Titular { get; set; }
        public string Tipo { get; protected set; }
        private static int numeroDeContas;

        public Conta()
        {
            numeroDeContas++;
            Numero = numeroDeContas;
        }

        public Conta(int numero)
        {
            Numero = numero;
        }

        public virtual void Deposita(double valorParaDepositar)
        {
            if (valorParaDepositar > 0)
            {
                Saldo += valorParaDepositar;
            } else
            {
                throw new ArgumentException();
            }
        }

        public abstract void Saca(double valorParaSacar);

        public void Transfere(Conta destino, double valorDoDeposito)
        {
            Saca(valorDoDeposito);
            destino.Deposita(valorDoDeposito);
        }

        public static int ProximoNumero()
        {
            return numeroDeContas + 1;
        }
    }
}