using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP2
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txt1Valor;
            txt1Valor.Focus();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;
            valor1 = Convert.ToDouble(txt1Valor.Text);
            valor2 = Convert.ToDouble(txt2Valor.Text);
            resultado = valor1 + valor2;
            lblMostrar.Text = resultado.ToString();
            txt1Valor.Text = "";
            txt2Valor.Text = "";
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;
            valor1 = Convert.ToDouble(txt1Valor.Text);
            valor2 = Convert.ToDouble(txt2Valor.Text);
            resultado = valor1 - valor2;
            lblMostrar.Text = resultado.ToString();
            txt1Valor.Text = "";
            txt2Valor.Text = "";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;
            valor1 = Convert.ToDouble(txt1Valor.Text);
            valor2 = Convert.ToDouble(txt2Valor.Text);
            resultado = valor1 * valor2;
            lblMostrar.Text = resultado.ToString();
            txt1Valor.Text = "";
            txt2Valor.Text = "";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;
            valor1 = Convert.ToDouble(txt1Valor.Text);
            valor2 = Convert.ToDouble(txt2Valor.Text);
            resultado = valor1 / valor2;
            lblMostrar.Text = resultado.ToString();
            txt1Valor.Text = "";
            txt2Valor.Text = "";
        }
    }
}
