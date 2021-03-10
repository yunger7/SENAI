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
    public partial class FrmIMC : Form
    {
        public FrmIMC()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmIMC_Load(object sender, EventArgs e)
        {
            this.ActiveControl = TxtPeso;
            TxtPeso.Focus();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            Double peso, altura, resultado;
            peso = Convert.ToDouble(TxtPeso.Text);
            altura = Convert.ToDouble(TxtAltura.Text);
            resultado = (peso / (altura * altura));
            LblMostrar.Text = resultado.ToString("F");
            TxtPeso.Text = "";
            TxtAltura.Text = "";
            if (resultado < 18)
            {
                MessageBox.Show("Magreza", "IMC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (resultado <= 24)
            {
                MessageBox.Show("Normal", "IMC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (resultado <= 29)
            {
                MessageBox.Show("Sobrepeso", "IMC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (resultado <= 39)
            {
                MessageBox.Show("Obesidade", "IMC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Obesidade Grave", "IMC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TxtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void TxtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }
    }
}
