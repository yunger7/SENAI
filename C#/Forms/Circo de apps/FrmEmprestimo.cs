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
    public partial class FrmEmprestimo : Form
    {
        public FrmEmprestimo()
        {
            InitializeComponent();
        }

        private void FrmEmprestimo_Load(object sender, EventArgs e)
        {
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

        private void TxtJuros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void TxtPrazo_KeyPress(object sender, KeyPressEventArgs e)
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
            Double ValorEmprestimo, Pagamento, TaxaJuros, ValorTotalPago, ValorJurosPago;
            int PeriodoPagamento;
            try
            {
                TaxaJuros = Convert.ToDouble(TxtJuros.Text);
                PeriodoPagamento = Convert.ToInt32(Convert.ToDouble(TxtPrazo.Text) * 12);
                ValorEmprestimo = Convert.ToDouble(TxtValor.Text);
                if (TaxaJuros >= 1)
                {
                    TaxaJuros = TaxaJuros / 100;
                }
                Pagamento = (ValorEmprestimo * Math.Pow((TaxaJuros / 12) + 1, (PeriodoPagamento)) * TaxaJuros / 12) / (Math.Pow(TaxaJuros / 12 + 1, (PeriodoPagamento)) - 1);
                ValorTotalPago = Pagamento * PeriodoPagamento;
                ValorJurosPago = ValorTotalPago - ValorEmprestimo;
                TxtPagamentoMensal.Text = Pagamento.ToString("N2");
                TxtTotal.Text = ValorTotalPago.ToString("N2");
                TxtJurosPagos.Text = ValorJurosPago.ToString("N2");
                TxtValor.Text = "";
                TxtJuros.Text = "";
                TxtPrazo.Text = "";
                this.ActiveControl = TxtValor;
                TxtValor.Focus();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
