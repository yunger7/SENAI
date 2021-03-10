using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircodeApps2
{
    public partial class FrmDepreciacao : Form
    {
        public FrmDepreciacao()
        {
            InitializeComponent();
        }

        private void FrmDepreciacao_Load(object sender, EventArgs e)
        {
            this.ActiveControl = TxtPreco;
            TxtPreco.Focus();
        }

        private void TxtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void TxtAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double dano, dmes, valor, preco;
            int anoatual, anoveiculo, resultado;
            anoveiculo = Convert.ToInt32(TxtAno.Text);
            anoatual = DateTime.Now.Year;
            resultado = anoatual - anoveiculo;
            valor = Convert.ToDouble(TxtPreco.Text);
            dano = valor / resultado;
            dmes = dano / 12;
            preco = valor - dano;
            LblMostrarAno.Text = "R$ " + dano.ToString("N2");
            LblMostrarMensal.Text = "R$ " + dmes.ToString("N2");
            LblMostrarPreco.Text = "R$ " + preco.ToString("N2");
            TxtPreco.Text = "";
            TxtAno.Text = "";
            this.ActiveControl = TxtPreco;
            TxtPreco.Focus();
        }
    }
}
