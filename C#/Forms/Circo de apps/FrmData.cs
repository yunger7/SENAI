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
    public partial class FrmData : Form
    {
        public FrmData()
        {
            InitializeComponent();
        }

        private void FrmData_Load(object sender, EventArgs e)
        {
            this.ActiveControl = MaskInicial;
            MaskInicial.Focus();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            DateTime inicial = Convert.ToDateTime(MaskInicial.Text);
            DateTime final = Convert.ToDateTime(MaskFinal.Text);
            if (inicial > final)
            {
                TimeSpan date = inicial - final;
                int dias = date.Days;
                LblMostrar.Text = dias.ToString() + " dias.";
            }
            else
            {
                TimeSpan date = final - inicial;
                int dias = date.Days;
                LblMostrar.Text = dias.ToString() + " dias.";
            }
            MaskInicial.Text = "";
            MaskFinal.Text = "";
            this.ActiveControl = MaskInicial;
            MaskInicial.Focus();
        }
    }
}
