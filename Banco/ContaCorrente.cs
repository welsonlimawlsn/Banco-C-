using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class ContaCorrente : Conta, ITributavel
    {
        public ContaCorrente() {
            Tipo = "Conta Corrente";
        }
        public ContaCorrente(int numero) : base(numero) { }
        public override void Saca(double valorParaSacar)
        {
            //base.Saca(valorParaSacar + 0.10);
            if(valorParaSacar < 0)
            {
                throw new ArgumentException();
            }
            if (valorParaSacar <= Saldo)
            {
                Saldo -= valorParaSacar + 0.10;
            } else
            {
                throw new SaldoInsuficienteException();
            }
        }

        public override void Deposita(double valorParaDepositar)
        {
            //base.Deposita(valorParaDepositar - 0.05);
            base.Deposita(valorParaDepositar - 0.05);

        }

        public double CalcularTrubutos()
        {
            return Saldo / 100 * 5;
        }
    }
}
