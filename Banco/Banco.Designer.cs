namespace Banco
{
    partial class Banco
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textoTitular = new System.Windows.Forms.MaskedTextBox();
            this.textoNumero = new System.Windows.Forms.MaskedTextBox();
            this.textoSaldo = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textoValor = new System.Windows.Forms.MaskedTextBox();
            this.botaoDepositar = new System.Windows.Forms.Button();
            this.botaoSacar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textoTipoDeConta = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.botaoTransfere = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboDestino = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.botaoNovaConta = new System.Windows.Forms.Button();
            this.botaoImposto = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(6, 35);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(100, 20);
            this.textoTitular.TabIndex = 0;
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(6, 74);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(100, 20);
            this.textoNumero.TabIndex = 1;
            // 
            // textoSaldo
            // 
            this.textoSaldo.Location = new System.Drawing.Point(7, 113);
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.Size = new System.Drawing.Size(100, 20);
            this.textoSaldo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numero: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Saldo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor: ";
            // 
            // textoValor
            // 
            this.textoValor.Location = new System.Drawing.Point(131, 35);
            this.textoValor.Name = "textoValor";
            this.textoValor.Size = new System.Drawing.Size(100, 20);
            this.textoValor.TabIndex = 7;
            // 
            // botaoDepositar
            // 
            this.botaoDepositar.Location = new System.Drawing.Point(131, 71);
            this.botaoDepositar.Name = "botaoDepositar";
            this.botaoDepositar.Size = new System.Drawing.Size(100, 23);
            this.botaoDepositar.TabIndex = 8;
            this.botaoDepositar.Text = "Depositar";
            this.botaoDepositar.UseVisualStyleBackColor = true;
            this.botaoDepositar.Click += new System.EventHandler(this.botaoDepositar_Click);
            // 
            // botaoSacar
            // 
            this.botaoSacar.Location = new System.Drawing.Point(131, 110);
            this.botaoSacar.Name = "botaoSacar";
            this.botaoSacar.Size = new System.Drawing.Size(100, 23);
            this.botaoSacar.TabIndex = 9;
            this.botaoSacar.Text = "Sacar";
            this.botaoSacar.UseVisualStyleBackColor = true;
            this.botaoSacar.Click += new System.EventHandler(this.BotaoSacar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textoTipoDeConta);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.botaoTransfere);
            this.groupBox1.Controls.Add(this.textoTitular);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textoValor);
            this.groupBox1.Controls.Add(this.botaoDepositar);
            this.groupBox1.Controls.Add(this.botaoSacar);
            this.groupBox1.Controls.Add(this.textoNumero);
            this.groupBox1.Controls.Add(this.textoSaldo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 183);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conta";
            // 
            // textoTipoDeConta
            // 
            this.textoTipoDeConta.Location = new System.Drawing.Point(6, 152);
            this.textoTipoDeConta.Name = "textoTipoDeConta";
            this.textoTipoDeConta.Size = new System.Drawing.Size(100, 20);
            this.textoTipoDeConta.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tipo de Conta:";
            // 
            // botaoTransfere
            // 
            this.botaoTransfere.Location = new System.Drawing.Point(131, 149);
            this.botaoTransfere.Name = "botaoTransfere";
            this.botaoTransfere.Size = new System.Drawing.Size(100, 23);
            this.botaoTransfere.TabIndex = 10;
            this.botaoTransfere.Text = "Tranferir";
            this.botaoTransfere.UseVisualStyleBackColor = true;
            this.botaoTransfere.Click += new System.EventHandler(this.botaoTransfere_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboDestino);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comboContas);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 103);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busca de Conta";
            // 
            // comboDestino
            // 
            this.comboDestino.FormattingEnabled = true;
            this.comboDestino.Location = new System.Drawing.Point(9, 72);
            this.comboDestino.Name = "comboDestino";
            this.comboDestino.Size = new System.Drawing.Size(222, 21);
            this.comboDestino.TabIndex = 3;
            this.comboDestino.SelectedIndexChanged += new System.EventHandler(this.comboDestino_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Conta Destino no caso de Traferencia:";
            // 
            // comboContas
            // 
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(9, 32);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(222, 21);
            this.comboContas.TabIndex = 1;
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Escolha a Conta:";
            // 
            // botaoNovaConta
            // 
            this.botaoNovaConta.Location = new System.Drawing.Point(174, 322);
            this.botaoNovaConta.Name = "botaoNovaConta";
            this.botaoNovaConta.Size = new System.Drawing.Size(75, 23);
            this.botaoNovaConta.TabIndex = 12;
            this.botaoNovaConta.Text = "Nova Conta";
            this.botaoNovaConta.UseVisualStyleBackColor = true;
            this.botaoNovaConta.Click += new System.EventHandler(this.botaoNovaConta_Click);
            // 
            // botaoImposto
            // 
            this.botaoImposto.Location = new System.Drawing.Point(65, 322);
            this.botaoImposto.Name = "botaoImposto";
            this.botaoImposto.Size = new System.Drawing.Size(103, 23);
            this.botaoImposto.TabIndex = 13;
            this.botaoImposto.Text = "Calcular Impostos";
            this.botaoImposto.UseVisualStyleBackColor = true;
            this.botaoImposto.Click += new System.EventHandler(this.botaoImposto_Click);
            // 
            // Banco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 357);
            this.Controls.Add(this.botaoImposto);
            this.Controls.Add(this.botaoNovaConta);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Banco";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Banco_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox textoTitular;
        private System.Windows.Forms.MaskedTextBox textoNumero;
        private System.Windows.Forms.MaskedTextBox textoSaldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox textoValor;
        private System.Windows.Forms.Button botaoDepositar;
        private System.Windows.Forms.Button botaoSacar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboContas;
        private System.Windows.Forms.ComboBox comboDestino;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button botaoTransfere;
        private System.Windows.Forms.Button botaoNovaConta;
        private System.Windows.Forms.MaskedTextBox textoTipoDeConta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button botaoImposto;
    }
}

