using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SisLanchonete
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                String str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\SisLanchonete\\DbLanchonete.mdf;Integrated Security=True";
                String query = "SELECT * FROM Usuario";
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                DataSet ds = new DataSet();
                MessageBox.Show("Conectado ao Banco de Dados!", "Teste de Banco", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro de Acesso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsuario formUsuario = new FormUsuario();
            formUsuario.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCliente formCliente = new FormCliente();
            formCliente.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProduto formProduto = new FormProduto();
            formProduto.Show();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVenda formVenda = new FormVenda();
            formVenda.Show();
        }
    }
}
