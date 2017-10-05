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
        public override void Saca(double valorParaSacar)
        {
            //base.Saca(valorDoSaque + 0.10);
            if (valorParaSacar < 0)
            {
                throw new ArgumentException();
            }
            if (valorParaSacar <= Saldo)
            {
                Saldo -= valorParaSacar + 0.10;
            }
            else
            {
                throw new SaldoInsuficienteException();
            }
        }
    }
}
