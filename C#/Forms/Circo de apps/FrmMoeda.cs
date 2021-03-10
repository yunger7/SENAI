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
    public partial class FrmMoeda : Form
    {
        public FrmMoeda()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMoeda_Load(object sender, EventArgs e)
        {
            this.ActiveControl = TxtValor;
            TxtValor.Focus();
        }

        private void BtnConverter_Click(object sender, EventArgs e)
        {
            double valor, rdolar, reuro, rfranco, rien;
            valor = Convert.ToDouble(TxtValor.Text);
            rdolar = valor / 5.23;
            reuro = valor / 6.30;
            rfranco = valor / 5.81;
            rien = valor / 0.05;
            LblMostrarDolar.Text = rdolar.ToString("N2");
            LblMostrarEuro.Text = reuro.ToString("N2");
            LblMostrarFranco.Text = rfranco.ToString("N2");
            LblMostrarIen.Text = rien.ToString("N2");
            TxtValor.Text = "";
            this.ActiveControl = TxtValor;
            TxtValor.Focus();
        }

        private void TxtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }
    }
}
