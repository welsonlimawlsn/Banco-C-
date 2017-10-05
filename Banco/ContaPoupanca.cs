using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class ContaPoupanca : Conta
    {
        public ContaPoupanca() {
            Tipo = "Conta Poupança";
        }
        public ContaPoupanca(int numero) : base(numero) { }
        public override bool Saca(double valorParaSacar)
        {
            //base.Saca(valorDoSaque + 0.10);
            if (valorParaSacar <= Saldo)
            {
                Saldo -= valorParaSacar + .10;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool Deposita(double valorParaDepositar)
        {
            if(valorParaDepositar > 0)
            {
                Saldo += valorParaDepositar;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
