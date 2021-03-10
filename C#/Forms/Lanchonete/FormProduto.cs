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
    public partial class FormProduto : Form
    {

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\SisLanchonete\\DbLanchonete.mdf;Integrated Security=True");

        public FormProduto()
        {
            InitializeComponent();
        }

        public void CarregaDGV()
        {
            try
            {
                String str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\SisLanchonete\\DbLanchonete.mdf;Integrated Security=True";
                String query = "SELECT * FROM [Produto	]";
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable produto = new DataTable();
                da.Fill(produto);
                dgvProduto.DataSource = produto;
                con.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormProduto_Load(object sender, EventArgs e)
        {
            CarregaDGV();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("InserirProduto", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nome", SqlDbType.NChar).Value = txtNome.Text.Trim();
                cmd.Parameters.AddWithValue("@tipo", SqlDbType.NChar).Value = txtTipo.Text.Trim();
                cmd.Parameters.AddWithValue("@quantidade", SqlDbType.NChar).Value = txtQuantidade.Text.Trim();
                cmd.Parameters.AddWithValue("@valor", SqlDbType.Decimal).Value = Convert.ToDecimal(txtValor.Text.Trim());
                cmd.ExecuteNonQuery();
                CarregaDGV();
                MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtTipo.Text = "";
                txtQuantidade.Text = "";
                txtValor.Text = "";
                con.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("AtualizarProduto", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = Convert.ToInt32(txtID.Text.Trim());
                cmd.Parameters.AddWithValue("@nome", SqlDbType.NChar).Value = txtNome.Text.Trim();
                cmd.Parameters.AddWithValue("@tipo", SqlDbType.NChar).Value = txtTipo.Text.Trim();
                cmd.Parameters.AddWithValue("@quantidade", SqlDbType.NChar).Value = txtQuantidade.Text.Trim();
                cmd.Parameters.AddWithValue("@valor", SqlDbType.Decimal).Value = Convert.ToDecimal(txtValor.Text.Trim());
                cmd.ExecuteNonQuery();
                CarregaDGV();
                MessageBox.Show("Produto atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtTipo.Text = "";
                txtQuantidade.Text = "";
                txtValor.Text = "";
                con.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ExcluirProduto", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = Convert.ToInt32(txtID.Text.Trim());
                cmd.ExecuteNonQuery();
                CarregaDGV();
                MessageBox.Show("Produto excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.Text = "";
                txtNome.Text = "";
                txtTipo.Text = "";
                txtQuantidade.Text = "";
                txtValor.Text = "";
                con.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("LocalizarProduto", con);
            cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = Convert.ToInt32(txtID.Text.Trim());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                txtNome.Text = rd["nome"].ToString();
                txtTipo.Text = rd["tipo"].ToString();
                txtQuantidade.Text = rd["quantidade"].ToString();
                txtValor.Text = rd["valor"].ToString();
                rd.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("Nenhum produto localizado com este ID?", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            rd.Close();
            con.Close();
        }

        private void dgvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvProduto.Rows[e.RowIndex];
                txtID.Text = row.Cells[0].Value.ToString();
                txtNome.Text = row.Cells[1].Value.ToString();
                txtTipo.Text = row.Cells[2].Value.ToString();
                txtQuantidade.Text = row.Cells[3].Value.ToString();
                txtValor.Text = row.Cells[4].Value.ToString();
            }
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            string prod = "SELECT nome FROM [Produto	] WHERE nome = @nome";
            SqlCommand cmd = new SqlCommand (prod, con);
            cmd.Parameters.AddWithValue("@nome", SqlDbType.NChar).Value = txtNome.Text.Trim();
            con.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataReader produto = cmd.ExecuteReader();
            if (produto.HasRows)
            {
                MessageBox.Show("Produto já cadastrado! Tente novamente.", "Produto já cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtNome.Focus();
                produto.Close();
                con.Close();
            }
            produto.Close();
            con.Close();
        }
    }
}
