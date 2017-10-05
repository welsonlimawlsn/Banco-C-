using System;
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
    public partial class FormCadastroConta : Form
    {
        private Banco formPrincipal;
        public FormCadastroConta(Banco formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();
        }

        private void botaoCadastro_Click(object sender, EventArgs e)
        {
            Conta novaConta;
            switch (comboTipoDeContas.SelectedIndex)
            {
                case 0:
                    novaConta = new ContaCorrente();
                    break;
                case 1:
                    novaConta = new ContaPoupanca();
                    break;
                default:
                    novaConta = new ContaCorrente();
                    break;
            }
            novaConta.Titular = new Cliente(textoTitular.Text);
            formPrincipal.AdicionaConta(novaConta);
            textoNumero.Text = Convert.ToString(Conta.ProximoNumero());
            textoTitular.Text = "";
        }

        private void FormCadastroConta_Load(object sender, EventArgs e)
        {
            string[] tiposDeConta = { "Conta Corrente", "Conta Poupança" };
            comboTipoDeContas.Items.AddRange(tiposDeConta);
            textoNumero.Text = Convert.ToString(Conta.ProximoNumero());
        }
    }
}
