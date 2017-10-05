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
        public override bool Saca(double valorParaSacar)
        {
            //base.Saca(valorParaSacar + 0.10);
            if (valorParaSacar <= Saldo)
            {
                Saldo -= valorParaSacar + 0.10;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool Deposita(double valorParaDepositar)
        {
            //base.Deposita(valorParaDepositar - 0.05);
            if (valorParaDepositar > 0)
            {
                Saldo += valorParaDepositar - 0.05;
                return true;
            }
            else
            {
                return false;
            }

        }

        public double CalcularTrubutos()
        {
            return Saldo / 100 * 5;
        }
    }
}
