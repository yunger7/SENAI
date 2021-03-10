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
    public partial class FrmViagem : Form
    {
        public FrmViagem()
        {
            InitializeComponent();
        }

        private void FrmViagem_Load(object sender, EventArgs e)
        {
            this.ActiveControl = TxtAutonomia;
            TxtAutonomia.Focus();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtAutonomia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void TxtCombustivel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void TxtDistancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double preco, autonomia, distancia, combustivel, gasto;
            preco = Convert.ToDouble(TxtCombustivel.Text);
            autonomia = Convert.ToDouble(TxtAutonomia.Text);
            distancia = Convert.ToDouble(TxtDistancia.Text);
            combustivel = distancia / autonomia;
            gasto = combustivel * preco;
            LblMostrarLitros.Text = combustivel.ToString("F") + " litros gastos.";
            LblGastos.Text = "R$ " + gasto.ToString("F");
            TxtCombustivel.Text = "";
            TxtAutonomia.Text = "";
            TxtDistancia.Text = "";
            this.ActiveControl = TxtAutonomia;
            TxtAutonomia.Focus();
        }
    }
}
