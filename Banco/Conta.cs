using System.ComponentModel;

namespace Banco
{
    public abstract class Conta : Container
    {
        public int Numero { get; internal set; }
        public double Saldo { get; protected set; }
        public Cliente Titular { get; set; }
        public string Tipo { get; protected set; }

        public Conta()
        {

        }

        public Conta(int numero)
        {
            Numero = numero;
        }

        public abstract bool Deposita(double valorParaDepositar);

        public abstract bool Saca(double valorParaSacar);

        public bool Transfere(Conta destino, double valorDoDeposito)
        {
            if (Saca(valorDoDeposito))
            {
                destino.Deposita(valorDoDeposito);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}