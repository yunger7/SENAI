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
    public partial class FrmMega : Form
    {
        public FrmMega()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSortear_Click(object sender, EventArgs e)
        {
            LbNumeros.Items.Clear();
            LbNumeros.BeginUpdate();
            Random randnum = new Random();
            for (int i = 0; i <= 5; i++)
            {
                LbNumeros.Items.Add(randnum.Next(60));
            }
            LbNumeros.EndUpdate();
        }
    }
}
