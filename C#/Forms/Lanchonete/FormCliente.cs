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
    public partial class FormCliente : Form
    {

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\SisLanchonete\\DbLanchonete.mdf;Integrated Security=True");

        public FormCliente()
        {
            InitializeComponent();
        }

        public void CarregaDGV()
        {
            String str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\SisLanchonete\\DbLanchonete.mdf;Integrated Security=True";
            String query = "SELECT * FROM Cliente";
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable cliente = new DataTable();
            da.Fill(cliente);
            dgvCliente.DataSource = cliente;
            con.Close();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            CarregaDGV();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("InserirCliente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cpf", SqlDbType.NChar).Value = txtCPF.Text.Trim();
                cmd.Parameters.AddWithValue("@nome", SqlDbType.NChar).Value = txtNome.Text.Trim();
                cmd.Parameters.AddWithValue("@cidade", SqlDbType.NChar).Value = txtCidade.Text.Trim();
                cmd.Parameters.AddWithValue("@celular", SqlDbType.NChar).Value = txtCelular.Text.Trim();
                cmd.Parameters.AddWithValue("@email", SqlDbType.NChar).Value = txtEmail.Text.Trim();
                cmd.ExecuteNonQuery();
                CarregaDGV();
                MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCPF.Text = "";
                txtNome.Text = "";
                txtCidade.Text = "";
                txtCelular.Text = "";
                txtEmail.Text = "";
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
                SqlCommand cmd = new SqlCommand("AtualizarCliente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cpf", SqlDbType.NChar).Value = txtCPF.Text.Trim();
                cmd.Parameters.AddWithValue("@nome", SqlDbType.NChar).Value = txtNome.Text.Trim();
                cmd.Parameters.AddWithValue("@cidade", SqlDbType.NChar).Value = txtCidade.Text.Trim();
                cmd.Parameters.AddWithValue("@celular", SqlDbType.NChar).Value = txtCelular.Text.Trim();
                cmd.Parameters.AddWithValue("@email", SqlDbType.NChar).Value = txtEmail.Text.Trim();
                cmd.ExecuteNonQuery();
                CarregaDGV();
                MessageBox.Show("Cliente atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCPF.Text = "";
                txtNome.Text = "";
                txtCidade.Text = "";
                txtCelular.Text = "";
                txtEmail.Text = "";
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
                SqlCommand cmd = new SqlCommand("ExcluirCliente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cpf", SqlDbType.NChar).Value = txtCPF.Text.Trim();
                cmd.ExecuteNonQuery();
                CarregaDGV();
                MessageBox.Show("Cliente excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCPF.Text = "";
                txtNome.Text = "";
                txtCidade.Text = "";
                txtCelular.Text = "";
                txtEmail.Text = "";
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
            SqlCommand cmd = new SqlCommand("LocalizarCliente", con);
            cmd.Parameters.AddWithValue("@cpf", SqlDbType.NChar).Value = txtCPF.Text.Trim();
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                txtCPF.Text = rd["cpf"].ToString();
                txtNome.Text = rd["nome"].ToString();
                txtCidade.Text = rd["cidade"].ToString();
                txtCelular.Text = rd["celular"].ToString();
                txtEmail.Text = rd["email"].ToString();
                rd.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("Nenhum cliente localizado com este CPF?", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            rd.Close();
            con.Close();
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvCliente.Rows[e.RowIndex];
                txtCPF.Text = row.Cells[0].Value.ToString();
                txtNome.Text = row.Cells[1].Value.ToString();
                txtCidade.Text = row.Cells[2].Value.ToString();
                txtCelular.Text = row.Cells[3].Value.ToString();
                txtEmail.Text = row.Cells[4].Value.ToString();
            }
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            string cli = "SELECT cpf FROM Cliente WHERE cpf = @cpf";
            SqlCommand cmd = new SqlCommand(cli, con);
            cmd.Parameters.AddWithValue("@cpf", SqlDbType.NChar).Value = txtCPF.Text.Trim();
            con.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataReader cliente = cmd.ExecuteReader();
            if (cliente.HasRows)
            {
                MessageBox.Show("CPF de cliente já cadastrado! Tente novamente.", "Cliente já cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCPF.Text = "";
                txtCPF.Focus();
                cliente.Close();
                con.Close();
            }
            cliente.Close();
            con.Close();
        }
    }
}
