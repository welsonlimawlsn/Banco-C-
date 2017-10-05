using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Banco : Form
    {
        private List<Conta> contas;
        private Conta contaSelecionada;
        private Conta contaSelecionadaDestino;
        private int numeroDeContas = 0;
        public Banco()
        {
            InitializeComponent();
        }

        private void Banco_Load(object sender, EventArgs e)
        {
            contas = new List<Conta>();
            /*
            contas[0] = new ContaCorrente(1);
            contas[0].Titular = new Cliente("Welson");

            contas[1] = new ContaPoupanca(2);
            contas[1].Titular = new Cliente("Wilson");

            contas[2] = new ContaCorrente(3);
            contas[2].Titular = new Cliente("Iraldo");

            
            foreach (Conta conta in contas)
            {
                comboContas.Items.Add(conta.Titular.Nome);
                comboDestino.Items.Add(conta.Titular.Nome);
            }
            */
        }

        private void botaoDepositar_Click(object sender, EventArgs e)
        {
            double valorDigitado = Convert.ToDouble(textoValor.Text);
            if (contaSelecionada.Deposita(valorDigitado))
            {
                MessageBox.Show("Sucesso!");
            }
            else
            {
                MessageBox.Show("Falhou!");
            }
            textoSaldo.Text = Convert.ToString(contaSelecionada.Saldo);
            
        }

        private void BotaoSacar_Click(object sender, EventArgs e)
        {
            double valorDigitado = Convert.ToDouble(textoValor.Text);
            if (contaSelecionada.Saca(valorDigitado))
            {
                MessageBox.Show("Sucesso!");
            }
            else
            {
                MessageBox.Show("Falhou!");
            }
            textoSaldo.Text = Convert.ToString(contaSelecionada.Saldo);
        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            contaSelecionada = contas[comboContas.SelectedIndex];
            textoTitular.Text = contaSelecionada.Titular.Nome;
            textoNumero.Text = Convert.ToString(contaSelecionada.Numero);
            textoSaldo.Text = Convert.ToString(contaSelecionada.Saldo);
            textoTipoDeConta.Text = contaSelecionada.Tipo;
        }

        private void comboDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            contaSelecionadaDestino = contas[comboDestino.SelectedIndex];
        }

        private void botaoTransfere_Click(object sender, EventArgs e)
        {
            if(contaSelecionada != null && contaSelecionadaDestino != null)
            {
                if (contaSelecionada.Transfere(contaSelecionadaDestino, Convert.ToDouble(textoValor.Text)))
                {
                    textoSaldo.Text = Convert.ToString(contaSelecionada.Saldo);
                    MessageBox.Show("Sucesso!");
                }
                else
                {
                    MessageBox.Show("Falhou!");
                }
            }
            else
            {
                MessageBox.Show("Falhou!");
            }
        }

        public void AdicionaConta(Conta conta)
        {
            contas.Add(conta);
            comboContas.Items.Add(conta.Titular.Nome);
            comboDestino.Items.Add(conta.Titular.Nome);
            numeroDeContas++;

        }

        private void botaoNovaConta_Click(object sender, EventArgs e)
        {
            FormCadastroConta formularioDeCadastro = new FormCadastroConta(this);
            formularioDeCadastro.ShowDialog();
        }

        private void botaoImposto_Click(object sender, EventArgs e)
        {
            TotalizadorDeImpostos totalizador = new TotalizadorDeImpostos();

            foreach(Conta conta in contas)
            {
                if(conta is ITributavel tributavel)
                {
                    totalizador.Adiciona(tributavel);
                }
            }
            MessageBox.Show(Convert.ToString(totalizador.Total));
        }
    }
}
