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
    public partial class FrmJuros : Form
    {
        public FrmJuros()
        {
            InitializeComponent();
        }

        private void FrmJuros_Load(object sender, EventArgs e)
        {
            this.ActiveControl = TxtMontante;
            TxtMontante.Focus();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtMontante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void TxtTaxa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void TxtTempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double principal, taxa, taxa2, anterior, montante, juros;
            int meses;
            anterior = 0.0;
            principal = Convert.ToDouble(TxtMontante.Text);
            taxa = Convert.ToDouble(TxtTaxa.Text);
            meses = Convert.ToInt32(TxtTempo.Text);
            LtBParcelas.Items.Clear();
            LtBParcelas.BeginUpdate();
            for (int i = 1; i <= meses; i++)
            {
                taxa2 = (1 + taxa / 100);
                montante = (Math.Pow(taxa2, i)) * principal;
                juros = montante - principal - anterior;
                anterior += juros;
                string montante2 = montante.ToString("C");
                string juros2 = juros.ToString("C");
                LtBParcelas.Items.Add("Mês: " + i + " - Montante: " + montante2 + " - Juros: " + juros2);
                string total2 = montante.ToString("C");
                LblMostrarTotal.Text = total2;
            }
            LtBParcelas.EndUpdate();
        }
    }
}
