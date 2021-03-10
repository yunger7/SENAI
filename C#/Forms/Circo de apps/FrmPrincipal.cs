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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PicBIMC_Click(object sender, EventArgs e)
        {
            FrmIMC imc = new FrmIMC();
            imc.Show();
        }

        private void PicBData_Click(object sender, EventArgs e)
        {
            FrmData data = new FrmData();
            data.Show();
        }

        private void PicBViagem_Click(object sender, EventArgs e)
        {
            FrmViagem viagem = new FrmViagem();
            viagem.Show();
        }

        private void PicBEmprestimo_Click(object sender, EventArgs e)
        {
            FrmEmprestimo emprestimo = new FrmEmprestimo();
            emprestimo.Show();
        }

        private void PicBMoeda_Click(object sender, EventArgs e)
        {
            FrmMoeda moeda = new FrmMoeda();
            moeda.Show();
        }

        private void PicBMega_Click(object sender, EventArgs e)
        {
            FrmMega mega = new FrmMega();
            mega.Show();
        }

        private void PicBDepreciacao_Click(object sender, EventArgs e)
        {
            FrmDepreciacao depre = new FrmDepreciacao();
            depre.Show();
        }

        private void PicBJuros_Click(object sender, EventArgs e)
        {
            FrmJuros juros = new FrmJuros();
            juros.Show();
        }
    }
}
